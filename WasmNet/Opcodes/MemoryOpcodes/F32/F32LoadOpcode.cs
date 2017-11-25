namespace WasmNet.Opcodes {
    public class F32LoadOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"f32.load {Address}";

    }
}
