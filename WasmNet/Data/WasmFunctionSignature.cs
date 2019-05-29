using System;
using System.Collections.Generic;
using System.Text;

namespace WasmNet.Data {
    public class WasmFunctionSignature {

        public WasmFunctionSignature(IReadOnlyList<WasmType> parameters, IReadOnlyList<WasmType> returns) {
            if (parameters == null) {
                throw new ArgumentNullException(nameof(parameters));
            }
            if (returns == null) {
                throw new ArgumentNullException(nameof(returns));
            }
            Parameters = parameters;
            Returns = returns;
        }

        public IReadOnlyList<WasmType> Parameters { get; }

        public IReadOnlyList<WasmType> Returns { get; }

        public WasmType Return => Returns.Count > 0 ? Returns[0] : WasmType.BlockType;

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
