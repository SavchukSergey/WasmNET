namespace WasmNet.Opcodes {
    public class BrOpcode : BaseOpcode {

        public uint RelativeDepth { get; set; }

        public override string ToString() => $"br {RelativeDepth}";

    }
}
