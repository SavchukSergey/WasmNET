namespace WasmNet.Opcodes {
    public class F64LoadOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"f64.load {Address}";

    }
}
