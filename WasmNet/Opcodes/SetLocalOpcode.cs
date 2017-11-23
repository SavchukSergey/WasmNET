namespace WasmNet.Opcodes {
    public class SetLocalOpcode : BaseOpcode {

        public uint LocalIndex { get; set; }

        public override string ToString() => $"set_local {LocalIndex}";

    }
}
