using Imageflow.Fluent;
using System;
using System.Threading.Tasks;

namespace ImageFlow_x86_Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // From https://github.com/imazen/imageflow-dotnet#getting-image-dimensions-and-format
            var imageBytes = Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAAAEAAAABAQMAAAAl21bKAAAAA1BMVEX/TQBcNTh/AAAAAXRSTlPM0jRW/QAAAApJREFUeJxjYgAAAAYAAzY3fKgAAAAASUVORK5CYII=");
            var info = await ImageJob.GetImageInfo(new BytesSource(imageBytes));

            Console.WriteLine(info.ImageWidth);
            Console.Read();
        }
    }
}
