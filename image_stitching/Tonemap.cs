using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using lib_tonemapping;

namespace image_stitching
{
   public  class Tonemapping
    {
       [DllImport("lib_tonemapping.dll")]
       public static extern string logmap(string img);

       public string Maptone(string img)
       {
           string path = null;
           byte[] bytes = Encoding.ASCII.GetBytes(img);
           Tonemap cls = new Tonemap();

           unsafe
           {
               sbyte* sp;
               sbyte* sp2;
               fixed (byte* p = bytes)
               {
                   sp = (sbyte*)p;

               }

             sp2 =   cls.logmap(sp);
               path = new string(sp2);
           }

           return path;
       }
    }
}
