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
    public partial class PokeTamagochi : Form
    {
        bool evol = false;

        bool activated = true;

        int minutes = 1, seconds = 30;

        int m = 1, s = 30;

        string pok = "";

        int form = 1;

        int evoCount = 0, hppnss = 50;

        int st = 0, slp = 20, en = 10, tlt = 0;

        bool isEating = false, isSleeping = false, inToilet = false, isWalking = false;

        bool isHealing = false, isFull = false;

        bool actions = false, requests = false;

        int lifeCount = 0;

        bool blinking = false, resTimer = false;

        Timer timer1 = new Timer
        {
            Interval = 1000
        };
        public string setName
        {
            get { return name.Text; }
            set { name.Text = value; }
        }
        public PokeTamagochi()
        {
            InitializeComponent();

            pokemon.Parent = pictureBox1;
            name.Parent = pictureBox1;
            status.Parent = pictureBox1;
            happiness.Parent = pictureBox1;
            request.Parent = pictureBox1;

            satiety.Parent = pictureBox1;
            toilet.Parent = pictureBox1;
            sleep.Parent = pictureBox1;
            energy.Parent = pictureBox1;

            timer.Parent = pictureBox1;
            ignore.Parent = pictureBox1;
            satisfy.Parent = pictureBox1;

            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(OnTimerEvent);
        }

        private void PokeTamagochi_Activated(object sender, EventArgs e)
        {
            if (activated == true)
            {
                LoadAll();
                RefreshValues();
                resetTimer();

                if (hppnss <= 0) 
                    happinessChange(false);
                
                toSatisfyNeeds(true);
                lifeDuration();
                
                m = 2;
                s = 0;
            }
            activated = false;
        }

        public void lifeDuration()
        {
            using (StreamReader sr = new StreamReader($"Pokemons/{name.Text}/life_duration.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                    lifeCount = Convert.ToInt32(line);
            }
        }

        private void RefreshValues()
        {
            if(form == 1) happiness.Text = $"{hppnss}/200";
            if (form == 2) happiness.Text = $"{hppnss}/300";
            if(form == 3) happiness.Text = $"{hppnss}/...";

            satiety.Text = $"Ситість: {st}/20";
            toilet.Text = $"Туалет: {tlt}/20";
            sleep.Text = $"Сон: {slp}/20";
            energy.Text = $"Енергія: {en}/20";
        }

        private void LoadAll()
        {
            try
            {
                using (StreamReader sr = new StreamReader($"Pokemons/{name.Text}/{name.Text}.txt"))
                {
                    int c = 0;
                    string str = "";
                    while ((str = sr.ReadLine()) != null)
                    {
                        c++;
                        if (c == 1)
                            pok = str;

                        if (c == 2)
                            form = Convert.ToInt32(str);

                        if (c == 3)
                            hppnss = Convert.ToInt32(str);

                        if (c == 4)
                            status.Text = str;

                        if (c == 5)
                            st = Convert.ToInt32(str);

                        if (c == 6)
                            tlt = Convert.ToInt32(str);

                        if (c == 7)
                            slp = Convert.ToInt32(str);

                        if (c == 8)
                            en = Convert.ToInt32(str);

                        if (c == 9)
                            m = Convert.ToInt32(str);

                        if (c == 10)
                            s = Convert.ToInt32(str);

                        if (c == 11)
                            request.Text = str;
                    }
                }
                pokemon.Image = Image.FromFile($"Animations/Front/{pok}.gif");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void satisfy_MouseMove(object sender, MouseEventArgs e)
        {
            satisfy.BackColor = Color.DarkSlateGray;
        }

        private void satisfy_MouseLeave(object sender, EventArgs e)
        {
            satisfy.BackColor = Color.Transparent;
        }

        private void ignore_MouseMove(object sender, MouseEventArgs e)
        {
            ignore.BackColor = Color.DarkSlateGray;
        }

        private void ignore_MouseLeave(object sender, EventArgs e)
        {
            ignore.BackColor = Color.Transparent;
        }

        private void ignore_Click(object sender, EventArgs e)
        {
            if (status.Text == "Хворий")
                death();

            happinessChange(false);
            resetTimer();
            blinking = true;
            resTimer = false;
        }

        private void satisfyFunction(int x, string str)
        {
            request.Text = str;
            actionChange(false, "...", "...");
            if (x == 1) pokemon.Image = Image.FromFile($"Animations/Front/{pok}.gif");
            if (x == 2) pokemon.Image = Image.FromFile($"Animations/Back/{pok}.gif");
            if (x == 3) pokemon.Image = Image.FromFile($"Animations/Sleeping/{pok}.gif");
            if (x == 4) pokemon.Image = Image.FromFile($"Animations/IsHealing/{pok}.gif");
        }

        private void toSatisfyNeeds(bool x)
        {
            if (x == false)
            {
                if (request.Text == "Хочу спати!")
                {
                    isSleeping = true;
                    satisfyFunction(3, "Приємних снів...");
                    pokemon.BackgroundImage = Properties.Resources.sleeping;
                }

                if (request.Text == "Хочу в туалет!")
                {
                    inToilet = true;
                    satisfyFunction(1, "...");
                    pokemon.BackgroundImage = Properties.Resources.toilet;
                }

                if (request.Text == "Хочу гуляти!")
                {
                    isWalking = true;
                    satisfyFunction(1, "Як же тут весело! <3");
                    pokemon.BackgroundImage = Properties.Resources.walk;
                }

                if (request.Text == "Хочу їсти!")
                {
                    isEating = true;
                    satisfyFunction(2, "Як смачно! <3");
                }

                if (request.Text == "Мені погано...")
                {
                    isHealing = true;
                    satisfyFunction(4, "Мені вже трохи ліпше...");
                }
            }
            if(x == true)
            {
                if (request.Text == "Приємних снів...")
                {
                    isSleeping = true;
                    satisfyFunction(3, "Приємних снів...");
                    pokemon.BackgroundImage = Properties.Resources.sleeping;
                }

                if ( request.Text == "...")
                {
                    inToilet = true;
                    satisfyFunction(1, "...");
                    pokemon.BackgroundImage = Properties.Resources.toilet;
                }

                if (request.Text == "Як же тут весело! <3")
                {
                    isWalking = true;
                    satisfyFunction(1, "Як же тут весело! <3");
                    pokemon.BackgroundImage = Properties.Resources.walk;
                }

                if (request.Text == "Як смачно! <3")
                {
                    isEating = true;
                    satisfyFunction(2, "Як смачно! <3");
                }

                if (request.Text == "Мені вже трохи ліпше...")
                {
                    isHealing = true;
                    satisfyFunction(4, "Мені вже трохи ліпше...");
                }
            }
            resetTimer();
        }

        private void satisfy_Click(object sender, EventArgs e)
        {
            toSatisfyNeeds(false);
            resTimer = false;
        }

        private void saveAll()
        {
            timer1.Stop();

            try
            {
                FileInfo fi1 = new FileInfo($"Pokemons/{name.Text}/{name.Text}.txt");
                FileInfo fi2 = new FileInfo($"Pokemons/{name.Text}/life_duration.txt");

                if (fi1.Exists && fi2.Exists)
                {

                    using (StreamWriter sw = new StreamWriter($"Pokemons/{name.Text}/{name.Text}.txt"))
                    {
                        sw.WriteLine(pok);
                        sw.WriteLine(form);
                        sw.WriteLine(hppnss);
                        sw.WriteLine(status.Text);
                        sw.WriteLine(st);
                        sw.WriteLine(tlt);
                        sw.WriteLine(slp);
                        sw.WriteLine(en);
                        sw.WriteLine(minutes);
                        sw.WriteLine(seconds);
                        sw.WriteLine(request.Text);
                    }
                    using (StreamWriter sw = new StreamWriter($"Pokemons/{name.Text}/life_duration.txt"))
                    {
                        sw.WriteLine(lifeCount);
                    }
                }
            }
            catch (Exception) { };
        }

        private void PokeTamagochi_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveAll();
        }

        private void PokeTamagochi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PokeTamagochi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                saveAll();
                Continue cont = new Continue();
                this.Hide();
                cont.ShowDialog();
            }
        }

        private void resetTimer()
        {
            minutes = m;
            seconds = s;
            timer.Text = $"{minutes}:{seconds}";
            if(seconds < 10) timer.Text = $"{minutes}:0{seconds}";
        }

        private void happinessChange(bool x)
        {
            if (x == false && hppnss > 0) hppnss -= 10;
            if (x == true && hppnss < 300) hppnss += 10;

            if (hppnss == 0)
            {
                status.Text = "Хворий";
                pokemon.Image = Image.FromFile($"Animations/IsSick/{pok}.gif");
            }
            RefreshValues();
        }

        private void actionChange(bool x, string sat, string ign)
        {
            satisfy.Text = sat;
            ignore.Text = ign;

            if (x == false)
            {
                satisfy.Enabled = false;
                ignore.Enabled = false;
            }

            if (x == true)
            {
                satisfy.Enabled = true;
                ignore.Enabled = true;
            }
        }

        private void requestChange()
        {
            if (st == 0 || tlt == 20 || slp == 0 || en == 0)
            {
                requests = true;
            }
            else
            {
                requests = false;
            }

            if (isEating == false && isSleeping == false && inToilet == false && isWalking == false && isHealing == false)
            {
                actions = false;
            }
            else
            {
                actions = true;
            }

            if (actions == true) requests = false;
            if (requests == true) actions = false;


            if (isHealing == false && status.Text == "Хворий")
            {
                request.Text = "Мені погано...";

                actionChange(true, "Вилікувати", "Проігнорувати");
            }

            if (actions == false && status.Text == "Здоровий")
            {
                if (en == 20)
                {
                    request.Text = "Хочу гуляти!";

                    actionChange(true, "Вигуляти", "Залишитися вдома");
                }

                if (slp == 0)
                {
                    request.Text = "Хочу спати!";

                    actionChange(true, "Укласти спати", "Проігнорувати");
                }

                if (tlt == 20)
                {
                    request.Text = "Хочу в туалет!";

                    actionChange(true, "Відвести", "Проігнорувати");
                }

                if (st == 0)
                {
                    request.Text = "Хочу їсти!";

                    actionChange(true, "Погодувати", "Відмовити");
                }
            }
        }

        public void defaultValues(string str)
        {
            status.Text = "Здоровий";
            pokemon.Image = Image.FromFile($"Animations/Front/{pok}.gif");
            pokemon.BackgroundImage = Properties.Resources.room;
            happinessChange(true);
            request.Text = str;
            resetTimer();
            actions = false;
        }

        public void needsChange()
        {
            if (isHealing == true)
            {
                if(minutes == 0 && seconds == 0)
                {
                    isHealing = false;
                    defaultValues("Я одужав!");
                    hppnss += 10;

                    RefreshValues();
                }
            }

                if (isWalking == true)
                {
                    if (seconds % 10 == 0)
                    {
                        en -= 1;

                    RefreshValues();
                }

                    if (minutes == 0 && seconds == 0)
                    {
                        isWalking = false;
                        defaultValues("Дякую за прогулянку!");
                    }
                }

                if (isEating == true)
                {
                    if (seconds % 6 == 0)
                    {
                    st += 1;
                    
                    if (seconds % 12 == 0 && en < 20) en += 1;

                    RefreshValues();
                    }

                    if (minutes == 0 && seconds == 0)
                    {
                        isEating = false;
                        defaultValues("Дякую за їжу!");
                        isFull = true;
                    }
                }
            
            if (isSleeping == true)
            {
                if (seconds % 6 == 0)
                {
                    slp += 1;

                    if (seconds % 12 == 0 && en < 20) en += 1;

                    RefreshValues();
                }

                    if (minutes == 0 && seconds == 0)
                    {
                        isSleeping = false;
                        defaultValues("Я виспався!");
                    }
            }

                if (isEating == false && inToilet == false && tlt < 20 && isFull == true)
                {
                    if (seconds % 6 == 0) tlt += 1;
                    RefreshValues();
                }

                if (isSleeping == false && slp <= 20 && slp > 0)
                {
                    if (seconds == 0) slp -= 1;
                    RefreshValues();
                }

                if (isEating == false && st <= 20 && st > 0)
                {
                    if (seconds % 18 == 0) st -= 1;
                    RefreshValues();
                }

                if (inToilet == true)
                {
                    if (seconds % 6 == 0)
                    {
                        tlt -= 1;
                        RefreshValues();
                    }

                    if (minutes == 0 && seconds == 0)
                    {
                        inToilet = false;
                        defaultValues("Я все!");
                        isFull = false;
                    }
                }
        }
        private void evolution()
        {
            if (hppnss == 200 && form == 1)
            {
                form = 2;

                pokemon.Image = Image.FromFile($"Animations/Evolutions/{pok}_evo.gif");

                if (pok == "bulbasaur") pok = "ivysaur";
                if (pok == "charmander") pok = "charmeleon";
                if (pok == "squirtle") pok = "wartortle";
                if (pok == "pichu") pok = "pikachu";

                hppnss = 20;

                evol = true;
            }

            if (hppnss == 300 && form == 2)
            {
                form = 3;

                pokemon.Image = Image.FromFile($"Animations/Evolutions/{pok}_evo.gif");

                if (pok == "ivysaur") pok = "venusaur";
                if (pok == "charmeleon") pok = "charizard";
                if (pok == "wartortle") pok = "blastoise";
                if (pok == "pikachu") pok = "raichu";

                hppnss = 30;

                evol = true;
            }
 

            if (evol == true)
            {
                evoCount++;
            }

            if(evoCount == 6)
            {
                pokemon.Image = Image.FromFile($"Animations/Front/{pok}.gif");
                resetTimer();
                evol = false;
                evoCount = 0;
            }
        }
        private void timerTick()
        {
            if (minutes != 0 || seconds != 0) seconds--;

            if (seconds == -1) seconds = 59;

            if (seconds == 59 && minutes != 0) minutes -= 1;

            timer.Text = $"{minutes}:{seconds}";

            if (seconds < 10) timer.Text = $"{minutes}:0{seconds}";
        }
        private void death()
        {
            timer1.Stop();
            Death d = new Death();
            d.PokemonsName = name.Text;
            d.Pokemon = pok;
            d.Status = status.Text;
            this.Hide();
            d.ShowDialog();
        }
        private void textBlinking()
        {
            if(minutes == 1 && blinking == true)
            {
                if (seconds == 59) request.ForeColor = Color.Red;
                if (seconds == 58) request.ForeColor = Color.White;
                if (seconds == 57) request.ForeColor = Color.Red;
                if (seconds == 56) request.ForeColor = Color.White;
                if (seconds == 55) request.ForeColor = Color.Red;
                if (seconds == 54)
                {
                    request.ForeColor = Color.White;
                    blinking = false;
                }
            }
        }
        private void OnTimerEvent(object sender, EventArgs e)
        {
            lifeCount++;

            if ((status.Text == "Хворий" && minutes == 0 && seconds == 1 && isHealing == false) || (lifeCount == 432000))
            {
                death();
            }

            requestChange();

            timerTick();

            needsChange();

            evolution();

            if (seconds == 0 && minutes == 0 && requests == true)
            {
                blinking = true;
                happinessChange(false);
                resetTimer();
                resTimer = false;
            }

            textBlinking();

            if (seconds == 0 && minutes == 0 && requests == false)
            {
                resetTimer();
                resTimer = false;
            }

            if (actions == false && requests == true && resTimer == false)
            {
                resetTimer();
                resTimer = true;
            }
        }
    }
}
