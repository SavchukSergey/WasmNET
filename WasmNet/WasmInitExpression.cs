using System.Collections.Generic;
using WasmNet.Opcodes;

namespace WasmNet {
    public class WasmInitExpression {

        public IList<BaseOpcode> Opcodes { get; } = new List<BaseOpcode>();

    }
}
