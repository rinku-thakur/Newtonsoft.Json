#region License
// Copyright (c) 2007 James Newton-King
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System.ComponentModel;

namespace Autodesk.DataExchange.Newtonsoft.Json.Tests.TestObjects
{
    public class JsonPropertyWithHandlingValues
    {
        [Autodesk.DataExchange.Newtonsoft.Json.JsonPropertyAttribute(DefaultValueHandling = Autodesk.DataExchange.Newtonsoft.Json.DefaultValueHandling.Ignore)]
        [DefaultValue("Default!")]
        public string DefaultValueHandlingIgnoreProperty { get; set; }

        [Autodesk.DataExchange.Newtonsoft.Json.JsonPropertyAttribute(DefaultValueHandling = Autodesk.DataExchange.Newtonsoft.Json.DefaultValueHandling.Include)]
        [DefaultValue("Default!")]
        public string DefaultValueHandlingIncludeProperty { get; set; }

        [Autodesk.DataExchange.Newtonsoft.Json.JsonPropertyAttribute(DefaultValueHandling = Autodesk.DataExchange.Newtonsoft.Json.DefaultValueHandling.Populate)]
        [DefaultValue("Default!")]
        public string DefaultValueHandlingPopulateProperty { get; set; }

        [Autodesk.DataExchange.Newtonsoft.Json.JsonPropertyAttribute(DefaultValueHandling = Autodesk.DataExchange.Newtonsoft.Json.DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue("Default!")]
        public string DefaultValueHandlingIgnoreAndPopulateProperty { get; set; }

        [Autodesk.DataExchange.Newtonsoft.Json.JsonPropertyAttribute(NullValueHandling = Autodesk.DataExchange.Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NullValueHandlingIgnoreProperty { get; set; }

        [Autodesk.DataExchange.Newtonsoft.Json.JsonPropertyAttribute(NullValueHandling = Autodesk.DataExchange.Newtonsoft.Json.NullValueHandling.Include)]
        public string NullValueHandlingIncludeProperty { get; set; }

        [Autodesk.DataExchange.Newtonsoft.Json.JsonPropertyAttribute(ReferenceLoopHandling = Autodesk.DataExchange.Newtonsoft.Json.ReferenceLoopHandling.Error)]
        public JsonPropertyWithHandlingValues ReferenceLoopHandlingErrorProperty { get; set; }

        [Autodesk.DataExchange.Newtonsoft.Json.JsonPropertyAttribute(ReferenceLoopHandling = Autodesk.DataExchange.Newtonsoft.Json.ReferenceLoopHandling.Ignore)]
        public JsonPropertyWithHandlingValues ReferenceLoopHandlingIgnoreProperty { get; set; }

        [Autodesk.DataExchange.Newtonsoft.Json.JsonPropertyAttribute(ReferenceLoopHandling = Autodesk.DataExchange.Newtonsoft.Json.ReferenceLoopHandling.Serialize)]
        public JsonPropertyWithHandlingValues ReferenceLoopHandlingSerializeProperty { get; set; }
    }
}

