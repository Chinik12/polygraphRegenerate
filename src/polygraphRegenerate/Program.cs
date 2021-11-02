using Polygraph.Core;
using Polygraph.Core.DM;
using System;
using System.Drawing.Imaging;
using System.IO;
using System.Text.Json;

namespace polygraphRegenerate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filepath = "D:\\github\\polygraphRegenerate\\repository\\example.json";
            string jsonString = File.ReadAllText(filepath);
            var pi = JsonSerializer.Deserialize<Polyimage>(jsonString);

            //If you want you can change the data 
            pi.Scale = 1;

            var pd = new PolydrawRegenerate(pi);
            pd.Draw();
            pd.Save($"image#{pi.Id.ToString("00000")}.png", ImageFormat.Png);
        }
    }
}
