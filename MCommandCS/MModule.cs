using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCommandCS
{
    public class MModule
    {
        public string ModuleName = "module";
        public List<string> Commands;

        public MModule()
        {

        }

        virtual public void ExecuteCommand(List<string> args)
        {

        }

        virtual public void ShowHelp()
        {
            
        }
    }
}
