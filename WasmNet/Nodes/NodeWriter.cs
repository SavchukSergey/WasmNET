using System.Text;

namespace WasmNet.Nodes {
    public class NodeWriter {

        private StringBuilder _sb = new StringBuilder();

        private int _indentation = 0;

        public void Write(string val) {
            _sb.Append(val);
        }

        public void Write(int val) {
            _sb.Append(val);
        }

        public void Write(long val) {
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
