﻿using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Text;

namespace NativeAppApi.Services
{
    public class ImageService
    {
        public void AddImageToFolder(string value)
        {
            byte[] imageBytes = Encoding.Unicode.GetBytes(value);
            File.WriteAllBytes("C:\\Users\\Udviklingshæmmede\\Documents\\Git\\NativeAppApi\\NativeAppApi\\Images\\", imageBytes);
            Console.WriteLine("The data has been written to the file.");
        }

        public void GetImagesFromFolder()
        {

        }
    }
}
