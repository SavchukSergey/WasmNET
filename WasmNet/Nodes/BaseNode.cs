using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class BaseNode {

        public abstract void ToString(NodeWriter writer);

        public sealed override string ToString() {
            var writer = new NodeWriter();
            ToString(writer);
            return writer.ToString().Trim();
        }

        protected static void AssertValueType(WasmType resultType) {
            if (resultType == WasmType.I32) return;
            if (resultType == WasmType.I64) return;
            if (resultType == WasmType.F32) return;
            if (resultType == WasmType.F64) return;
            throw new WasmNodeException($"value type expected, but {resultType} occured.");
        }

    }
}
