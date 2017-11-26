using System;
using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode : IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult> {

        public static void Compile(WasmModule module) {
            var funcSection = module.ReadFunctionSection();
            var codeSection = module.ReadCodeSection();
            var typeSection = module.ReadTypeSection();

            for (var i = 0; i < funcSection.Entries.Count; i++) {
                var func = funcSection.Entries[0];
                var sig = typeSection.Entries[(int)func];
                var code = codeSection.Bodies[i];

                var arg = new WasmNodeArg();
                var visitor = new WasmNode();
                foreach (var opcode in code.Opcodes) {
                    opcode.AcceptVistor(visitor, arg);
                }
                if (arg.Stack.Count > 0) {
                    arg.Execution.Add(new ReturnNode(arg.Stack.Pop()));
                }

                var writer = new NodeWriter();
                writer.StartLine();
                writer.Write($"void func_{i}() {{");
                writer.EndLine();
                writer.Indent();
                arg.Execution.ToString(writer);
                writer.Unindent();
                writer.StartLine();
                writer.Write("}");
                writer.EndLine();

                Console.WriteLine(writer.ToString());
                Console.WriteLine();
            }
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(CallOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();
        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(CallIndirectOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();
        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(DropOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();
        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(SelectOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();
        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(BaseOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();
    }
}
