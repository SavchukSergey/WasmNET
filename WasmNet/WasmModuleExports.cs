using System;
using WasmNet.Data;

namespace WasmNet {
    public class WasmModuleExports {

        private readonly WasmModuleInstance _instance;

        public WasmModuleExports(WasmModuleInstance instance) {
            _instance = instance;
        }

        public int Execute(string exportName, params object[] args) {
            foreach (var exportSection in _instance.Module.ExportSections) {
                for (var funcIndex = 0; funcIndex < exportSection.Entries.Count; funcIndex++) {
                    var entry = exportSection.Entries[funcIndex];
                    if (entry.Kind == WasmExternalKind.Function && entry.Field == exportName) {
                        var funcTypeIndex = _instance.Module.Function.Entries[funcIndex];
                        var signature = _instance.Module.Type.Entries[(int)funcTypeIndex];
                        var body = _instance.Module.Code.Bodies[funcIndex];
                        var context = new WasmFunctionState(signature, body) {
                            InstructionPointer = 0,
                            ModuleInstance = _instance
                        };
                        for (var i = 0; i < signature.Parameters.Count; i++) {
                            var param = signature.Parameters[i];
                            var variable = context.ResolveLocalVariable((uint)i);
                            switch (param) {
                                case WasmType.I32:
                                    variable.SetUI32(Convert.ToUInt32(args[i]));
                                    break;
                            }
                        }
                        while (context.InstructionPointer < body.Opcodes.Count) {
                            var opcode = body.Opcodes[context.InstructionPointer];
                            context.InstructionPointer++;
                            opcode.Execute(context);
                        }
                        return (int)context.PopUI32();
                    }
                }
            }
            return 0;
        }

    }
}
