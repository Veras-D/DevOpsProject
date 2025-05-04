using System;
using Avalonia.Media.Imaging;
using System.IO;

namespace TarotApp.Models
{
    public class TarotCard
    {
        public int Id { get; }
        public string Name { get; }
        public string ImagePath { get; }

        public TarotCard(int id, string name, string imagePath)
        {
            Id = id;
            Name = name;
            ImagePath = imagePath;
        }

        public Bitmap LoadImage()
        {
            try
            {
                return new Bitmap(ImagePath);
            }
            catch (Exception)
            {
                // If the card image cannot be loaded, try to load a default image
                try
                {
                    return new Bitmap("assets/verso.png");
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}

