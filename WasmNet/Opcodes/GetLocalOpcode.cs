namespace WasmNet.Opcodes {
    public class GetLocalOpcode : BaseOpcode {

        public uint LocalIndex { get; set; }

        public override string ToString() => $"get_local {LocalIndex}";

    }
}
