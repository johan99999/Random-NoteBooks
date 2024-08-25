using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_NoteBooks
{
    public class Note
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
