﻿namespace WasmNet.Opcodes {
    public class I32Store8Opcode : MemoryStoreOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var val = state.PopUI32();
            var adr = state.PopUI32();
            state.Memory.WriteUInt8(adr, Immediate, (byte)val);
        }

        public override string ToString() => $"i32.store8 {Immediate}";

    }
}
