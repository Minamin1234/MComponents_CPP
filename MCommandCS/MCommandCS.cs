using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCommandCS
{
    public class MCommand
    {
        public string Version = "v1.0";
        protected List<MModule> Modules;
        protected List<string> DefaultCommands;
        protected string ModuleSprt = ".";
        protected string SprtInArgs = ",";

        public MCommand()
        {

        }

        virtual protected void Initialize()
        {

        }

        public void IncludeNewModule(MModule newmodule)
        {
            if (newmodule == null) throw new ArgumentNullException();
            this.Modules.Add(newmodule);
        }

        public void Run()
        {

        }

        public List<string> DecodeArgs(string words)
        {
            var args = new List<string>();
            return args;
        }

        public void ShowAllModuleCommandInfo()
        {

        }

        public void ShowAllDefaultCommands()
        {

        }

        public void ExecuteCommand(List<string> args)
        {

        }

    }
}
