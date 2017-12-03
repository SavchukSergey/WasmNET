using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class TeeLocalOpcode : BaseOpcode {

        public uint LocalIndex { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var variable = state.ResolveLocalVariable(LocalIndex);
            switch (variable.Type) {
                case WasmType.I32:
                    variable.UInt32 = state.PopUI32();
                    state.PushUI32(variable.UInt32);
                    break;
                case WasmType.I64:
                    variable.UInt64 = state.PopUI64();
                    state.PushUI64(variable.UInt64);
                    break;
                case WasmType.F32:
                    variable.Float32 = state.PopF32();
                    state.PushF32(variable.Float32);
                    break;
                case WasmType.F64:
                    variable.Float64 = state.PopF64();
                    state.PushF64(variable.Float64);
                    break;
            }
        }

        public override string ToString() => $"tee_local {LocalIndex}";

    }
}
