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
    public partial class Death : Form
    {
        string pok = "", stts = "";

        public string PokemonsName
        {
            get { return name.Text; }
            set { name.Text = value; }
        }
        public string Pokemon
        {
            get { return pok; }
            set { pok = value; }
        }
        public string Status
        {
            get { return stts; }
            set { stts = value; }
        }       
        public Death()
        {
            InitializeComponent();
            status.Parent = pictureBox1;
            next.Parent = pictureBox1;
            pokemon.Parent = pictureBox1;
            date.Parent = pictureBox1;
            name.Parent = pictureBox1;
            name.ForeColor = ColorTranslator.FromHtml("#556069");
            date.ForeColor = ColorTranslator.FromHtml("#556069");
        }

        private void next_MouseMove(object sender, MouseEventArgs e)
        {
            next.Image = Properties.Resources.nextbutton2;
        }

        private void next_MouseLeave(object sender, EventArgs e)
        {
            next.Image = Properties.Resources.nexbutton;
        }

        private void Death_Activated(object sender, EventArgs e)
        {
            pokemon.Image = Image.FromFile($"Tombstone Images/{Pokemon}.png");

            if (Status == "Хворий")
                status.Text = "Ваш покемон помер від хвороби.";
            else
                status.Text = "Ваш покемон помер від старості.";

            using (StreamReader sr = new StreamReader($"Pokemons/{name.Text}/birthday.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    date.Text = $"{line} - {DateTime.Now.ToShortDateString()}";
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            pokemonDeleting();
            StartForm sf = new StartForm();
            this.Hide();
            sf.ShowDialog();
        }

        private void Death_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Death_FormClosing(object sender, FormClosingEventArgs e)
        {
            pokemonDeleting();
        }

        private void pokemonDeleting()
        {
            try
            {
                FileInfo fi;
                DirectoryInfo di = new DirectoryInfo($"Pokemons/{PokemonsName}");

                if (di.Exists)
                {

                    foreach (var i in di.GetFiles())
                    {
                        fi = new FileInfo($"Pokemons/{PokemonsName}/{i}");
                        fi.Delete();
                    }
                    di.Delete();
                }
            }
            catch (Exception) { };
        }
    }
}
