﻿namespace WasmNet.Nodes {
    public class I64GtsNode : I64BinaryComparisionNode {

        public I64GtsNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.gt_s";

    }
}
