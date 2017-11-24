namespace WasmNet.Opcodes {
    public class I32Store8Opcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i32.store8 {Address}";

    }
}
