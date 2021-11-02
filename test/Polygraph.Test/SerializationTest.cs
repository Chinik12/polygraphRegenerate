using Polygraph.Core.Converter;
using Polygraph.Core.DM;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;
using Xunit;


namespace Polygraph.Test
{
    public class SerializationTest
    {
        [Fact]
        public void SerializationPointJsonConverter()
        {
            var serializeOptions = new JsonSerializerOptions
            {
                Converters =
                {
                    new PointJsonConverter()
                }
            };
            var result = JsonSerializer.Serialize(new Point(41, 17), serializeOptions);
            Assert.Equal("\"41,17\"",result);
        }

        [Fact]
        public void DeserializationPointJsonConverter()
        {
            var serializeOptions = new JsonSerializerOptions
            {
                Converters =
                {
                    new PointJsonConverter()
                }
            };
            var point = new Point(41, 17);
            var result = JsonSerializer.Deserialize<Point>("\"41,17\"", serializeOptions);
            Assert.Equal(point.X, result.X);
            Assert.Equal(point.Y, result.Y);
        }


        [Fact]
        public void SerializationPointsJsonConverter()
        {
            var obj = new Polypart()
            {
                Points = new Point[] { new Point(20, 20), new Point(20, 10), new Point(10, 10) },
                BrightnessFactor = 0.0001F
            };
            var result = JsonSerializer.Serialize(obj);
            Assert.Contains("\"Points\":[\"20,20\",\"20,10\",\"10,10\"]", result);
        }

        [Fact]
        public void DeserializationPointsJsonConverter()
        {
            var result = JsonSerializer.Deserialize<Polypart>("{\"Points\":[\"20,20\",\"20,10\",\"10,10\"]}");
            Assert.Equal(3, result.Points.Length);
            Assert.Contains<Point>(new Point(20, 20), result.Points);
            Assert.Contains<Point>(new Point(20, 10), result.Points);
            Assert.Contains<Point>(new Point(10, 10), result.Points);
        }
    }
}
