﻿namespace WasmNet.Nodes {
    public class I64GtuNode : I64BinaryComparisionNode {

        public I64GtuNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.gt_u";

    }
}
