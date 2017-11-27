using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32AddOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new AddNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32AndOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new AndNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32ShlOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new ShlNode(left, right));
            return null;
        }

    }
}
