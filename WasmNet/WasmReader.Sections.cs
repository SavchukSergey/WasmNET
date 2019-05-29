using System.Collections.Generic;
using WasmNet.Data;
using WasmNet.Opcodes;
using WasmNet.Sections;

namespace WasmNet {
    public partial class WasmReader {

        public WasmFunctionBody ReadFunctionBody() {
            var bodySize = ReadVarUInt32();
            var bodyBytes = ReadBytes(bodySize);
            var bodyReader = new WasmReader(bodyBytes);
            var localsCount = bodyReader.ReadVarUInt32();
            var locals = new List<WasmLocalEntry>((int)localsCount);
            for (var i = 0; i < localsCount; i++) {
                locals.Add(bodyReader.ReadLocalEntry());
            }
            var opcodes = new List<BaseOpcode>();
            while (!bodyReader.Eof) {
                opcodes.Add(bodyReader.ReadOpcode());
            }
            var res = new WasmFunctionBody(locals, opcodes);
            return res;
        }

        public WasmTypeSection ReadTypeSection() {
            var count = ReadVarUInt32();
            var signatures = new List<WasmFunctionSignature>((int)count);
            for (var i = 0; i < count; i++) {
                var sig = ReadFunctionSignature();
                signatures.Add(sig);
            }
            return new WasmTypeSection(signatures);
        }

        public WasmFunctionSignature ReadFunctionSignature() {
            var type = ReadType();
            if (type != WasmType.Func) {
                throw new WasmFormatException("func type expected");
            }
            var paramCount = ReadVarUInt32();
            var parameters = new List<WasmType>((int)paramCount);
            for (var i = 0; i < paramCount; i++) {
                parameters.Add(ReadValueType());
            }
            var returnCount = ReadVarUInt1();
            var returns = new List<WasmType>((int)returnCount);
            for (var i = 0; i < returnCount; i++) {
                returns.Add(ReadValueType());
            }
            return new WasmFunctionSignature(parameters, returns);
        }

    }
}
