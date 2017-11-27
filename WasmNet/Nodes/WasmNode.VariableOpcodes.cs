using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode {

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(GetLocalOpcode opcode, WasmNodeArg arg) {
            arg.Push(new GetLocalNode(arg.ResolveLocal(opcode.LocalIndex)));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(SetLocalOpcode opcode, WasmNodeArg arg) {
            var expr = arg.Pop();
            var variable = arg.ResolveLocal(opcode.LocalIndex);
            arg.Push(new SetLocalNode(variable, expr));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(TeeLocalOpcode opcode, WasmNodeArg arg) {
            var expr = arg.Pop();
            var variable = arg.ResolveLocal(opcode.LocalIndex);
            arg.Push(new TeeLocalNode(variable, expr));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(GetGlobalOpcode opcode, WasmNodeArg arg) {
            arg.Push(new GetGlobalNode(arg.ResolveGlobal(opcode.GlobalIndex)));
            return null;
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(SetGlobalOpcode opcode, WasmNodeArg arg) {
            var expr = arg.Pop();
            var variable = arg.ResolveGlobal(opcode.GlobalIndex);
            arg.Push(new SetGlobalNode(variable, expr));
            return null;
        }

    }
}
