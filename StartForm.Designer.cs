namespace PokeTamagochi
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.continue_ = new System.Windows.Forms.PictureBox();
            this.newGame = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.continue_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // continue_
            // 
            this.continue_.BackColor = System.Drawing.Color.Transparent;
            this.continue_.Image = global::PokeTamagochi.Properties.Resources.cntn;
            this.continue_.Location = new System.Drawing.Point(32, 269);
            this.continue_.Name = "continue_";
            this.continue_.Size = new System.Drawing.Size(254, 88);
            this.continue_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.continue_.TabIndex = 2;
            this.continue_.TabStop = false;
            this.continue_.Click += new System.EventHandler(this.continue__Click);
            this.continue_.MouseLeave += new System.EventHandler(this.continue__MouseLeave);
            this.continue_.MouseMove += new System.Windows.Forms.MouseEventHandler(this.continue__MouseMove);
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.Color.Transparent;
            this.newGame.Image = global::PokeTamagochi.Properties.Resources.newgame;
            this.newGame.Location = new System.Drawing.Point(32, 177);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(254, 88);
            this.newGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.newGame.TabIndex = 1;
            this.newGame.TabStop = false;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            this.newGame.MouseLeave += new System.EventHandler(this.newGame_MouseLeave);
            this.newGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.newGame_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PokeTamagochi.Properties.Resources.startform21;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 420);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 420);
            this.Controls.Add(this.continue_);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(335, 459);
            this.MinimumSize = new System.Drawing.Size(335, 459);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokeTamagotchi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.continue_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox newGame;
        private System.Windows.Forms.PictureBox continue_;
    }
}

