namespace WasmNet.Opcodes {
    public class BrIfOpcode : BaseOpcode {

        public uint RelativeDepth { get; set; }

        public override string ToString() => $"br_if {RelativeDepth}";

    }
}
