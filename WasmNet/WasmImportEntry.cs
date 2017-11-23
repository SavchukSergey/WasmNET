namespace WasmNet {
    public class WasmImportEntry {

        public string Module { get; set; }

        public string Field { get; set; }

        public WasmExternalKind Kind { get; set; }


        public uint TypeIndex { get; set; }

        public WasmGlobalType Global { get; set; }

        public WasmMemoryEntry Memory { get; set; }

        public WasmTableEntry Table { get; set; }

        public override string ToString() {
            switch (Kind) {
                case WasmExternalKind.Function:
                    return $"Func({TypeIndex}) = {Module}.{Field}";
                case WasmExternalKind.Global:
                    return $"Global({Global.Type} {(Global.Mutable ? "mutable" : "")}) = {Module}.{Field}";
                case WasmExternalKind.Memory:
                    return $"Memory({Memory.Limits.Initial}, {Memory.Limits.Maximum}) = {Module}.{Field}";
                case WasmExternalKind.Table:
                    return $"Table({Table.Limits.Initial}, {Table.Limits.Maximum}) = {Module}.{Field}";
                default: return $"{Kind} = {Module}.{Field}";
            }
        }

    }
}
