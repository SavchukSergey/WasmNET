using System.Text;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class NodeWriter {

        private StringBuilder _sb = new StringBuilder();

        private int _indentation = 0;
        private bool _lineSpaced = false;
        private bool _lineDirty = false;

        public void OpenNode(string nodeName) {
            EnsureIndentation();
            EnsureSpace();
            _sb.Append('(');
            _sb.Append(nodeName);
            Indent();
            _lineDirty = true;
        }

        public void CloseNode() {
            Unindent();
            EnsureIndentation();
            _sb.Append(')');
            _lineDirty = true;
        }

        public void EnsureNewLine() {
            if (_lineDirty) {
                _sb.AppendLine();
                _lineSpaced = false;
                _lineDirty = false;
            }
        }

        public void EnsureIndentation() {
            if (!_lineSpaced) {
                _lineSpaced = true;
                for (var i = 0; i < _indentation * 2; i++) {
                    _sb.Append(' ');
                }
            }
        }

        public void EnsureSpace() {
            if (_sb.Length == 0) return;
            var lastCh = _sb[_sb.Length - 1];
            if (char.IsWhiteSpace(lastCh)) return;
            _sb.Append(' ');
        }

        public void WriteLabelName(Label label) {
            if (!string.IsNullOrWhiteSpace(label.Name)) {
                EnsureSpace();
                _sb.Append('$');
                _sb.Append(label.Name);
            }
        }

        public void WriteFunctionName(FunctionNode func) {
            if (!string.IsNullOrWhiteSpace(func.Name)) {
                EnsureSpace();
                _sb.Append('$');
                _sb.Append(func.Name);
            }
        }

        public void WriteVariableName(LocalNode local) {
            if (!string.IsNullOrWhiteSpace(local.Name)) {
                EnsureSpace();
                _sb.Append('$');
                _sb.Append(local.Name);
            }
        }


        public void WriteValueOrVoid(WasmType type) {
            switch (type) {
                case WasmType.I32:
                    EnsureSpace();
                    _sb.Append("i32");
                    break;
                case WasmType.I64:
                    EnsureSpace();
                    _sb.Append("i64");
                    break;
                case WasmType.F32:
                    EnsureSpace();
                    _sb.Append("f32");
                    break;
                case WasmType.F64:
                    EnsureSpace();
                    _sb.Append("f64");
                    break;
                case WasmType.BlockType:
                    break;
                default:
                    throw new WasmNodeException($"unknown value type {type}");
            }
        }

        public void WriteValue(WasmType type) {
            switch (type) {
                case WasmType.I32:
                    EnsureSpace();
                    _sb.Append("i32");
                    break;
                case WasmType.I64:
                    EnsureSpace();
                    _sb.Append("i64");
                    break;
                case WasmType.F32:
                    EnsureSpace();
                    _sb.Append("f32");
                    break;
                case WasmType.F64:
                    EnsureSpace();
                    _sb.Append("f64");
                    break;
                default:
                    throw new WasmNodeException($"unknown value type {type}");
            }
        }

        public void Write(string val) {
            _sb.Append(val);
            _lineDirty = true;
        }

        public void Write(int val) {
            _sb.Append(val);
            _lineDirty = true;
        }

        public void Write(long val) {
            _sb.Append(val);
            _lineDirty = true;
        }

        public void Write(float val) {
            _sb.Append(val);
            _lineDirty = true;
        }

        public void Write(double val) {
            _sb.Append(val);
            _lineDirty = true;
        }

        public void StartLine() {
            AddIndentation();
        }

        public void EndLine() {
            _sb.AppendLine();
        }

        public void WriteLine(string line) {
            StartLine();
            Write(line);
            EndLine();
        }

        public void Indent() {
            _indentation++;
        }

        public void Unindent() {
            _indentation--;
        }

        private void AddIndentation() {
            for (var i = 0; i < _indentation * 2; i++) {
                _sb.Append(' ');
            }
        }

        public override string ToString() => _sb.ToString();

    }
}
