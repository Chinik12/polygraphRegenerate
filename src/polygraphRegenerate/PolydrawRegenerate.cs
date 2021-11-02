using Polygraph.Core;
using Polygraph.Core.DM;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygraphRegenerate
{
    public class PolydrawRegenerate : Polydraw
    {
        public PolydrawRegenerate(Polyimage pi) : base(pi)
        {
            Elements = pi.Elements;
        }

        public List<Polyobject> Elements { get; private set; }

        public void Draw()
        {
            foreach (var element in Elements)
            {
                foreach (var polypart in element.Composition)
                {
                    SolidBrush brush = new SolidBrush(polypart.Color);
                    Grp.FillPolygon(brush, polypart.Points);
                }
            }
        }


    }
}
