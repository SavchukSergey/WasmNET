using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class GlobalGetOpcode : BaseOpcode {

        public GlobalGetOpcode(uint globalIndex) {
            GlobalIndex = globalIndex;
        }
        
        public uint GlobalIndex { get; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var variable = state.ResolveGlobalVariable(GlobalIndex);
            switch (variable.Type) {
                case WasmType.I32:
                    state.PushUI32(variable.UInt32);
                    break;
                case WasmType.I64:
                    state.PushUI64(variable.UInt64);
                    break;
                case WasmType.F32:
                    state.PushF32(variable.Float32);
                    break;
                case WasmType.F64:
                    state.PushF64(variable.Float64);
                    break;
            }
        }

        public override string ToString() => $"global.get {GlobalIndex}";

    }
}
