using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY_TERMINAL
{
    public abstract class Bibliophile
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public abstract string AskAquestion();
        public abstract string AnswerAQuestion();
    }
}
