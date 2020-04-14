﻿using Xunit;
using System.Linq;
using Newtonsoft.Json;
using Elements;
using Hypar.Functions.Execution.Local;
using Elements.Serialization.glTF;
using Elements.Serialization.JSON;
using System.Collections.Generic;
using System;

namespace FoundationByEnvelope.Tests
{
    public class FoundationByEnvelopeTests
    {
        [Fact]
        public void FoundationByEnvelopeTest()
        {
            var inputs = new FoundationByEnvelopeInputs(5, "", "", new Dictionary<string, string>(), "", "", "");
            var model = Model.FromJson(System.IO.File.ReadAllText("./Building-01.json"));
        }

    }
}
