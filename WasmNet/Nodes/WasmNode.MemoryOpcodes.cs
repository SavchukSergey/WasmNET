using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {

        #region I32

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32LoadOpcode opcode, WasmNodeArg arg) {
            var address = arg.Pop();
            arg.Push(new I32LoadNode(opcode.Address, address));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32Load8SOpcode opcode, WasmNodeArg arg) {
            var address = arg.Pop();
            arg.Push(new I32Load8SNode(opcode.Address, address));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32Load8UOpcode opcode, WasmNodeArg arg) {
            var address = arg.Pop();
            arg.Push(new I32Load8UNode(opcode.Address, address));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32Load16SOpcode opcode, WasmNodeArg arg) {
            var address = arg.Pop();
            arg.Push(new I32Load16SNode(opcode.Address, address));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32Load16UOpcode opcode, WasmNodeArg arg) {
            var address = arg.Pop();
            arg.Push(new I32Load16UNode(opcode.Address, address));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32StoreOpcode opcode, WasmNodeArg arg) {
            var value = arg.Pop();
            var address = arg.Pop();
            arg.Push(new I32StoreNode(opcode.Address, address, value));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32Store8Opcode opcode, WasmNodeArg arg) {
            var value = arg.Pop();
            var address = arg.Pop();
            arg.Push(new I32Store8Node(opcode.Address, address, value));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32Store16Opcode opcode, WasmNodeArg arg) {
            var value = arg.Pop();
            var address = arg.Pop();
            arg.Push(new I32Store16Node(opcode.Address, address, value));
            return null;
        }

        #endregion

        #region I64

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64LoadOpcode opcode, WasmNodeArg arg) {
            var address = arg.Pop();
            arg.Push(new I64LoadNode(opcode.Address, address));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64Load8SOpcode opcode, WasmNodeArg arg) {
            var address = arg.Pop();
            arg.Push(new I64Load8SNode(opcode.Address, address));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64Load8UOpcode opcode, WasmNodeArg arg) {
            var address = arg.Pop();
            arg.Push(new I64Load8UNode(opcode.Address, address));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64Load16SOpcode opcode, WasmNodeArg arg) {
            var address = arg.Pop();
            arg.Push(new I64Load16SNode(opcode.Address, address));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64Load16UOpcode opcode, WasmNodeArg arg) {
            var address = arg.Pop();
            arg.Push(new I64Load16UNode(opcode.Address, address));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64Load32SOpcode opcode, WasmNodeArg arg) {
            var address = arg.Pop();
            arg.Push(new I64Load32SNode(opcode.Address, address));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64Load32UOpcode opcode, WasmNodeArg arg) {
            var address = arg.Pop();
            arg.Push(new I64Load32UNode(opcode.Address, address));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64StoreOpcode opcode, WasmNodeArg arg) {
            var value = arg.Pop();
            var address = arg.Pop();
            arg.Push(new I64StoreNode(opcode.Address, address, value));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64Store8Opcode opcode, WasmNodeArg arg) {
            var value = arg.Pop();
            var address = arg.Pop();
            arg.Push(new I64Store8Node(opcode.Address, address, value));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64Store16Opcode opcode, WasmNodeArg arg) {
            var value = arg.Pop();
            var address = arg.Pop();
            arg.Push(new I64Store16Node(opcode.Address, address, value));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64Store32Opcode opcode, WasmNodeArg arg) {
            var value = arg.Pop();
            var address = arg.Pop();
            arg.Push(new I64Store32Node(opcode.Address, address, value));
            return null;
        }

        #endregion

        #region F32

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F32LoadOpcode opcode, WasmNodeArg arg) {
            var address = arg.Pop();
            arg.Push(new F32LoadNode(opcode.Address, address));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F32StoreOpcode opcode, WasmNodeArg arg) {
            var value = arg.Pop();
            var address = arg.Pop();
            arg.Push(new F32StoreNode(opcode.Address, address, value));
            return null;
        }

        #endregion

        #region F64

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F64LoadOpcode opcode, WasmNodeArg arg) {
            var address = arg.Pop();
            arg.Push(new F64LoadNode(opcode.Address, address));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F64StoreOpcode opcode, WasmNodeArg arg) {
            var value = arg.Pop();
            var address = arg.Pop();
            arg.Push(new F64StoreNode(opcode.Address, address, value));
            return null;
        }

        #endregion

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(CurrentMemoryOpcode opcode, WasmNodeArg arg) {
            arg.Push(new CurrentMemoryNode());
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(GrowMemoryOpcode opcode, WasmNodeArg arg) {
            var value = arg.Pop();
            arg.Push(new GrowMemoryNode(value));
            return null;
        }

    }
}
