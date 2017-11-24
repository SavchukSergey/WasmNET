namespace WasmNet.Opcodes {
    public class CallIndirectOpcode : BaseOpcode {

        public uint TypeIndex { get; set; }

        public uint Reserved { get; set; }

        public override string ToString() => $"call_indirect {TypeIndex}";

    }
}
