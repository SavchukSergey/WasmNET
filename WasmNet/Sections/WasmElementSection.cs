﻿using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Sections {
    public class WasmElementSection {

        public IList<WasmElementSegment> Entries { get; } = new List<WasmElementSegment>();

    }
}
