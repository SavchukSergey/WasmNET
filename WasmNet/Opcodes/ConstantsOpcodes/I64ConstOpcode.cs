namespace WasmNet.Opcodes {
    public class I64ConstOpcode : BaseOpcode {

        public long Value { get; set; }

        public override string ToString() => $"i64.const {Value}";

    }
}
