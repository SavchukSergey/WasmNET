namespace WasmNet.Nodes {
    public class Label {

        public string Name { get; set; }

        public ExecutableNode Start { get; set; }

        public ExecutableNode End { get; set; }

    }
}
