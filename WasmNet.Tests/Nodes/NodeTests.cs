using System.Linq;
using NUnit.Framework;
using WasmNet.Nodes;
using WasmNet.Opcodes;

namespace WasmNet.Tests.Nodes {
    [TestFixture]
    public class NodeTests {

        [Test]
        public void AllNodesDefinedTest() {
            var baseOpcodeType = typeof(BaseOpcode);
            var baseNodeType = typeof(BaseNode);
            var assembly = baseOpcodeType.Assembly;
            var opcodes = assembly.GetTypes()
                .Where(t => !t.IsAbstract)
                .Where(t => baseOpcodeType.IsAssignableFrom(t))
                .ToList();
            foreach (var opcode in opcodes) {
                var nodeName = opcode.FullName.Replace("Opcode", "Node");
                var nodeType = assembly.GetType(nodeName);
                Assert.IsNotNull(nodeType, $"missing node type of {opcode} opcode");
                Assert.IsFalse(nodeType.IsAbstract, $"node type must be non-abstract for {opcode} opcode");
            }
        }

    }
}
