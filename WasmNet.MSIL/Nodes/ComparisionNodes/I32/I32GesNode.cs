﻿namespace WasmNet.Nodes {
    public class I32GesNode : I32BinaryComparisionNode {

        public I32GesNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.ge_s";

    }
}
