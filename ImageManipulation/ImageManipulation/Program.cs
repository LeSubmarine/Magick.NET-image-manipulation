using ImageManipulation.ImageManipulationBorder.intefaces;
using ImageManipulation.ImageManipulationBorder.MagickImplementations;
using ImageManipulation.UserInputBorder.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageResizer resizer = new MagickImageResizerImpl();
            ImageBackgroundReplacer backgroundReplacer = new MagickImageBackgroundReplacer();
            ImageFilePersistance filePersistance = new MagickImageFilePersistanceImpl();
            UserInput userInput = new ConsoleUserInputImpl();

            string action = userInput.GetUserInput<string>("What action do you want to perform? (resize/changeBackground/default)");

            switch (action)
            {
                case "resize":
                    {
                        string imageName = userInput.GetUserInput<string>("What picture do you want to resize?");
                        int newWidth = userInput.GetUserInput<int>("What is the new width?");
                        int newHeight = userInput.GetUserInput<int>("What is the new height?");
                        string newImageName = userInput.GetUserInput<string>("What do you want to call the resized image?");

                        Image image = filePersistance.GetImage(imageName);

                        Image resizedImage = resizer.ResizeImage(image, newWidth, newHeight);
                        filePersistance.SaveImage(resizedImage, newImageName + ".jpg");
                        break;
                    }
                case "changeBackground":
                    {
                        string imageName = userInput.GetUserInput<string>("What picture do you want to change background on?");
                        ushort newRed = userInput.GetUserInput<ushort>("What is the new red color?");
                        ushort newGreen = userInput.GetUserInput<ushort>("What is the new green color?");
                        ushort newBlue = userInput.GetUserInput<ushort>("What is the new blue color?");
                        string newImageName = userInput.GetUserInput<string>("What do you want to call the new image?");

                        Image image = filePersistance.GetImage(imageName);
                        Color newColor = new MagickColorImpl(newRed, newGreen, newBlue);

                        Image newImage = backgroundReplacer.ChangeBackgroundColor(image, newColor);
                        filePersistance.SaveImage(newImage, newImageName + ".jpg");
                        break;
                    }
                case "default":
                default:
                    {
                        string imageName = "CapriSun.jpg";
                        Image image = filePersistance.GetImage(imageName);
                        Color newBackgroundColor = new MagickColorImpl(ushort.MinValue, ushort.MinValue, ushort.MaxValue);
                        int firstResizeSize = 200;
                        int secondResizeSize = 1000;

                        Image firstResizedImage = resizer.ResizeImage(image, firstResizeSize, firstResizeSize);
                        filePersistance.SaveImage(firstResizedImage, "200200jpeg.jpg");

                        Image secondResizedImage = resizer.ResizeImage(image, secondResizeSize, secondResizeSize);
                        filePersistance.SaveImage(secondResizedImage, "10001000jpeg.jpg");

                        Image imageWithChangedBackground = backgroundReplacer.ChangeBackgroundColor(image, newBackgroundColor);
                        filePersistance.SaveImage(imageWithChangedBackground, "BlueSunjpeg.jpg");
                        break;
                    }
            }

            Console.ReadLine();
        }
    }
}
