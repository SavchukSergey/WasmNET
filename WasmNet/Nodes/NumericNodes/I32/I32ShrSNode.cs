﻿namespace WasmNet.Nodes {
    public class I32ShrSNode : I32BinaryNumericNode {

        public I32ShrSNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.shr_s";

    }
}