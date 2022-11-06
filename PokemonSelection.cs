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
    public partial class PokemonSelection : Form
    {
        int c = 1;
        string pokemonName = "bulbasaur";
        public PokemonSelection()
        {
            InitializeComponent();
            left.Parent = pictureBox1;
            right.Parent = pictureBox1;
            pokemon.Parent = pictureBox1;
            accept.Parent = pictureBox1;
            ChangePokemon();
        }

        private void ChangePokemon()
        {
            if(c == 1) pokemonName = "bulbasaur";
            
            if (c == 2) pokemonName = "charmander";
            
            if (c == 3) pokemonName = "squirtle";
            
            if (c == 4) pokemonName = "pichu";

            pokemon.Image = Image.FromFile($"Animations/Front/{pokemonName}.gif");
            
        }

        private void left_Click(object sender, EventArgs e)
        {
            c--;
            if (c == 0) c = 4;
            ChangePokemon();
        }
        private void right_Click(object sender, EventArgs e)
        {
            c++;
            if (c == 5) c = 1;
            ChangePokemon();
        }
        private void left_MouseMove(object sender, MouseEventArgs e)
        {
            left.Image = Properties.Resources.select_left2;
        }

        private void left_MouseLeave(object sender, EventArgs e)
        {
            left.Image = Properties.Resources.select_left;
        }

        private void right_MouseMove(object sender, MouseEventArgs e)
        {
            right.Image = Properties.Resources.select_right2;
        }

        private void right_MouseLeave(object sender, EventArgs e)
        {
            right.Image = Properties.Resources.select_right;
        }

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (accept.Text == "Натисніть Enter, щоб підтвердити свій вибір.")
                {

                    DirectoryInfo di = new DirectoryInfo($"Pokemons/{name.Text}");

                    if (!di.Exists)
                    {
                        di.Create();

                        using (StreamWriter sw = new StreamWriter($"Pokemons/{name.Text}/{name.Text}.txt"))
                        {
                            sw.WriteLine(pokemonName);
                            sw.WriteLine("1");
                            sw.WriteLine("50");
                            sw.WriteLine("Здоровий");
                            sw.WriteLine("0");
                            sw.WriteLine("0");
                            sw.WriteLine("20");
                            sw.WriteLine("10");
                            sw.WriteLine("2");
                            sw.WriteLine("0");
                            sw.WriteLine("---");
                        }

                        using (StreamWriter sw = new StreamWriter($"Pokemons/{name.Text}/birthday.txt"))
                        {
                            sw.Write(DateTime.Now.ToShortDateString());
                        }

                        using (StreamWriter sw = new StreamWriter($"Pokemons/{name.Text}/life_duration.txt"))
                        {
                            sw.Write("0");
                        }
                        

                        PokeTamagochi pt = new PokeTamagochi();
                        pt.setName = name.Text;
                        this.Hide();
                        pt.ShowDialog();
                    }
                    else MessageBox.Show("Дане ім'я вже зайняте.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                StartForm sf = new StartForm();
                this.Hide();
                sf.ShowDialog();
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            char[] cr = name.Text.ToCharArray();
            if (cr.Length > 0)
            {
                if (cr[cr.Length - 1] == ' ')
                {
                    name.Text = "";
                    accept.ForeColor = Color.IndianRed;
                    accept.Text = "Ім'я не може бути пустим або містити пробіли.";
                }
                else
                {
                    accept.ForeColor = Color.PaleGreen;
                    accept.Text = "Натисніть Enter, щоб підтвердити свій вибір.";
                }
            }
            else
            {
                accept.ForeColor = Color.IndianRed;
                accept.Text = "Ім'я не може бути пустим або містити пробіли.";
            }
        }

        private void PokemonSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
