using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {
        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(UnreachableOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();
        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(NopOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(BlockOpcode opcode, WasmNodeArg arg) {
            var blockNode = new BlockNode();
            arg.Push(blockNode);
            arg.PushBlock(blockNode);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(LoopOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(IfOpcode opcode, WasmNodeArg arg) {
            var condition = arg.Pop();
            var ifNode = new IfNode(condition, new BlockNode(), null);
            arg.Push(ifNode);
            arg.PushBlock(ifNode.Then);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(ElseOpcode opcode, WasmNodeArg arg) {
            arg.PopBlock();
            var ifNode = arg.Pop() as IfNode;
            if (ifNode == null) throw new WasmNodeException("if node expected");
            var blockNode = new BlockNode();
            ifNode.Else = blockNode;
            arg.Push(ifNode);
            arg.PushBlock(blockNode);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(EndOpcode opcode, WasmNodeArg arg) {
            if (arg.HasBlock) {
                arg.PopBlock();
            }
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(BrOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();
        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(BrIfOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();
        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(BrTableOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();
        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(ReturnOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();

    }
}
