﻿namespace WasmNet.Opcodes {
    public class F32LoadOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"f32.load {Address}";

    }
}
