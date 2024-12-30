using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2048
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            label1.Text = "Текущий размер: " + DataBase.len;
        }

        
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            
            DataBase.len = trackBar1.Value;
            switch (DataBase.len)
            {
                case (1): DataBase.len = 4; break;
                case (2): DataBase.len = 6; break;
                case (3): DataBase.len = 8; break;
                case (4): DataBase.len = 10; break;
            }

            label1.Text = "Текущий размер: " + DataBase.len;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.MENU.Show();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 200);
        }
    }
}
