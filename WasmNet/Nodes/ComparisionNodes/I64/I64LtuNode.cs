﻿namespace WasmNet.Nodes {
    public class I64LtuNode : I64BinaryComparisionNode {

        public I64LtuNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.lt_u";

    }
}
