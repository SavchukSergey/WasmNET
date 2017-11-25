namespace WasmNet.Opcodes {
    public class F32ConstOpcode : BaseOpcode {

        public float Value { get; set; }

        public override string ToString() => $"f32.const {Value}";

    }
}
