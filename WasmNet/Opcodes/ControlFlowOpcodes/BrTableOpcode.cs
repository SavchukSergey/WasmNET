using System.Collections.Generic;

namespace WasmNet.Opcodes {
    public class BrTableOpcode : BaseOpcode {

        public IList<uint> Targets { get; } = new List<uint>();

        public uint DefaultTarget { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) => throw new System.NotImplementedException();

        public override string ToString() => $"br_table TODO";

    }
}
