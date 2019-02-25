using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotJSON
{
    class HerokuQuote
    {
        public string character { get; set;}

        public string quote { get; set; }

        TextBlock txt = new TextBlock();
        txt.FontSize = 32; // 24 points
            txt.Inlines.Add("https://got-quotes.herokuapp.com/quotes");
    }
}
