using Polygraph.Core.Converter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Polygraph.Core.DM
{
    public class BackgroundColor
    {
        public BackgroundColor(string name, Color color)
        {
            Name = name;
            Color = color;
        }
        [JsonConverter(typeof(ColorJsonConverter))]
        public Color Color { get; set; }
        public string Name { get; set; }

    }
}
