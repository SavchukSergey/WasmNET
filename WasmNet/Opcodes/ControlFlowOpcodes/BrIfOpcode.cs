﻿namespace WasmNet.Opcodes {
    public class BrIfOpcode : BaseOpcode {

        public uint RelativeDepth { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"br_if {RelativeDepth}";

    }
}
