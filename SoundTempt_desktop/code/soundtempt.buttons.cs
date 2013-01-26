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
    public partial class soundtempt
    {

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "JPeg Image|*.jpg";
            saveFileDialog.Title = "Spremi note";
            saveFileDialog.FileName = "defaultSoundTempt";
            saveFileDialog.ShowDialog();
            SaveAsBitmap(notePanel, saveAdress);
        }

    }
}
