using WasmNet.Data;
using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(UnreachableOpcode opcode, WasmNodeArg arg) {
            arg.Push(new UnreachableNode());
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(NopOpcode opcode, WasmNodeArg arg) {
            arg.Push(new NopNode());
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(BlockOpcode opcode, WasmNodeArg arg) {
            var blockNode = new BlockNode(opcode.Signature);
            arg.Push(blockNode);
            arg.PushBlock(blockNode.Nodes);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(LoopOpcode opcode, WasmNodeArg arg) {
            var loopNode = new LoopNode(opcode.Signature);
            arg.Push(loopNode);
            arg.PushBlock(loopNode.Nodes);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(IfOpcode opcode, WasmNodeArg arg) {
            var condition = arg.Pop();
            var ifNode = new IfNode(condition, opcode.Signature);
            var thenBlock = new NodesList(opcode.Signature);
            ifNode.Then = thenBlock;
            arg.Push(ifNode);
            arg.PushBlock(thenBlock);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(ElseOpcode opcode, WasmNodeArg arg) {
            arg.PopBlock();
            var parentNode = arg.Pop();
            var ifNode = parentNode as IfNode;
            if (ifNode == null) throw new WasmNodeException("if node expected");

            var elseBlock = new NodesList(ifNode.Signature);
            ifNode.Else = elseBlock;
            arg.Push(ifNode);
            arg.PushBlock(elseBlock);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(EndOpcode opcode, WasmNodeArg arg) {
            if (arg.HasBlock) {
                arg.PopBlock();
            } else {
                throw new WasmNodeException("there is no block to end");
            }
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(BrOpcode opcode, WasmNodeArg arg) {
            var label = arg.ResolveLabel(opcode.RelativeDepth);
            var node = new BrNode(label);
            arg.Push(node);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(BrIfOpcode opcode, WasmNodeArg arg) {
            var label = arg.ResolveLabel(opcode.RelativeDepth);
            var condition = arg.Pop();
            var node = new BrIfNode(condition, label);
            arg.Push(node);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(BrTableOpcode opcode, WasmNodeArg arg) {
            var operand = arg.Pop();
            var node = new BrTableNode(operand);
            foreach(var target in opcode.Targets) {
                var label = arg.ResolveLabel(target);
                node.Targets.Add(label);
            }
            node.DefaultTarget = arg.ResolveLabel(opcode.DefaultTarget);
            arg.Push(node);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(ReturnOpcode opcode, WasmNodeArg arg) {
            var farg = (WasmFunctionNodeArg)arg; //todo:
            var returnType = farg.Function.Signature.Return;
            switch (returnType) {
                case WasmType.I32:
                case WasmType.I64:
                case WasmType.F32:
                case WasmType.F64:
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
