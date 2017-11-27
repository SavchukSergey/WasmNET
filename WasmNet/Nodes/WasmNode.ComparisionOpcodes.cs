using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32EqzOpcode opcode, WasmNodeArg arg) {
            var expr = arg.Pop();
            arg.Push(new I32EqzNode(expr));
            return null;
        }

    }
}
