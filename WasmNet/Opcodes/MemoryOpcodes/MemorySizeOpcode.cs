﻿namespace WasmNet.Opcodes {
    public class MemorySizeOpcode : BaseOpcode {

        public MemorySizeOpcode(byte reserved) {
            Reserved = reserved;
        }

        public byte Reserved { get; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => "memory.size";

    }
}
