using System;
using System.Collections.Generic;
using WasmNet.Opcodes;

namespace WasmNet.Data {
    public class WasmFunctionBody {

        public WasmFunctionBody(IReadOnlyList<WasmLocalEntry> locals, IReadOnlyList<BaseOpcode> opcodes) {
            if (locals == null) {
                throw new ArgumentNullException(nameof(locals));
            }
            if (opcodes == null) {
                throw new ArgumentNullException(nameof(opcodes));
            }
            Locals = locals;
            Opcodes = opcodes;
        }

        public IReadOnlyList<WasmLocalEntry> Locals { get; }

        public IReadOnlyList<BaseOpcode> Opcodes { get; }

    }
}
