namespace PokeTamagochi
{
    partial class PokemonSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokemonSelection));
            this.name = new System.Windows.Forms.TextBox();
            this.accept = new System.Windows.Forms.Label();
            this.pokemon = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.PictureBox();
            this.left = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Black;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.Firebrick;
            this.name.Location = new System.Drawing.Point(39, 419);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(245, 27);
            this.name.TabIndex = 4;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            this.name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_KeyDown);
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.Color.Transparent;
            this.accept.ForeColor = System.Drawing.Color.IndianRed;
            this.accept.Location = new System.Drawing.Point(12, 458);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(303, 23);
            this.accept.TabIndex = 5;
            this.accept.Text = "Ім\'я не може бути пустим або містити пробіли.";
            this.accept.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pokemon
            // 
            this.pokemon.BackColor = System.Drawing.Color.Transparent;
            this.pokemon.Location = new System.Drawing.Point(100, 189);
            this.pokemon.Name = "pokemon";
            this.pokemon.Size = new System.Drawing.Size(128, 95);
            this.pokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pokemon.TabIndex = 3;
            this.pokemon.TabStop = false;
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.Transparent;
            this.right.Image = global::PokeTamagochi.Properties.Resources.select_right;
            this.right.Location = new System.Drawing.Point(253, 198);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(76, 77);
            this.right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.right.TabIndex = 2;
            this.right.TabStop = false;
            this.right.Click += new System.EventHandler(this.right_Click);
            this.right.MouseLeave += new System.EventHandler(this.right_MouseLeave);
            this.right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.right_MouseMove);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.Transparent;
            this.left.Image = global::PokeTamagochi.Properties.Resources.select_left;
            this.left.Location = new System.Drawing.Point(6, 198);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(76, 77);
            this.left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.left.TabIndex = 1;
            this.left.TabStop = false;
            this.left.Click += new System.EventHandler(this.left_Click);
            this.left.MouseLeave += new System.EventHandler(this.left_MouseLeave);
            this.left.MouseMove += new System.Windows.Forms.MouseEventHandler(this.left_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PokeTamagochi.Properties.Resources.choose_your_pokemon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 490);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PokemonSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 490);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pokemon);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(343, 529);
            this.MinimumSize = new System.Drawing.Size(343, 529);
            this.Name = "PokemonSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokeTamagotchi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PokemonSelection_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox left;
        private System.Windows.Forms.PictureBox right;
        private System.Windows.Forms.PictureBox pokemon;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label accept;
    }
}