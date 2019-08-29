using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoAlbumTarea
{
    class AlbumTest : PhotoAlbum
    {
        static void Main()
        {
            var abum = new PhotoAlbum(24);
            Console.WriteLine(abum.GetNumberOfPages());

        }
     }
}
