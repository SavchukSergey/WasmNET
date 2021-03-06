﻿using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32EqzNode : UnaryComparisionNode {

        public I32EqzNode(ExecutableNode expr) : base(expr) {
        }

        protected override WasmType OperandType => WasmType.I32;

        protected override string NodeName => "i32.eqz";

    }
}
