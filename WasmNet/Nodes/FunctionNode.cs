﻿using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class FunctionNode : BaseNode {

        public string Name { get; set; }

        public WasmFunctionSignature Signature { get; }

        public BlockNode Execution { get; set; }

        public IList<LocalNode> Parameters { get; } = new List<LocalNode>();

        public IList<LocalNode> Variables { get; } = new List<LocalNode>();

        public FunctionNode(WasmFunctionSignature signature) {
            Signature = signature;
            for (var i = 0; i < Signature.Parameters.Count; i++) {
                var param = Signature.Parameters[i];
                Parameters.Add(new LocalNode {
                    Name = $"arg{i}",
                    Type = param
                });
            }
        }

        public void AddLocals(WasmType type, uint count) {
            for (var i = 0; i < count; i++) {
                AddLocal(type);
            }
        }

        public void AddLocal(WasmType type) {
            var ind = Variables.Count;
            Variables.Add(new LocalNode {
                Name = $"local{ind}",
                Type = type
            });
        }

        public override void ToString(NodeWriter writer) {
            writer.StartLine();
            writer.Write($"{Convert(Signature.Return)} {Name}(");
            for (var i = 0; i < Parameters.Count; i++) {
                var param = Parameters[i];
                if (i != 0) writer.Write(", ");
                writer.Write(Convert(param.Type));
                writer.Write($" {param.Name}");
            }
            writer.Write(") {");
            writer.EndLine();
            writer.Indent();
            Execution.ToString(writer);
            writer.Unindent();
            writer.StartLine();
            writer.Write("}");
            writer.EndLine();
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.StartLine();
            writer.Write($"(func ${Name}");
            for (var i = 0; i < Parameters.Count; i++) {
                var param = Parameters[i];
                writer.Write($" (param ");
                if (Execution != null) {
                    writer.Write($"${param.Name} ");
                }
                writer.Write($"{ConvertValueType(param.Type)})");
            }
            if (Signature.Return != null) {
                writer.Write($" (result {ConvertValueType(Signature.Return.Value)})");
            }
            if (Execution != null) {
                writer.EndLine();
                writer.Indent();
                foreach (var local in Variables) {
                    local.ToSExpressionString(writer);
                }
                Execution.ToSExpressionString(writer);
                writer.Unindent();
                writer.StartLine();
            }
            writer.Write(")");
            writer.EndLine();
        }

        private static string Convert(WasmType? type) {
            switch (type) {
                case null: return "void";
                case WasmType.BlockType: return "void";
                case WasmType.I32: return "int";
                case WasmType.I64: return "long";
                case WasmType.F32: return "float";
                case WasmType.F64: return "double";
                default:
                    throw new WasmNodeException($"unknown type {type}");
            }
        }

    }
}
