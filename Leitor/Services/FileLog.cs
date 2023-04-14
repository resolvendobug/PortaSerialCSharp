using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor.Services
{
    public class FileLog
    {
        public static bool WriteFile(string path, StringBuilder sb)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path , append: true))
                {
                    file.WriteLine(sb.ToString());
                }
                return true;
            }
            catch (Exception)
            {
                throw new DirectoryNotFoundException("Path not found");
            }
        }
    }
}
