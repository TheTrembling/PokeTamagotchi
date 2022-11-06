namespace PokeTamagochi
{
    partial class Death
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Death));
            this.status = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.pokemon = new System.Windows.Forms.PictureBox();
            this.next = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.Location = new System.Drawing.Point(12, 27);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(331, 36);
            this.status.TabIndex = 1;
            this.status.Text = "Ваш покемон помер від старості.";
            this.status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(89, 332);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(171, 32);
            this.name.TabIndex = 3;
            this.name.Text = "Бульбазавр";
            this.name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(67, 377);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(220, 27);
            this.date.TabIndex = 4;
            this.date.Text = "08.08.2022 - 11.08.2022";
            this.date.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pokemon
            // 
            this.pokemon.BackColor = System.Drawing.Color.Transparent;
            this.pokemon.Location = new System.Drawing.Point(90, 195);
            this.pokemon.Name = "pokemon";
            this.pokemon.Size = new System.Drawing.Size(171, 134);
            this.pokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pokemon.TabIndex = 5;
            this.pokemon.TabStop = false;
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.Image = global::PokeTamagochi.Properties.Resources.nexbutton;
            this.next.Location = new System.Drawing.Point(87, 416);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(171, 78);
            this.next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.next.TabIndex = 2;
            this.next.TabStop = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            this.next.MouseLeave += new System.EventHandler(this.next_MouseLeave);
            this.next.MouseMove += new System.Windows.Forms.MouseEventHandler(this.next_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PokeTamagochi.Properties.Resources.tombstone2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 504);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Death
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 504);
            this.Controls.Add(this.pokemon);
            this.Controls.Add(this.date);
            this.Controls.Add(this.name);
            this.Controls.Add(this.next);
            this.Controls.Add(this.status);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(370, 543);
            this.MinimumSize = new System.Drawing.Size(370, 543);
            this.Name = "Death";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokeTamagotchi";
            this.Activated += new System.EventHandler(this.Death_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Death_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Death_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.PictureBox next;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.PictureBox pokemon;
    }
}