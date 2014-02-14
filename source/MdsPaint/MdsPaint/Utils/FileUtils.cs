using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using MdsPaint.Properties;
using MdsPaint.View;

namespace MdsPaint.Utils
{
    public class FileUtils
    {
        public static string GetBmpFilePath()
        {
            var openFileDialog = new OpenFileDialog {Filter = Resources.BmpFilter};
            openFileDialog.ShowDialog();
            return openFileDialog.FileName;
        }

        public static string GetNewFilePath()
        {
            var saveFileDialog = new SaveFileDialog {Filter = Resources.BmpFilter};
            saveFileDialog.ShowDialog();
            return saveFileDialog.FileName;
        }

        public static void SaveBmpFile(Bitmap img)
        {
            var path = GetNewFilePath();
            if (!string.IsNullOrEmpty(path))
            {
                img.Save(path);
            }
        }

        public static void LoadImageFileToMainPanel(PaintForm form)
        {
            var path = GetBmpFilePath();
            if (string.IsNullOrEmpty(path)) return;

            var bmp = new Bitmap(path);
            var formatedBmp = new Bitmap(bmp.Width, bmp.Height, PixelFormat.Format32bppArgb);

            using (var gfx = Graphics.FromImage(formatedBmp))
            {
                gfx.DrawImage(bmp, 0, 0);
            }

            form.MainBitmap = formatedBmp;
            form.paintingArea.Invalidate();
        }
    }
}