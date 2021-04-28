using Stride.Core;
using Stride.Core.Mathematics;
using Stride.Engine;

namespace MeshOutlineRenderFeature
{
    /// <summary>
    /// Enables mesh outline (MeshOutlineRenderFeature must be enabled in Graphics Compositor)
    /// </summary>
    [DataContract("MeshOutline")]
    [Display("Outline", null, Expand = ExpandRule.Once)]
    [ComponentCategory("Model")]
    public class Outline : EntityComponent
    {
        /// <summary>
        /// Enables or disables mesh outline
        /// </summary>
        [DataMember(10)]
        public bool Enabled = true;

        /// <summary>
        /// Color of outline
        /// </summary>
        [DataMember(30)]
        public Color4 Color = new Color4();

        /// <summary>
        /// Intensity of outline color
        /// </summary>
        [DataMember(40)]
        public float Intensity = 1.0f;
    }
}
