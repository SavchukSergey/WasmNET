﻿using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class F64LoadOpcode : MemoryAccessOpcode {

        public F64LoadOpcode(WasmMemoryImmediate immediate) : base(immediate) {
        }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"f64.load {Immediate}";

    }
}
