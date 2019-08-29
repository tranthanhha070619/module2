using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Text
    {
        public static void Main()
        {
            var rect = new Rectangle();
            rect.setLocation(5.5, 5.7);
            Console.WriteLine(rect.toString(true));
            Console.WriteLine(rect.toString(false));

            var area = new Circle();
            area.setRadius(10);
            Console.WriteLine(area.toString(true));
            Console.WriteLine(area.toString(false));

        }
    }
}
