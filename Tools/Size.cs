using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Tools
{
    internal class Size
    {
        public static string Getsize(long data)
        {
            string size = "";
            if(data == 0)
            {
                size = data.ToString()+"Bit";
                return size;
            }

            if (data > 1024)
            {
                long progress = data / 1024;
                if (progress > 1024)
                {
                    long progress2 = progress / 1024;
                    if (progress2 > 1024)
                    {
                        long progress3 = progress2 / 1024;
                        size = progress3.ToString() + "GB";
                    }
                    else
                    {
                        size = progress2.ToString() + "MB";
                    }
                }
                else
                {
                    size = progress.ToString() + "Byte";
                }
            }
            else
            {
                size = data.ToString() + "Bit";
            }
            return size;
        }
    }
}
