using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ResoniteLink
{
    [JsonDerivedType(typeof(PointSubmeshRawData), "points")]
    [JsonDerivedType(typeof(TriangleSubmeshRawData), "triangles")]
    public abstract class SubmeshRawData
    {

    }
}
