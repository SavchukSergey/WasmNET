using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32EqzOpcode opcode, WasmNodeArg arg) {
            var expr = arg.Pop();
            arg.Push(new I32EqzNode(expr));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32EqOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32EqNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32NeOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32NeNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32LtsOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32LtsNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32LtuOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32LtuNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32GtsOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32GtsNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32GtuOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32GtuNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32LesOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32LesNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32GeuOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I32GeuNode(left, right));
            return null;
        }


        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64EqzOpcode opcode, WasmNodeArg arg) {
            var expr = arg.Pop();
            arg.Push(new I64EqzNode(expr));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64EqOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64EqNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64NeOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64NeNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64LtsOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64LtsNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64LtuOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64LtuNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64GtsOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64GtsNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64GtuOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64GtuNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64LesOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64LesNode(left, right));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64GeuOpcode opcode, WasmNodeArg arg) {
            var right = arg.Pop();
            var left = arg.Pop();
            arg.Push(new I64GeuNode(left, right));
            return null;
        }

    }
}
