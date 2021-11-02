using Polygraph.Core.Converter;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json.Serialization;

namespace Polygraph.Core.DM
{
    public class Polypart
    {
        [JsonConverter(typeof(PointsJsonConverter))]
        public Point[] Points { get; set; }
        [JsonConverter(typeof(ColorJsonConverter))]
        public Color Color { get; set; }
        public double BrightnessFactor { get; set; }
    }
}