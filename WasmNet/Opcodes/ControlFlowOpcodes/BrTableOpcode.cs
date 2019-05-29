using System.Collections.Generic;

namespace WasmNet.Opcodes {
    public class BrTableOpcode : BaseOpcode {

        public BrTableOpcode(uint defaultTarget, params uint[] targets) {
            DefaultTarget = defaultTarget;
            Targets = targets;
        }

        public BrTableOpcode(uint defaultTarget, List<uint> targets) {
            DefaultTarget = defaultTarget;
            Targets = targets.AsReadOnly();
        }

        public IReadOnlyCollection<uint> Targets { get; }

        public uint DefaultTarget { get; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"br_table {string.Join(' ', Targets)} {DefaultTarget}";

    }
}
