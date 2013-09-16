using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdsPaint
{
    public class FileUtils
    {
        public static string GetBmpFilePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "bmp files (*.bmp)|*.bmp";
            var result = openFileDialog.ShowDialog();
            return openFileDialog.FileName;
        }

        public static void SaveBmpFile(PictureBox img, string path)
        {
            img.Image.Save(path);
        }

        public static string GetNewFilePath()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "bmp files (*.bmp)|*.bmp";
            var result = saveFileDialog.ShowDialog();
            return saveFileDialog.FileName;
        }

        public static void LoadImageFileToPictureBox(PaintForm form)
        {
            var path = FileUtils.GetBmpFilePath();
            if (!string.IsNullOrEmpty(path))
            {

                Bitmap bmp = new Bitmap(path);
                form.pbPaintingArea.Image = bmp;
                //Graphics gr = Graphics.FromImage(form.pbPaintingArea.Image);
                //Pen p = new Pen(Color.Red);
                //p.Width = 5.0f;
                //gr.DrawRectangle(p, 1, 2, 30, 40);
                form.pbPaintingArea.Image = bmp;
                form.pbPaintingArea.Size = bmp.Size;
            }
        }
    }
}