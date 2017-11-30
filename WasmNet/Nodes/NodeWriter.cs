using System.Text;

namespace WasmNet.Nodes {
    public class NodeWriter {

        private StringBuilder _sb = new StringBuilder();

        private int _indentation = 0;
        private bool _lineSpaced = false;

        public void OpenNode(string nodeName) {
            EnsureIndentation();
            _sb.Append('(');
            _sb.Append(nodeName);
            Indent();
        }

        public void CloseNode() {
            Unindent();
            EnsureIndentation();
            _sb.Append(')');
        }

        public void NewLine() {
            _sb.AppendLine();
            _lineSpaced = false;
        }

        public void EnsureIndentation() {
            if (!_lineSpaced) {
                _lineSpaced = true;
                for (var i = 0; i < _indentation * 4; i++) {
                    _sb.Append(' ');
                }
            }
        }




        public void Write(string val) {
            _sb.Append(val);
        }

        public void Write(int val) {
            _sb.Append(val);
        }

        public void Write(long val) {
            _sb.Append(val);
        }

        public void Write(float val) {
            _sb.Append(val);
        }

        public void Write(double val) {
            _sb.Append(val);
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
            for (var i = 0; i < _indentation * 4; i++) {
                _sb.Append(' ');
            }
        }

        public override string ToString() => _sb.ToString();

    }
}
