namespace WasmNet.Opcodes {
    public class IfOpcode : BaseOpcode {

        public WasmType Signature { get; set; }

        public override string ToString() => $"if {Signature}";

    }
}
