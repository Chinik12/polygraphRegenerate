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
    public class PointJsonConverter : JsonConverter<Point>
    {
        public override Point Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var values = reader.GetString().Split(',');
            if (values.Length != 2)
            {
                throw new ArgumentException("Value is not in 'X,Y' format.");
            }
            var result = new Point(int.Parse(values[0]), int.Parse(values[1]));
            return result;
        }

        public override void Write(Utf8JsonWriter writer, Point value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.X},{value.Y}");
        }
    }
}
