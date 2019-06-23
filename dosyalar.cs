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
        public string text,loadfile;
        public string[] lines;
        public List<string[]> liness = new List<string[]>();
        public Dosyalar(string loadfile)
        {
            text = File.ReadAllText(loadfile);
            this.lines = File.ReadAllLines(loadfile);

            loadfile = this.loadfile;
            for (int i = 0; lines.Length>i;i++)
            {
               liness.Add( lines[i].Split(','));
                
            }
        }
       public void write()
        {
            text = "";
            for(int i = 0; liness.Count > i; i++)
            {
                for (int j = 0; liness.ElementAt(i).Length > j; j++)
                {
                    if (liness.ElementAt(i).Length - 1 == j)
                    {
                        text = text + liness.ElementAt(i)[j];
                    }
                    else
                    {
                        text = text + liness.ElementAt(i)[j]+",";
                    }
                }
                text = text+ Environment.NewLine;
            }
            File.WriteAllText(loadfile,text);
        }
        
    }
}
