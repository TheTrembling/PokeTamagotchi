using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PokeTamagochi
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            newGame.Parent = pictureBox1;
            continue_.Parent = pictureBox1;
            directoryCreate();
        }

       private void directoryCreate()
        {
            DirectoryInfo dr = new DirectoryInfo(@"Pokemons");
            if (!dr.Exists)
                dr.Create();
        }

        private void newGame_MouseMove(object sender, MouseEventArgs e)
        {
            newGame.Image = Properties.Resources.newgame2;
        }

        private void newGame_MouseLeave(object sender, EventArgs e)
        {
            newGame.Image = Properties.Resources.newgame;
        }

        private void continue__MouseMove(object sender, MouseEventArgs e)
        {
            continue_.Image = Properties.Resources.cntn2;
        }

        private void continue__MouseLeave(object sender, EventArgs e)
        {
            continue_.Image = Properties.Resources.cntn;
        }

        private void continue__Click(object sender, EventArgs e)
        {
            Continue cn = new Continue();
            this.Hide();
            cn.ShowDialog();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            PokemonSelection ps = new PokemonSelection();
            this.Hide();
            ps.ShowDialog();   
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
