namespace Jokenpo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jTesoura = new System.Windows.Forms.PictureBox();
            this.jPapel = new System.Windows.Forms.PictureBox();
            this.jPedra = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cTesoura = new System.Windows.Forms.PictureBox();
            this.cPapel = new System.Windows.Forms.PictureBox();
            this.cPedra = new System.Windows.Forms.PictureBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.verifyTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jTesoura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jPedra)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTesoura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPedra)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Jokenpo.Properties.Resources.jokenpo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jTesoura);
            this.groupBox1.Controls.Add(this.jPapel);
            this.groupBox1.Controls.Add(this.jPedra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jogador";
            // 
            // jTesoura
            // 
            this.jTesoura.Enabled = false;
            this.jTesoura.Image = global::Jokenpo.Properties.Resources.tesoura;
            this.jTesoura.Location = new System.Drawing.Point(287, 28);
            this.jTesoura.Name = "jTesoura";
            this.jTesoura.Size = new System.Drawing.Size(90, 77);
            this.jTesoura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jTesoura.TabIndex = 2;
            this.jTesoura.TabStop = false;
            this.jTesoura.Click += new System.EventHandler(this.jTesoura_Click);
            // 
            // jPapel
            // 
            this.jPapel.Enabled = false;
            this.jPapel.Image = global::Jokenpo.Properties.Resources.papel;
            this.jPapel.Location = new System.Drawing.Point(156, 27);
            this.jPapel.Name = "jPapel";
            this.jPapel.Size = new System.Drawing.Size(90, 77);
            this.jPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jPapel.TabIndex = 1;
            this.jPapel.TabStop = false;
            this.jPapel.Click += new System.EventHandler(this.jPapel_Click);
            // 
            // jPedra
            // 
            this.jPedra.Enabled = false;
            this.jPedra.Image = global::Jokenpo.Properties.Resources.pedra;
            this.jPedra.Location = new System.Drawing.Point(25, 28);
            this.jPedra.Name = "jPedra";
            this.jPedra.Size = new System.Drawing.Size(90, 77);
            this.jPedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jPedra.TabIndex = 0;
            this.jPedra.TabStop = false;
            this.jPedra.Click += new System.EventHandler(this.jPedra_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cTesoura);
            this.groupBox2.Controls.Add(this.cPapel);
            this.groupBox2.Controls.Add(this.cPedra);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 130);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Computador";
            // 
            // cTesoura
            // 
            this.cTesoura.Image = global::Jokenpo.Properties.Resources.tesoura;
            this.cTesoura.Location = new System.Drawing.Point(286, 28);
            this.cTesoura.Name = "cTesoura";
            this.cTesoura.Size = new System.Drawing.Size(90, 77);
            this.cTesoura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cTesoura.TabIndex = 5;
            this.cTesoura.TabStop = false;
            this.cTesoura.Visible = false;
            // 
            // cPapel
            // 
            this.cPapel.Image = global::Jokenpo.Properties.Resources.papel;
            this.cPapel.Location = new System.Drawing.Point(155, 27);
            this.cPapel.Name = "cPapel";
            this.cPapel.Size = new System.Drawing.Size(90, 77);
            this.cPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cPapel.TabIndex = 4;
            this.cPapel.TabStop = false;
            this.cPapel.Visible = false;
            // 
            // cPedra
            // 
            this.cPedra.Image = global::Jokenpo.Properties.Resources.pedra;
            this.cPedra.Location = new System.Drawing.Point(24, 28);
            this.cPedra.Name = "cPedra";
            this.cPedra.Size = new System.Drawing.Size(90, 77);
            this.cPedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cPedra.TabIndex = 3;
            this.cPedra.TabStop = false;
            this.cPedra.Visible = false;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(127, 411);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(73, 20);
            this.lblTempo.TabIndex = 3;
            this.lblTempo.Text = "Tempo: ";
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoJogo.Location = new System.Drawing.Point(12, 403);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(106, 36);
            this.btnNovoJogo.TabIndex = 4;
            this.btnNovoJogo.Text = "Novo Jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = true;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(271, 403);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 36);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // verifyTimer
            // 
            this.verifyTimer.Tick += new System.EventHandler(this.verifyTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jokenpo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jTesoura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jPedra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTesoura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPedra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox jPapel;
        private System.Windows.Forms.PictureBox jPedra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Button btnNovoJogo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox jTesoura;
        private System.Windows.Forms.PictureBox cTesoura;
        private System.Windows.Forms.PictureBox cPapel;
        private System.Windows.Forms.PictureBox cPedra;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer verifyTimer;
    }
}

