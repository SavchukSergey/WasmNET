namespace WasmNet.Opcodes {
    public class LoopOpcode : BaseOpcode {

        public WasmType Signature { get; set; }

        public override string ToString() => $"loop {Signature}";

    }
}
