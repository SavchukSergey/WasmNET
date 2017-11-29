using System.Linq;
using NUnit.Framework;
using WasmNet.Opcodes;

namespace WasmNet.Tests.Opcodes {
    [TestFixture]
    public class OpcodeVisitorTests {

        [Test]
        public void AllOpcodesDefinedTest() {
            var baseOpcodeType = typeof(BaseOpcode);
            var assembly = baseOpcodeType.Assembly;
            var opcodes = assembly.GetTypes()
                .Where(t => !t.IsAbstract)
                .Where(t => baseOpcodeType.IsAssignableFrom(t))
                .ToList();
            var visitorType = typeof(IWasmOpcodeVisitor<VisitorArg, VisitorResult>);
            var methods = visitorType.GetMethods();
            foreach (var opcode in opcodes) {
                var method = methods
                    .Where(m => m.Name == "Visit")
                    .Where(m => {
                        var args = m.GetParameters();
                        if (args.Length != 2) return false;
                        if (args[0].ParameterType != opcode) return false;
                        if (args[1].ParameterType != typeof(VisitorArg)) return false;
                        return true;
                    })
                    .FirstOrDefault();
                Assert.IsNotNull(method, $"missing Visit method for {opcode} opcode");
                Assert.AreEqual(typeof(VisitorResult), method.ReturnType, $"Visit method must return VisitorResult for {opcode} opcode");
            }
        }

        private class VisitorArg {

        }

        private class VisitorResult {

        }
    }
}
