using System.Linq;
using NUnit.Framework;
using WasmNet.Opcodes;

namespace WasmNet.Tests.Opcodes.NumericOpcodes.I32 {
    [TestFixture]
    public class I32AddOpcodeTests {

        [Test]
        public void ExecuteTest() {
            var state = new WasmFunctionState();
            state.PushUI32(10);
            state.PushUI32(25);
            var opcode = new I32AddOpcode();
            opcode.Execute(state);
            var result = state.PopUI32();
            Assert.AreEqual(35, result);
            Assert.IsTrue(state.StackEmpty);
        }

    }
}
