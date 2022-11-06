namespace PokeTamagochi
{
    partial class Continue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Continue));
            this.pokemons = new System.Windows.Forms.ListBox();
            this.pet = new System.Windows.Forms.PictureBox();
            this.ready = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ready)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pokemons
            // 
            this.pokemons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pokemons.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pokemons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pokemons.FormattingEnabled = true;
            this.pokemons.ItemHeight = 20;
            this.pokemons.Location = new System.Drawing.Point(65, 181);
            this.pokemons.Name = "pokemons";
            this.pokemons.Size = new System.Drawing.Size(195, 100);
            this.pokemons.TabIndex = 2;
            this.pokemons.SelectedIndexChanged += new System.EventHandler(this.pokemons_SelectedIndexChanged);
            this.pokemons.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pokemons_KeyDown);
            // 
            // pet
            // 
            this.pet.BackColor = System.Drawing.Color.Transparent;
            this.pet.Location = new System.Drawing.Point(51, 307);
            this.pet.Name = "pet";
            this.pet.Size = new System.Drawing.Size(223, 89);
            this.pet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pet.TabIndex = 3;
            this.pet.TabStop = false;
            // 
            // ready
            // 
            this.ready.BackColor = System.Drawing.Color.Transparent;
            this.ready.Image = global::PokeTamagochi.Properties.Resources.ready;
            this.ready.Location = new System.Drawing.Point(93, 414);
            this.ready.Name = "ready";
            this.ready.Size = new System.Drawing.Size(142, 55);
            this.ready.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ready.TabIndex = 1;
            this.ready.TabStop = false;
            this.ready.Click += new System.EventHandler(this.ready_Click);
            this.ready.MouseLeave += new System.EventHandler(this.ready_MouseLeave);
            this.ready.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ready_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PokeTamagochi.Properties.Resources._continue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 490);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Continue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 490);
            this.Controls.Add(this.pet);
            this.Controls.Add(this.pokemons);
            this.Controls.Add(this.ready);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(343, 529);
            this.MinimumSize = new System.Drawing.Size(343, 529);
            this.Name = "Continue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokeTamagotchi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Continue_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Continue_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ready)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ready;
        private System.Windows.Forms.ListBox pokemons;
        private System.Windows.Forms.PictureBox pet;
    }
}