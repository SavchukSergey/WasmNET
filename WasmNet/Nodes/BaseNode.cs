using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class BaseNode {

        public abstract void ToString(NodeWriter writer);

        public abstract void ToSExpressionString(NodeWriter writer);

        public virtual WasmType ResultType => WasmType.BlockType;

        public sealed override string ToString() {
            var writer = new NodeWriter();
            ToSExpressionString(writer);
            return writer.ToString().Trim();
        }

        protected static string ConvertType(WasmType type) {
            switch (type) {
                case WasmType.I32: return "i32";
                case WasmType.I64: return "i64";
                case WasmType.F32: return "f32";
                case WasmType.F64: return "f64";
                case WasmType.BlockType: return "";
                default:
                    throw new WasmNodeException($"unknown value type {type}");
            }
        }

        protected static string ConvertValueType(WasmType type) {
            switch (type) {
                case WasmType.I32: return "i32";
                case WasmType.I64: return "i64";
                case WasmType.F32: return "f32";
                case WasmType.F64: return "f64";
                default:
                    throw new WasmNodeException($"unknown value type {type}");
            }
        }

    }
}
