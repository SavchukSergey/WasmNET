﻿namespace WasmNet.Opcodes {
    public class GetLocalOpcode : BaseOpcode {

        public uint LocalIndex { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"get_local {LocalIndex}";

    }
}
