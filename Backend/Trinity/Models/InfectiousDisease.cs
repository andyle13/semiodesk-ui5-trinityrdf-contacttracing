﻿using ContactTracingGraph.Supports;
using Newtonsoft.Json;
using Semiodesk.Trinity;
using System;

namespace ContactTracingGraph.Models
{
    [RdfClass(CRT.InfectiousDisease)]
    public class InfectiousDisease : ODataResource
    {
        [JsonConstructor]
        public InfectiousDisease(string ID) : base(ID, CRT.InfectiousDisease) {}

        public InfectiousDisease() : base(CRT.InfectiousDisease) {}

        public InfectiousDisease(Uri uri) : base(uri) {}

        [RdfProperty(CRT.classification)]
        public string Classification { get; set; }

        [RdfProperty(CRT.dateDiagnosed)]
        public DateTime DateDiagnosed { get; set; }
    }
}
