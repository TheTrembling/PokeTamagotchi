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
    public partial class Continue : Form
    {
        public Continue()
        {
            InitializeComponent();
            ready.Parent = pictureBox1;
            pet.Parent = pictureBox1;
            pokemons.BackColor = ColorTranslator.FromHtml("#170303");
            DirectoryInfo di = new DirectoryInfo("Pokemons");
            foreach(var i in di.GetDirectories())
                pokemons.Items.Add(i);
        }

        private void ready_MouseMove(object sender, MouseEventArgs e)
        {
            ready.Image = Properties.Resources.ready2;
        }

        private void ready_MouseLeave(object sender, EventArgs e)
        {
            ready.Image = Properties.Resources.ready;
        }

        private void ready_Click(object sender, EventArgs e)
        {
            try
            {
                if (pokemons.SelectedIndex != -1)
                {
                    PokeTamagochi pt = new PokeTamagochi();
                    pt.setName = pokemons.SelectedItem.ToString();
                    this.Hide();
                    pt.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Оберіть покемона зі списку.", "Помилка вибору", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception) { };
        }

        private void pokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pokemon = "";
            try
            {
                using (StreamReader sr = new StreamReader($"Pokemons/{pokemons.SelectedItem.ToString()}/{pokemons.SelectedItem.ToString()}.txt"))
                {
                    int c = 0;
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        c++;
                        if (c == 1)
                            pokemon = s;
                    }
                }
                pet.Image = Image.FromFile($"Animations/Front/{pokemon}.gif");

            }
            catch (Exception) { };
        }

        private void Continue_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                StartForm sf = new StartForm();
                this.Hide();
                sf.ShowDialog();
            }
        }

        private void Continue_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pokemons_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                StartForm sf = new StartForm();
                this.Hide();
                sf.ShowDialog();
            }
        }
    }
}
