﻿using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class I32Load8SOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"i32.load8_s {Address}";

    }
}
