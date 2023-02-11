using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Post_Text.Entities
{
    internal class Comment
    {
        public string text { get; set; }


        public Comment() 
        {
        }

        public Comment(string text)
        {
            text = text;
        }
    }
}
