﻿using System;
using System.Collections.Generic;
using System.Text;
using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(I32EqzOpcode opcode, WasmNodeArg arg) {
            var expr = arg.Stack.Pop();
            arg.Stack.Push(new Int32CmpZNode(expr));
            return null;
        }

    }
}
