using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {

        #region I32

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32WrapI64Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new I32WrapI64Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32TruncSF32Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new I32TruncSF32Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32TruncUF32Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new I32TruncUF32Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32TruncSF64Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new I32TruncSF64Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32TruncUF64Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new I32TruncUF64Node(operand));
            return null;
        }

        #endregion

        #region I64

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

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64TruncSF32Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new I64TruncSF32Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64TruncUF32Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new I64TruncUF32Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64TruncSF64Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new I64TruncSF64Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64TruncUF64Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new I64TruncUF64Node(operand));
            return null;
        }

        #endregion

        #region F32

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F32ConvertSI32Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new F32ConvertSI32Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F32ConvertUI32Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new F32ConvertUI32Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F32ConvertSI64Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new F32ConvertSI64Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F32ConvertUI64Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new F32ConvertUI64Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F32DemoteF64Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new F32DemoteF64Node(operand));
            return null;
        }

        #endregion

        #region F64

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F64ConvertSI32Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new F64ConvertSI32Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F64ConvertUI32Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new F64ConvertUI32Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F64ConvertSI64Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new F64ConvertSI64Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F64ConvertUI64Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new F64ConvertUI64Node(operand));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F64PromoteF32Opcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            arg.Push(new F64PromoteF32Node(operand));
            return null;
        }

        #endregion
    }
}
