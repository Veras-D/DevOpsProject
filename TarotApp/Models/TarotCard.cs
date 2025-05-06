using System;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
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
                // Use AssetLoader to load resources from the assembly
                var uri = new Uri($"avares://TarotApp/{ImagePath}");
                using var stream = AssetLoader.Open(uri);
                return new Bitmap(stream);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image {ImagePath}: {ex.Message}");
                
                // If that fails, try to load the back card image as fallback
                try
                {
                    var uri = new Uri("avares://TarotApp/assets/verso.png");
                    using var stream = AssetLoader.Open(uri);
                    return new Bitmap(stream);
                }
                catch (Exception innerEx)
                {
                    Console.WriteLine($"Error loading fallback image: {innerEx.Message}");
                    return null;
                }
            }
        }
    }
}
