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
        private Panel notePanel;
        private Button printButton;
        private SaveFileDialog saveFileDialog;
        private Button exitButton;
    
        public soundtempt()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.notePanel = new System.Windows.Forms.Panel();
            this.printButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(571, 431);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 76);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // notePanel
            // 
            this.notePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notePanel.BackColor = System.Drawing.Color.DarkGray;
            this.notePanel.Location = new System.Drawing.Point(287, 169);
            this.notePanel.Name = "notePanel";
            this.notePanel.Size = new System.Drawing.Size(111, 250);
            this.notePanel.TabIndex = 1;
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.Location = new System.Drawing.Point(586, 392);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(94, 27);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Print Panel";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // soundtempt
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(708, 519);
            this.ControlBox = false;
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.notePanel);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "soundtempt";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.soundtempt_Load);
            this.ResumeLayout(false);

        }














    }
}
