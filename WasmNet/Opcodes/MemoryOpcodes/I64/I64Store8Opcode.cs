namespace WasmNet.Opcodes {
    public class I64Store8Opcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i64.store8 {Address}";

    }
}
