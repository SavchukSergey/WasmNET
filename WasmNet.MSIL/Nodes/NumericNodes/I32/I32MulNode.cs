﻿namespace WasmNet.Nodes {
    public class I32MulNode : I32BinaryNumericNode {

        public I32MulNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.mul";

    }
}