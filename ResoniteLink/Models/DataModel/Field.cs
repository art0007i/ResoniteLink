using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ResoniteLink
{
    public abstract class Field : Member
    {
        [JsonIgnore]
        public abstract object BoxedValue { get; set; }

        [JsonIgnore]
        public abstract Type ValueType { get; }
    }
}
