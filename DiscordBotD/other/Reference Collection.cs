using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotD.other
{
    public class ReferenceCollection
    {
        private string[] figureDrawing = new string[]
        {
            "https://line-of-action.com/practice-tools/figure-drawing",
            "https://quickposes.com/en",
            "https://www.bodiesinmotion.photo/"
        };
       private string[] anatomy = new string[]
        {
            "https://www.youtube.com/playlist?list=PLtG4P3lq8RHFBeVaruf2JjyQmZJH4__Zv",
            "https://www.pinterest.de/christineisnothere/propic-x-taco/"
        };
       private string[] color = new string[]
        {
            "https://www.youtube.com/playlist?list=PL002hNYqg1VjoRaboVhLbbCPR_0i2xUxV",
            "https://www.youtube.com/@nfowkesart/videos"

        };

        private string[] design = new string[]
        {
            "https://characterdesignreferences.com/character-design-boards"
        };

        public string FigureDrawing { get; set; }
        public string Anatomy { get; set; }
        public string Color { get; set; }

        public string Design { get; set; }

        


        public ReferenceCollection()  //My Reference constructor
        {
           var random = new Random();
            int figureIndex = random.Next(0, figureDrawing.Length);
            int anatomyIndex = random.Next(0, anatomy.Length);
            int colorIndex = random.Next(0, color.Length);
            int DesignIndex = random.Next(0, design.Length);

            this.FigureDrawing = figureDrawing[figureIndex];
            this.Anatomy = anatomy[anatomyIndex];
            this.Color = color[colorIndex];
            this.Design = design[DesignIndex];
        }

    }
}
