using System;
using Andeart.JsonButler.CodeGeneration;
using Andeart.JsonButler.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Andeart.JsonButlerTest.Tests
{
    [TestClass]
    public class JsonButlerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            ButlerCsFile bcg = new ButlerCsFile ();
            string sourceText =
                "{\r\n  \"Greetings\": \"Welcome!\",\r\n  \"instructions\": [\r\n    \"Type or paste JSON here\",\r\n    \"Or choose a sample above\",\r\n    \"quicktype will generate code in your\",\r\n    \"chosen language to parse the sample data\"\r\n  ],\r\n  \"idNumber\": 1,\r\n  \"my_data\": {\r\n    \"my_data\": {\r\n      \"my_id\": 24.4\r\n    }\r\n  }\r\n}";

            bcg.CreateCode (sourceText);
        }
    }
}
