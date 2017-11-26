using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(GetLocalOpcode opcode, WasmNodeArg arg) {
            arg.Stack.Push(new GetLocalNode(arg.ResolveLocal(opcode.LocalIndex)));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(SetLocalOpcode opcode, WasmNodeArg arg) {
            var expr = arg.Stack.Pop();
            var variable = arg.ResolveLocal(opcode.LocalIndex);
            arg.Execution.Add(new SetLocalNode(variable, expr));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(TeeLocalOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(GetGlobalOpcode opcode, WasmNodeArg arg) {
            arg.Stack.Push(new GetGlobalNode(arg.ResolveGlobal(opcode.GlobalIndex)));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(SetGlobalOpcode opcode, WasmNodeArg arg) {
            var expr = arg.Stack.Pop();
            var variable = arg.ResolveGlobal(opcode.GlobalIndex);
            arg.Execution.Add(new SetGlobalNode(variable, expr));
            return null;
        }

    }
}
