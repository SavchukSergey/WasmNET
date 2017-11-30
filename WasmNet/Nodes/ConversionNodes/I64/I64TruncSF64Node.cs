﻿using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64TruncSF64Node : ConversionNode {

        public I64TruncSF64Node(BaseNode operand) : base(operand) {
        }

        public override WasmType ResultType => WasmType.F64;

        protected override WasmType OperandType => WasmType.I64;

        protected override string NodeName => "i64.trunc_s/f64";

    }
}