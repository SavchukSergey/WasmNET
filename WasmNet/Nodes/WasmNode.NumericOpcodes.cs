using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {

        #region I32

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32AddOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32AddNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32SubOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32SubNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32MulOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32MulNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32DivSOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32DivSNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32DivUOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32DivUNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32RemUOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32RemUNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32AndOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32AndNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32OrOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32OrNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32XorOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32XorNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32ShlOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32ShlNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32ShrSOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32ShrSNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32ShrUOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32ShrUNode(left, right));
            return null;
        }

        #endregion

        #region I64

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64AddOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64AddNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64SubOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64SubNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64MulOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64MulNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64DivSOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64DivSNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64DivUOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64DivUNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64RemUOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64RemUNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64AndOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64AndNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64OrOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64OrNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64XorOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64XorNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64ShlOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64ShlNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64ShrSOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64ShrSNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64ShrUOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64ShrUNode(left, right));
            return null;
        }

        #endregion

    }
}
