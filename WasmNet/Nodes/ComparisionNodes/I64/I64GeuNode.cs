﻿namespace WasmNet.Nodes {
    public class I64GeuNode : BinaryComparisionNode {

        public I64GeuNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.ge_u";

    }
}