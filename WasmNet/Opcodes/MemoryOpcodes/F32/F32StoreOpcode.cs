﻿using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class F32StoreOpcode : MemoryStoreOpcode {

        public F32StoreOpcode(WasmMemoryImmediate immediate) : base(immediate) {
        }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var val = state.PopF32();
            var adr = state.PopUI32();
            state.Memory.WriteFloat32(adr, Immediate, val);
        }

        public override string ToString() => $"f32.store {Immediate}";

    }
}
