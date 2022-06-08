#region

using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

#endregion

namespace 实验16_命令模式_自定义按键 {
    public class ScreenShotHandler {
        public void Shot() {
            try {
                var screenHeight = Screen.PrimaryScreen.Bounds.Height;
                var screenWidth = Screen.PrimaryScreen.Bounds.Width;

                var captureBitmap = new Bitmap(screenWidth, screenHeight, PixelFormat.Format32bppArgb);
                var captureRectangle = Screen.AllScreens[0].Bounds;
                var captureGraphics = Graphics.FromImage(captureBitmap);
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0,
                    captureRectangle.Size);
                var targetPath =
                    $"{Directory.GetCurrentDirectory()}\\shot{DateTime.Now.ToString("yyyyMMddHHmmss")}.jpg";
                captureBitmap.Save(targetPath, ImageFormat.Jpeg);

                var psi = new ProcessStartInfo {
                    FileName = targetPath,
                    UseShellExecute = true
                };

                Process.Start(psi);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}