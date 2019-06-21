using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGTranslater
{
    class Dosyalar
    {
        public string text;
        public string[] lines;
        public List<string[]> liness = new List<string[]>();
         public Dosyalar(string loadfile)
        {
            text = File.ReadAllText(loadfile);
            this.lines = File.ReadAllLines(loadfile);
            
          
            for (int i = 0; lines.Length>i;i++)
            {
               liness.Add( lines[i].Split(','));
                Console.WriteLine(liness[i].Length);
            }
        }
       
        
    }
}
