﻿namespace WasmNet.Nodes {
    public class I32GeuNode : I32BinaryComparisionNode {

        public I32GeuNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.ge_u";

    }
}
