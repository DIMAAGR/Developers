using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Developers_By_Evolve
{
    class ProgramFileClass
    {
        void open(string path)
        {
            
        }

        public void create(string path)
        {
            string pathName = "OpenFileDatas.dt";
            File.Create(path + pathName);
        }
    }
}
