using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public interface IFilereader
    {
        string Read(string path);
    }

    class Filereader : IFilereader
    {

       public string Read(string path) 
        {
            return File.ReadAllText(path);
        }
    }
}
