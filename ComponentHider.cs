using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeDownloader
{
    static class ComponentHider
    {
        public static void showElements(List<Control> elements){
            for(int i=0; i<elements.Count; i++)
                elements[i].Visible = true;
        }

        public static void hideElements(List<Control> elements){
            for (int i = 0; i < elements.Count; i++)
                elements[i].Visible = false;
        }

    }
}
