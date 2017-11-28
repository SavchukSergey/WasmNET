﻿namespace WasmNet.Nodes {
    public class I32GtuNode : BinaryComparisionNode {

        public I32GtuNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.gt_u";

    }
}