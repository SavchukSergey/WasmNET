using System.Collections.Generic;
using WasmNet.Opcodes;

namespace WasmNet.Data {
    public class WasmInitExpression {

        public IList<BaseOpcode> Opcodes { get; } = new List<BaseOpcode>();

    }
}
