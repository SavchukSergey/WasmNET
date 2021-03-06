﻿using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32ConstOpcode opcode, WasmNodeArg arg) {
            arg.Push(new I32ConstNode(opcode.Value));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I64ConstOpcode opcode, WasmNodeArg arg) {
            arg.Push(new I64ConstNode(opcode.Value));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F32ConstOpcode opcode, WasmNodeArg arg) {
            arg.Push(new F32ConstNode(opcode.Value));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(F64ConstOpcode opcode, WasmNodeArg arg) {
            arg.Push(new F64ConstNode(opcode.Value));
            return null;
        }

    }
}
