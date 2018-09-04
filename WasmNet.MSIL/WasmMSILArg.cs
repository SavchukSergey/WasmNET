using System.Reflection.Emit;

namespace WasmNet.MSIL {
    public class WasmMSILArg {

        public WasmMSILArg(ILGenerator ilGenerator) {
            IL = ilGenerator;
        }

        public ILGenerator IL { get; }

    }
}
