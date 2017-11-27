using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(DropOpcode opcode, WasmNodeArg arg) {
            var op = arg.Pop();
            arg.Push(new DropNode(op));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(SelectOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();
    }
}
