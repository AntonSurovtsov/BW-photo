using System;
using System.Drawing;
using System.Windows.Forms;

namespace BW_photo
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Images | *.bmp; *.png; *.jpg; *.JPEG"
            };

            Console.WriteLine("Press enter to start...");

            while (true)
            {
                Console.ReadLine();

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    continue;

                Console.Clear();

                var bitmap = new Bitmap(openFileDialog.FileName);

                bitmap.ToGrayscale();

                bitmap.Save($"{openFileDialog.FileName.Substring(0, openFileDialog.FileName.Length - 4)}BW.jpg");

                Console.WriteLine("Complete!");
            }
         }
        
    }
}