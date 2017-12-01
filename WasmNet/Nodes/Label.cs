namespace WasmNet.Nodes {
    public class Label {

        public string Name { get; set; }

        public ExecutableNode Source { get; set; }

        public ExecutableNode Target { get; set; }

    }
}
