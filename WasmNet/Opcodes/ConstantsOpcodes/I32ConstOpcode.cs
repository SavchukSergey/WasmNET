namespace WasmNet.Opcodes {
    public class I32ConstOpcode : BaseOpcode {

        public int Value { get; set; }

        public override string ToString() => $"i32.const {Value}";

    }
}
