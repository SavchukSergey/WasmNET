using System;
using System.Collections.Generic;

namespace WasmNet.Nodes {
    public class ModuleNode : BaseNode {

        public IList<FunctionNode> Functions { get; } = new List<FunctionNode>();

        public IList<GlobalNode> Globals { get; } = new List<GlobalNode>();


        public IList<FunctionNode> ImportedFunctions { get; } = new List<FunctionNode>();

        public IList<GlobalNode> ImportedGlobals { get; } = new List<GlobalNode>();


        public IList<ImportNode> Imports { get; } = new List<ImportNode>();


        public GlobalNode ResolveGlobal(uint globalIndex) {
            var index = globalIndex;
            if (index < ImportedGlobals.Count) return ImportedGlobals[(int)index];
            index -= (uint)ImportedGlobals.Count;
            if (index < Globals.Count) return Globals[(int)index];
            throw new WasmNodeException($"cannot resolve global with index {globalIndex}");
        }

        public FunctionNode ResolveFunction(uint functionIndex) {
            var index = functionIndex;
            if (index < ImportedFunctions.Count) return ImportedFunctions[(int)index];
            index -= (uint)ImportedFunctions.Count;
            if (index < Functions.Count) return Functions[(int)index];
            throw new WasmNodeException($"cannot resolve function with index {functionIndex}");
        }


        public override void ToString(NodeWriter writer) => throw new NotImplementedException();

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine("(module ");
            writer.Indent();

            foreach(var import in Imports) {
                import.ToSExpressionString(writer);
            }

            foreach (var global in Globals) {
                global.ToSExpressionString(writer);
            }

            foreach (var func in Functions) {
                func.ToSExpressionString(writer);
            }
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
