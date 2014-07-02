using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using lib_imagestitching;

namespace image_stitching
{
    public class stitch
    {
        [DllImport("lib_imagestitching.dll")]
        public static extern string imagestitch(string im1, string im2);

       

        public string StitchImage(string img1, string img2)
        {
            string path = null;
            byte[] bytes = Encoding.ASCII.GetBytes(img1);
            byte[] bytes2 = Encoding.ASCII.GetBytes(img2);
            Class1 cls = new Class1();
            
            unsafe
            {
                sbyte* sp;
                sbyte* sp2;
                sbyte* sp3;
                fixed (byte* p = bytes )
                {
                    sp = (sbyte*)p;
                    
                }
                fixed (byte* p2 = bytes2)
                {
                    sp2 = (sbyte*)p2;
                }
                sp3 = cls.imagestitch(sp, sp2);
                path = new string(sp3);
            }
            
            return path;
        }
      


    }
}
