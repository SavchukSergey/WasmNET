using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {
        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(UnreachableOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();
        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(NopOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(BlockOpcode opcode, WasmNodeArg arg) {
            var blockNode = new BlockNode(opcode.Signature);
            arg.Push(blockNode);
            arg.PushBlock(blockNode);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(LoopOpcode opcode, WasmNodeArg arg) {
            var loopNode = new LoopNode(opcode.Signature);
            arg.Push(loopNode);
            arg.PushBlock(loopNode.Block);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(IfOpcode opcode, WasmNodeArg arg) {
            var condition = arg.Pop();
            var ifNode = new IfNode(condition, opcode.Signature);
            var thenBlock = new BlockNode(opcode.Signature);
            ifNode.Then = thenBlock;
            arg.Push(ifNode);
            arg.PushBlock(ifNode.Then);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(ElseOpcode opcode, WasmNodeArg arg) {
            arg.PopBlock();
            var parentNode = arg.Pop();
            var ifNode = parentNode as IfNode;
            if (ifNode == null) throw new WasmNodeException("if node expected");

            var elseNode = new BlockNode(ifNode.Signature);
            ifNode.Else = elseNode;
            arg.Push(ifNode);
            arg.PushBlock(elseNode);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(EndOpcode opcode, WasmNodeArg arg) {
            if (arg.HasBlock) {
                arg.PopBlock();
            }
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(BrOpcode opcode, WasmNodeArg arg) {
            //todo: set relative depth
            var node = new BrNode();
            arg.Push(node);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(BrIfOpcode opcode, WasmNodeArg arg) {
            //todo: set relative depth
            var condition = arg.Pop();
            var node = new BrIfNode(condition);
            arg.Push(node);
            arg.PushBlock(node.Block);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(BrTableOpcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            var node = new BrTableNode(operand);
            foreach(var target in opcode.Targets) {
                node.Targets.Add(target);
            }
            node.DefaultTarget = opcode.DefaultTarget;
            arg.Push(node);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(ReturnOpcode opcode, WasmNodeArg arg) {
            var farg = (WasmFunctionNodeArg)arg; //todo:
            var returnType = farg.Function.Signature.Return;
            switch (returnType) {
                case Data.WasmType.I32:
                case Data.WasmType.I64:
                case Data.WasmType.F32:
                case Data.WasmType.F64:
                    var res = arg.Pop();
                    arg.Push(new ReturnNode(res));
                    break;
                default:
                    arg.Push(new ReturnNode());
                    break;
            }
            return null;
        }

    }
}
