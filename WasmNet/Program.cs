using System;
using System.IO;

namespace WasmNet {
    public static class Program {

        public static void Main() {
            using (var file = File.Open(@"d:\temp\cn.wasm", FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) {
                var reader = new WasmReader(file);
                var module = reader.ReadModule();
                var typeSection = module.ReadTypeSection();
                var importSection = module.ReadImportSection();
                var funcSection = module.ReadFunctionSection();
                var tableSection = module.ReadTableSection();
                var memorySection = module.ReadMemorySection();
                var globalSection = module.ReadGlobalSection();
                var exportSection = module.ReadExportSection();
                var startSection = module.ReadStartSection();
                var elemSection = module.ReadElementSection();
                var codeSection = module.ReadCodeSection();
                Console.WriteLine("read");
                Console.ReadKey();
            }
        }
    }
}
