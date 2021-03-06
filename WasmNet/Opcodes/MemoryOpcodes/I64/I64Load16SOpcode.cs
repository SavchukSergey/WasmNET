﻿using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class I64Load16SOpcode : MemoryAccessOpcode {

        public I64Load16SOpcode(WasmMemoryImmediate immediate) : base(immediate) {
        }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"i64.load16_s {Immediate}";

    }
}
