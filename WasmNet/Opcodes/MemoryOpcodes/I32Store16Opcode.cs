namespace WasmNet.Opcodes {
    public class I32Store16Opcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i32.store16 {Address}";

    }
}
