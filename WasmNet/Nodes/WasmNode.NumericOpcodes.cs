using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32AddOpcode opcode, WasmNodeArg arg) {
            var right = arg.Stack.Pop();
            var left = arg.Stack.Pop();
            arg.Stack.Push(new AddNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32AndOpcode opcode, WasmNodeArg arg) {
            var right = arg.Stack.Pop();
            var left = arg.Stack.Pop();
            arg.Stack.Push(new AndNode(left, right));
            return null;
        }

    }
}
