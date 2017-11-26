using WasmNet.Data;

namespace WasmNet {
    public class WasmSection {

        public WasmSectionCode Code { get; set; }

        public string Name { get; set; }

        public byte[] Payload { get; set; }

        public override string ToString() => $"{Code} {Name}";

    }
}
