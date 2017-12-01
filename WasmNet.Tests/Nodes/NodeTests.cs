using System;
using System.Collections.Generic;
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
                if (opcode == typeof(EndOpcode)) continue;

                var nodeName = opcode.FullName.Replace("Opcode", "Node");
                var nodeType = assembly.GetType(nodeName);
                Assert.IsNotNull(nodeType, $"missing node type of {opcode} opcode");
                Assert.IsFalse(nodeType.IsAbstract, $"node type must be non-abstract for {opcode} opcode");
            }
        }

        [Test]
        public void F32BaseTypeTest() {
            foreach (var type in GetNodeTypes()) {
                if (type.Name.StartsWith("F32")) {
                    var baseType = type.BaseType;
                    var baseName = baseType.Name;
                    if (
                        baseName.StartsWith("I32") ||
                        baseName.StartsWith("I64") ||
                        baseName.StartsWith("F64")
                    ) Assert.Fail($"unexpected inheritance {type.Name}:{baseName}");
                }
            }
        }

        [Test]
        public void F64BaseTypeTest() {
            foreach (var type in GetNodeTypes()) {
                if (type.Name.StartsWith("F64")) {
                    var baseType = type.BaseType;
                    var baseName = baseType.Name;
                    if (
                        baseName.StartsWith("I32") ||
                        baseName.StartsWith("I64") ||
                        baseName.StartsWith("F32")
                    ) Assert.Fail($"unexpected inheritance {type.Name}:{baseName}");
                }
            }
        }

        [Test]
        public void I32BaseTypeTest() {
            foreach (var type in GetNodeTypes()) {
                if (type.Name.StartsWith("I32")) {
                    var baseType = type.BaseType;
                    var baseName = baseType.Name;
                    if (
                        baseName.StartsWith("I64") ||
                        baseName.StartsWith("F32") ||
                        baseName.StartsWith("F64")
                    ) Assert.Fail($"unexpected inheritance {type.Name}:{baseName}");
                }
            }
        }

        [Test]
        public void I64BaseTypeTest() {
            foreach (var type in GetNodeTypes()) {
                if (type.Name.StartsWith("I64")) {
                    var baseType = type.BaseType;
                    var baseName = baseType.Name;
                    if (
                        baseName.StartsWith("I32") ||
                        baseName.StartsWith("F32") ||
                        baseName.StartsWith("F32")
                    ) Assert.Fail($"unexpected inheritance {type.Name}:{baseName}");
                }
            }
        }

        private static IEnumerable<Type> GetNodeTypes() {
            var baseNodeType = typeof(ExecutableNode);
            var assembly = baseNodeType.Assembly;
            return assembly.GetTypes()
                .Where(t => baseNodeType.IsAssignableFrom(t))
                .ToList();
        }

    }
}
