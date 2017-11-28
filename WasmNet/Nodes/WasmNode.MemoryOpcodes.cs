using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {

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

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64LoadOpcode opcode, WasmNodeArg arg) {
            var address = arg.Pop();
            arg.Push(new I64LoadNode(opcode.Address, address));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32StoreOpcode opcode, WasmNodeArg arg) {
            var value = arg.Pop();
            var address = arg.Pop();
            arg.Push(new I32StoreNode(opcode.Address, address, value));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64StoreOpcode opcode, WasmNodeArg arg) {
            var value = arg.Pop();
            var address = arg.Pop();
            arg.Push(new I64StoreNode(opcode.Address, address, value));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32Store8Opcode opcode, WasmNodeArg arg) {
            var value = arg.Pop();
            var address = arg.Pop();
            arg.Push(new I32Store8Node(opcode.Address, address, value));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64Store8Opcode opcode, WasmNodeArg arg) {
            var value = arg.Pop();
            var address = arg.Pop();
            arg.Push(new I64Store8Node(opcode.Address, address, value));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64Store32Opcode opcode, WasmNodeArg arg) {
            var value = arg.Pop();
            var address = arg.Pop();
            arg.Push(new I64Store32Node(opcode.Address, address, value));
            return null;
        }

    }
}
