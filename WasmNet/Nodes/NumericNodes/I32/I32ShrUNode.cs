﻿namespace WasmNet.Nodes {
    public class I32ShrUNode : I32BinaryNumericNode {

        public I32ShrUNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.shr_u";

    }
}