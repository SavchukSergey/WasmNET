namespace WasmNet.Nodes {
    public abstract class BaseNode {

        public abstract void ToString(NodeWriter writer);

        public sealed override string ToString() {
            var writer = new NodeWriter();
            ToString(writer);
            return writer.ToString().Trim();
        }

    }
}
