using System.Collections.Generic;
using System.Text;

namespace WasmNet {
    public class WasmFunctionSignature {

        public IList<WasmType> Parameters { get; } = new List<WasmType>();

        public IList<WasmType> Returns { get; } = new List<WasmType>();

        public WasmType? Return => Returns.Count > 0 ? new WasmType?(Returns[0]) : null;

        public override string ToString() {
            var sb = new StringBuilder();
            sb.Append("(");
            for (var i = 0; i < Parameters.Count; i++) {
                if (i != 0) sb.Append(", ");
                sb.Append(Parameters[i].ToString().ToLowerInvariant());
            }
            sb.Append(") => (");
            for (var i = 0; i < Returns.Count; i++) {
                if (i != 0) sb.Append(", ");
                sb.Append(Returns[i].ToString().ToLowerInvariant());
            }
            sb.Append(")");
            return sb.ToString();
        }

    }
}
