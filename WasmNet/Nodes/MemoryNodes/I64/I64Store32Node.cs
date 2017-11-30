﻿using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64Store32Node : MemoryStoreNode {

        public I64Store32Node(WasmMemoryImmediate immediate, BaseNode address, BaseNode value) : base(immediate, address, value) {
        }

        protected override WasmType ValueType => WasmType.I64;

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        protected override string NodeName => "i64.store32";

    }
}