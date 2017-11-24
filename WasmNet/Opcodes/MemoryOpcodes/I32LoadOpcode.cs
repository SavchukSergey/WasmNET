namespace WasmNet.Opcodes {
    public class I32LoadOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i32.load {Address}";

    }
}
