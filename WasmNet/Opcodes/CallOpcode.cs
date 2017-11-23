namespace WasmNet.Opcodes {
    public class CallOpcode : BaseOpcode {

        public uint FunctionIndex { get; set; }

        public override string ToString() => $"call {FunctionIndex}";

    }
}
