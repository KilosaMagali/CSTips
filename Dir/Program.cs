using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dir
{
    class Program
    {
        static void Main(string[] args)
        {

            string nb = "34";
            string path = "C:\\Satel\\Exams\\";
            string folderPath = path + nb.PadLeft(8, '0') + ".dir\\Statique\\";
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            foreach (var file in Directory.GetFiles(dir.FullName, "doc.dat.txt"))
            {
                using (var reader = new StreamReader(file))
                {
                    //found
                }
            }
        }
    }
}
