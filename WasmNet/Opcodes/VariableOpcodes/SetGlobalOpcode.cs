namespace WasmNet.Opcodes {
    public class SetGlobalOpcode : BaseOpcode {

        public uint GlobalIndex { get; set; }

        public override string ToString() => $"set_global {GlobalIndex}";

    }
}
