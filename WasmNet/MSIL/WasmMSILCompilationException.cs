using System;
using System.Runtime.Serialization;

namespace WasmNet.MSIL {
    [Serializable]
    internal class WasmMSILCompilationException : Exception {
        public WasmMSILCompilationException() {
        }

        public WasmMSILCompilationException(string message) : base(message) {
        }

        public WasmMSILCompilationException(string message, Exception innerException) : base(message, innerException) {
        }

        protected WasmMSILCompilationException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}