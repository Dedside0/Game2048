using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2048
{
    public partial class FormMenu : Form
    {
        
        public FormMenu()
        {
            InitializeComponent();
            Forms.MENU = this;
        }


        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame();
            game.Show();
            Forms.MENU.Hide();
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            FormSettings settings = new FormSettings();
            settings.Show();
            Forms.MENU.Hide();
        }

        private void pictureBoxExit_Click_1(object sender, EventArgs e)
        {
            Forms.MENU.Close();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

            this.Location = new Point(500, 200);
        }

        

        //  Все изменение кнопок при наведении курсора

        private void pictureBoxPlay_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxPlay.Image = Image.FromFile("images/buttons/play_enter.png");
        }

        private void pictureBoxPlay_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxPlay.Image = Image.FromFile("images/buttons/play.png");
        }

        private void pictureBoxSettings_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxSettings.Image = Image.FromFile("images/buttons/setting_enter.png");
        }

        private void pictureBoxSettings_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSettings.Image = Image.FromFile("images/buttons/settings.png");
        }

        private void pictureBoxExit_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxExit.Image = Image.FromFile("images/buttons/exit_enter.png");
        }

        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxExit.Image = Image.FromFile("images/buttons/exit.png");
        }
    }
}
