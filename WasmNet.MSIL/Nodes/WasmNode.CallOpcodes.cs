﻿using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(CallOpcode opcode, WasmNodeArg arg) {
            var target = arg.Context.ResolveFunction(opcode.FunctionIndex);
            var node = new CallNode(target);
            for (var i = target.Signature.Parameters.Count - 1; i >= 0; i--) {
                var param = arg.Pop();
                node.Arguments.Insert(0, param);
            }
            arg.Push(node);
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(CallIndirectOpcode opcode, WasmNodeArg arg) {
            var target = arg.Context.ResolveType(opcode.TypeIndex);
            var element = arg.Pop();
            var node = new CallIndirectNode(target, element);
            for (var i = target.Parameters.Count - 1; i >= 0; i--) {
                var param = arg.Pop();
                node.Arguments.Insert(0, param);
            }
            arg.Push(node);
            return null;
        }

    }
}
