namespace WasmNet.Opcodes {
    public class BlockOpcode : BaseOpcode {

        public WasmType Signature { get; set; }

        public override string ToString() => $"block {Signature}";

    }
}
