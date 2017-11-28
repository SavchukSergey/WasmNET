using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32WrapI64Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new I32WrapI64Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64ExtendSI32Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new I64ExtendSI32Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64ExtendUI32Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new I64ExtendUI32Node(operand));
            return null;
        }

    }
}
