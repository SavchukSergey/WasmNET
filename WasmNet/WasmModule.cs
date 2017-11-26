using System.Collections.Generic;
using WasmNet.Data;
using WasmNet.Sections;

namespace WasmNet {
    public class WasmModule {

        public uint Version { get; set; }

        public IList<WasmSection> Sections { get; } = new List<WasmSection>();

        public WasmTypeSection ReadTypeSection() {
            var section = FindSection(WasmSectionCode.Type);
            if (section == null) return null;
            var reader = new WasmReader(section.Payload);
            return reader.ReadTypeSection();
        }

        public WasmImportSection ReadImportSection() {
            var section = FindSection(WasmSectionCode.Import);
            if (section == null) return null;
            var reader = new WasmReader(section.Payload);
            return reader.ReadImportSection();
        }

        public WasmFunctionSection ReadFunctionSection() {
            var section = FindSection(WasmSectionCode.Function);
            if (section == null) return null;
            var reader = new WasmReader(section.Payload);
            return reader.ReadFunctionSection();
        }

        public WasmTableSection ReadTableSection() {
            var section = FindSection(WasmSectionCode.Table);
            if (section == null) return null;
            var reader = new WasmReader(section.Payload);
            return reader.ReadTableSection();
        }

        public WasmMemorySection ReadMemorySection() {
            var section = FindSection(WasmSectionCode.Memory);
            if (section == null) return null;
            var reader = new WasmReader(section.Payload);
            return reader.ReadMemorySection();
        }

        public WasmGlobalSection ReadGlobalSection() {
            var section = FindSection(WasmSectionCode.Global);
            if (section == null) return null;
            var reader = new WasmReader(section.Payload);
            return reader.ReadGlobalSection();
        }

        public WasmExportSection ReadExportSection() {
            var section = FindSection(WasmSectionCode.Export);
            if (section == null) return null;
            var reader = new WasmReader(section.Payload);
            return reader.ReadExportSection();
        }

        public WasmStartSection ReadStartSection() {
            var section = FindSection(WasmSectionCode.Start);
            if (section == null) return null;
            var reader = new WasmReader(section.Payload);
            return reader.ReadStartSection();
        }

        public WasmElementSection ReadElementSection() {
            var section = FindSection(WasmSectionCode.Element);
            if (section == null) return null;
            var reader = new WasmReader(section.Payload);
            return reader.ReadElementSection();
        }

        public WasmCodeSection ReadCodeSection() {
            var section = FindSection(WasmSectionCode.Code);
            if (section == null) return null;
            var reader = new WasmReader(section.Payload);
            return reader.ReadCodeSection();
        }

        public WasmDataSection ReadDataSection() {
            var section = FindSection(WasmSectionCode.Data);
            if (section == null) return null;
            var reader = new WasmReader(section.Payload);
            return reader.ReadDataSection();
        }

        private WasmSection FindSection(WasmSectionCode code) {
            foreach (var sec in Sections) {
                if (sec.Code == code) return sec;
            }
            return null;
        }
    }
}
