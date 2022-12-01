using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Text;

namespace NativeAppApi.Services
{
    public class ImageService
    {
        public void AddImageToFolder(string value)
        {
            var formattet = value.Replace(" ","+");
            byte[] imageBytes = Convert.FromBase64String(formattet);

            Random random = new Random();
            var rnd = random.Next(0, 500000000);
            File.WriteAllBytes("Images/"+rnd+".jpg", imageBytes);
            Console.WriteLine("The data has been written to the file.");
        }

        public void GetImagesFromFolder()
        {

        }
    }
}
