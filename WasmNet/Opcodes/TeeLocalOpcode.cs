namespace WasmNet.Opcodes {
    public class TeeLocalOpcode : BaseOpcode {

        public uint LocalIndex { get; set; }

        public override string ToString() => $"tee_local {LocalIndex}";

    }
}
