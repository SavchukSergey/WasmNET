using System.Collections.Generic;

namespace WasmNet.Opcodes {
    public class BrTableOpcode : BaseOpcode {

        public IList<uint> Targets { get; } = new List<uint>();

        public uint DefaultTarget { get; set; }

        public override string ToString() => $"br_table TODO";

    }
}
