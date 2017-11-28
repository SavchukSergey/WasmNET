﻿namespace WasmNet.Nodes {
    public class I64OrNode : BinaryNumericNode {

        public I64OrNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.or";

    }
}