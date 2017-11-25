namespace WasmNet.Opcodes {
    public class F64ConstOpcode : BaseOpcode {

        public double Value { get; set; }

        public override string ToString() => $"f64.const {Value}";

    }
}
