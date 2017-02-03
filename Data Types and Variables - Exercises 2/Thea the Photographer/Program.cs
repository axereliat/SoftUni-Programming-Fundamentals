using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var pictureAmount = decimal.Parse(Console.ReadLine());
            var filterTime = decimal.Parse(Console.ReadLine());
            var percentage = decimal.Parse(Console.ReadLine());
            var uploadTime = decimal.Parse(Console.ReadLine());
 
            decimal filteredPictures = Math.Ceiling(pictureAmount * (percentage / 100m));
            // Console.WriteLine(filteredPictures);
            decimal sum = (pictureAmount * filterTime);
            sum += (filteredPictures * uploadTime);
 
            Console.WriteLine(ConvertSecondsToDate(Convert.ToString(sum)));
        }
        static string ConvertSecondsToDate(string seconds)
        {
            TimeSpan t = TimeSpan.FromSeconds(Convert.ToDouble(seconds));
 
            return t.ToString(@"d\:hh\:mm\:ss");
 
        }
    }
}
