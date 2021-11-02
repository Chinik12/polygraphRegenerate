using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Polygraph.Core.Converter
{
    public class ColorJsonConverter : JsonConverter<Color>
    {
        public override Color Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var values = reader.GetString().Split(',');
            if (values.Length != 4)
            {
                throw new ArgumentException("Value is not in 'A,R,G,B' format.");
            }
            var result = Color.FromArgb(int.Parse(values[0]), int.Parse(values[1]),int.Parse(values[2]),int.Parse(values[3]));
            return result;
        }

        public override void Write(Utf8JsonWriter writer, Color value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.A},{value.R},{value.G},{value.B}");
        }
    }
}
