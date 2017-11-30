using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32ReinterpretF32Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new I32ReinterpretF32Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64ReinterpretF64Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new I64ReinterpretF64Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F32ReinterpretI32Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new F32ReinterpretI32Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F64ReinterpretI64Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new F64ReinterpretI64Node(operand));
            return null;
        }

    }
}
