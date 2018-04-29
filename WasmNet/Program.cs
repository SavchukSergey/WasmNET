using System;
using System.IO;
using WasmNet.Nodes;

namespace WasmNet {
    public static class Program {

        public static void Main(string[] args) {
            using (var file = File.Open(args[0], FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) {
                var reader = new WasmReader(file);
                var module = reader.ReadModule();

                var moduleNode = WasmNode.Compile(module);

                var writer = new NodeWriter();
                moduleNode.ToString(writer);
                Console.WriteLine(writer.ToString());

                Console.WriteLine("read");
                Console.ReadKey();
            }
        }
    }
}
