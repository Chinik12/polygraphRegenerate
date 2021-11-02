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
    public class PointsJsonConverter : JsonConverter<Point[]>
    {
        private PointJsonConverter pjc = new PointJsonConverter();

        public override Point[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new ArgumentException("The array isn't start with [.");
            }
            var result = new List<Point>(3);            
            while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
            {
                var point = pjc.Read(ref reader, typeToConvert, options);
                result.Add(point);
            }
            return result.ToArray();
        }

        public override void Write(Utf8JsonWriter writer, Point[] value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            for (int i = 0; i < value.Length; i++)
            {
                pjc.Write(writer, value[i], options);
            }
            writer.WriteEndArray();
        }
    }
}
