using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnlib.DotNet;

namespace AsStrongAsFuck
{
    public class ModuleRenaming : IObfuscation
    {
        public void Execute(ModuleDefMD md)
        {
            string shit = Renamer.Hell + Renamer.GetRandomName() + Renamer.Hell + Renamer.GetRandomName() + Renamer.Hell + Renamer.GetRandomName() + Renamer.Hell + Renamer.GetRandomName() + Renamer.Hell + Renamer.GetRandomName() + Renamer.Hell + Renamer.GetRandomName();
            md.Name = shit;
        }
    }
}
