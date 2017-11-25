using System;
using System.IO;
using WasmNet.MSIL;

namespace WasmNet {
    public static class Program {

        public static void Main() {
            var d = Convert.FromBase64String("AGFzbQEAAAABh4CAgAABYAJ/fwF/A4KAgIAAAQAGgYCAgAAAB4eAgIAAAQNhZGQAAAqNgICAAAGHgICAAAAgASAAags=");
            var r = new WasmReader(d);
            var m = r.ReadModule();
            var code = m.ReadCodeSection().Bodies[0];
            var func = m.ReadFunctionSection().Entries[0];
            var type = m.ReadTypeSection().Entries[(int)func];
            var dyn = WasmMSIL.Compile(type, code);
            var res = dyn.Invoke(null, new object[] { 12, 45 });

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
                var dataSection = module.ReadDataSection();
                Console.WriteLine("read");
                Console.ReadKey();
            }
        }
    }
}
