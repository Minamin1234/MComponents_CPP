using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCommandCS
{
    public class MMath : MModule
    {
        public MMath()
        {
            this.ModuleName = "math";
            this.Commands.Add("abs");
            this.Commands.Add("sin");
            this.Commands.Add("cos");
            this.Commands.Add("tan");
            this.Commands.Add("rad");
            this.Commands.Add("pow");
            this.Commands.Add("sqrt");
            this.Commands.Add("max");
            this.Commands.Add("min");
            this.Commands.Add("pi");
            this.Commands.Add("e");
            this.Commands.Add("help");
        }
    }
}
