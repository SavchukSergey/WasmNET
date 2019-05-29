using System;

namespace WasmNet {
    [Serializable]
    public class WasmFormatException : Exception {

        public WasmFormatException(string message) : base(message) {
        }

    }
}