using System.Collections.Generic;
using System.Linq;
using WasmNet.Data;
using WasmNet.Sections;

namespace WasmNet {
    public class WasmModule {

        public uint Version { get; set; }

        public IList<WasmTypeSection> TypeSections { get; } = new List<WasmTypeSection>();

        public IList<WasmImportSection> ImportSections { get; } = new List<WasmImportSection>();

        public IList<WasmFunctionSection> FunctionSections { get; } = new List<WasmFunctionSection>();

        public IList<WasmTableSection> TableSections { get; } = new List<WasmTableSection>();

        public IList<WasmMemorySection> MemorySections { get; } = new List<WasmMemorySection>();

        public IList<WasmGlobalSection> GlobalSections { get; } = new List<WasmGlobalSection>();

        public IList<WasmExportSection> ExportSections { get; } = new List<WasmExportSection>();

        public IList<WasmStartSection> StartSections { get; } = new List<WasmStartSection>();

        public IList<WasmElementSection> ElementSections { get; } = new List<WasmElementSection>();

        public IList<WasmCodeSection> CodeSections { get; } = new List<WasmCodeSection>();

        public IList<WasmDataSection> DataSections { get; } = new List<WasmDataSection>();

        public IList<WasmSection> CustomSections { get; } = new List<WasmSection>();


        public WasmTypeSection Type => TypeSections.FirstOrDefault();

        public WasmImportSection Import => ImportSections.FirstOrDefault();

        public WasmFunctionSection Function => FunctionSections.FirstOrDefault();

        public WasmGlobalSection Global => GlobalSections.FirstOrDefault();

        public WasmCodeSection Code => CodeSections.FirstOrDefault();

        public void AcceptSection(WasmSection section) {
            var reader = new WasmReader(section.Payload);
            switch (section.Code) {
                case WasmSectionCode.Type:
                    TypeSections.Add(reader.ReadTypeSection());
                    break;
                case WasmSectionCode.Import:
                    ImportSections.Add(reader.ReadImportSection());
                    break;
                case WasmSectionCode.Function:
                    FunctionSections.Add(reader.ReadFunctionSection());
                    break;
                case WasmSectionCode.Table:
                    TableSections.Add(reader.ReadTableSection());
                    break;
                case WasmSectionCode.Memory:
                    MemorySections.Add(reader.ReadMemorySection());
                    break;
                case WasmSectionCode.Global:
                    GlobalSections.Add(reader.ReadGlobalSection());
                    break;
                case WasmSectionCode.Export:
                    ExportSections.Add(reader.ReadExportSection());
                    break;
                case WasmSectionCode.Start:
                    StartSections.Add(reader.ReadStartSection());
                    break;
                case WasmSectionCode.Element:
                    ElementSections.Add(reader.ReadElementSection());
                    break;
                case WasmSectionCode.Code:
                    CodeSections.Add(reader.ReadCodeSection());
                    break;
                case WasmSectionCode.Data:
                    DataSections.Add(reader.ReadDataSection());
                    break;
                default:
                    CustomSections.Add(section);
                    break;
            }
        }

    }
}
