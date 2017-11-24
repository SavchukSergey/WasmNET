namespace WasmNet.Opcodes {
    public class I64LoadOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i64.load {Address}";

    }
}
