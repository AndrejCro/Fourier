using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsktp
{
    public partial class soundtempt : Form
    {

    string saveAdress = "";

    private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            saveAdress = saveFileDialog.FileName;
        }

	public void SaveAsBitmap(Control control, string fileName)
        {
            //getthe instance of the graphics from the control
            Graphics g = control.CreateGraphics();

            //new bitmap object to save the image
            Bitmap bmp = new Bitmap(control.Width, control.Height);

            //Drawing control to the bitmap
            control.DrawToBitmap(bmp, new Rectangle(0, 0, control.Width, control.Height));

            bmp.Save(fileName);
            bmp.Dispose();

        }

    }
}
