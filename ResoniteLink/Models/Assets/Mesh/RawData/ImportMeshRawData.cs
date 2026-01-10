using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ResoniteLink
{
    /// <summary>
    /// Imports a mesh asset from raw mesh data.
    /// This is recommended method to import meshes, as it's a lot more efficient, but can be more difficult to work with.
    /// To use this, first configure all the structure metadata (vertex counts, submeshes, blendshapes and so on)
    /// and then call method to allocate the raw data.
    /// Aftewards you'll be able to access the raw data buffers and fill them with actual mesh data.
    /// </summary>
    public class ImportMeshRawData : BinaryPayloadMessage
    {
        /// <summary>
        /// Number of vertices in this mesh.
        /// </summary>
        [JsonPropertyName("vertexCount")]
        public int VertexCount { get; set; }

        /// <summary>
        /// Do vertices have normals?
        /// </summary>
        [JsonPropertyName("hasNormals")]
        public bool HasNormals { get; set; }

        /// <summary>
        /// Do vertices have tangents?
        /// </summary>
        [JsonPropertyName("hasTangents")]
        public bool HasTangents { get; set; }

        /// <summary>
        /// Do vertices have colors?
        /// </summary>
        [JsonPropertyName("hasColors")]
        public bool HasColors { get; set; }

        /// <summary>
        /// Configuration of UV channels for this mesh.
        /// Each entry represents one UV channel of the mesh.
        /// Number indicates number of UV dimensions. This must be between 2 and 4 (inclusive)
        /// </summary>
        [JsonPropertyName("uvChannelDimensions")]
        public List<int> UV_Channel_Dimensions { get; set; }

        /// <summary>
        /// Submeshes that form this mesh. Meshes will typically have at least one submesh.
        /// </summary>
        [JsonPropertyName("submeshes")]
        public List<SubmeshRawData> Submeshes { get; set; }
    }
}
