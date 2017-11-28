﻿namespace WasmNet.Nodes {
    public class I32LtuNode : BinaryNumericNode {

        public I32LtuNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.lt_u";

    }
}
