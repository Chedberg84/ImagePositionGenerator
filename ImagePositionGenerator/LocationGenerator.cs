using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;

namespace ImagePositionGenerator
{
    public class LocationGenerator
    {
        public string Execute(string imageLocation)
        {
            List<Point> list = new List<Point>();
            Bitmap image = new Bitmap(imageLocation);
            var count = 0;

            for(int y = 0; y < image.Height; y++)
            {
                for(int x = 0; x < image.Width; x++)
                {
                    var pixel = image.GetPixel(x, y);

                    if(pixel.R == 255 && pixel.G == 0 && pixel.B == 0)
                    {
                        count++;

                        if (count >= 10)
                        {
                            list.Add(new Point(x, y));
                            count = 0;
                        }
                    }
                }
            }

            return JsonConvert.SerializeObject(list);
        }
    }
}
