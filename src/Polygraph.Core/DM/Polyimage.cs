using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygraph.Core.DM
{
    public class Polyimage
    {
        public Polyimage()
        {
            if (Scale<1)
            {
                Scale = 10;
            }
            Elements = new List<Polyobject>();
        }

        public int Scale { get; set; }
        public List<Polyobject> Elements { get; set; }
        public BackgroundColor Backgroundcolor { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
