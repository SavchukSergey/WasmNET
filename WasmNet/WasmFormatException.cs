using System;
using System.Runtime.Serialization;

namespace WasmNet {
    [Serializable]
    internal class WasmFormatException : Exception {
        public WasmFormatException() {
        }

        public WasmFormatException(string message) : base(message) {
        }

        public WasmFormatException(string message, Exception innerException) : base(message, innerException) {
        }

        protected WasmFormatException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}