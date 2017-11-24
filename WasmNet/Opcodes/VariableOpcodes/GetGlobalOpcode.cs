namespace WasmNet.Opcodes {
    public class GetGlobalOpcode : BaseOpcode {

        public uint GlobalIndex { get; set; }

        public override string ToString() => $"get_global {GlobalIndex}";

    }
}
