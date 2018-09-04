using System;
using System.Runtime.Serialization;

namespace WasmNet.Nodes {
    [Serializable]
    internal class WasmNodeException : Exception {
        public WasmNodeException() {
        }

        public WasmNodeException(string message) : base(message) {
        }

        public WasmNodeException(string message, Exception innerException) : base(message, innerException) {
        }

        protected WasmNodeException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}