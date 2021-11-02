using Microsoft.Extensions.CommandLineUtils;
using Polygraph.Core;
using Polygraph.Core.DM;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.Json;

namespace polygraphRegenerate
{
    internal class Program
    {
        static int Main(string[] args)
        {
            var app = new CommandLineApplication
            {
                Name = "polygraphRegenerate",
                Description = "example to generate a PolyLama from metadata"
            };

            app.HelpOption("-?|-h|--help");
            var filepath = app.Option("-f|--file", "File path of metadata", CommandOptionType.SingleValue);

            app.OnExecute(() =>
            {
                string jsonString = File.ReadAllText(filepath.Value());
                var pi = JsonSerializer.Deserialize<Polyimage>(jsonString);

                //If you want you can change the data 
                pi.Backgroundcolor.Color = Color.FromArgb(0, 0, 0);

                var pd = new PolydrawRegenerate(pi);
                pd.Draw();
                pd.Save($"image#{pi.Id.ToString("00000")}.png", ImageFormat.Png);
                return 0;
            });
            return app.Execute(args);
        }
    }
}
