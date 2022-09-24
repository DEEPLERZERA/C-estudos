namespace JokenPo
{
    partial class cenario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cenario));
            this.pctPedra = new System.Windows.Forms.PictureBox();
            this.pctPapel = new System.Windows.Forms.PictureBox();
            this.pctTesoura = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pctTesouracomp = new System.Windows.Forms.PictureBox();
            this.pctPapelcomp = new System.Windows.Forms.PictureBox();
            this.pctPedracomp = new System.Windows.Forms.PictureBox();
            this.pcwins = new System.Windows.Forms.Label();
            this.userwins = new System.Windows.Forms.Label();
            this.empate = new System.Windows.Forms.Label();
            this.textPontosPlayerCe = new System.Windows.Forms.TextBox();
            this.textPontosCompCe = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textPontosEmpateCe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPedra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTesoura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTesouracomp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPapelcomp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPedracomp)).BeginInit();
            this.SuspendLayout();
            // 
            // pctPedra
            // 
            this.pctPedra.Image = ((System.Drawing.Image)(resources.GetObject("pctPedra.Image")));
            this.pctPedra.Location = new System.Drawing.Point(70, 84);
            this.pctPedra.Name = "pctPedra";
            this.pctPedra.Size = new System.Drawing.Size(256, 225);
            this.pctPedra.TabIndex = 0;
            this.pctPedra.TabStop = false;
            this.pctPedra.Visible = false;
            // 
            // pctPapel
            // 
            this.pctPapel.Image = ((System.Drawing.Image)(resources.GetObject("pctPapel.Image")));
            this.pctPapel.Location = new System.Drawing.Point(70, 85);
            this.pctPapel.Name = "pctPapel";
            this.pctPapel.Size = new System.Drawing.Size(262, 226);
            this.pctPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctPapel.TabIndex = 1;
            this.pctPapel.TabStop = false;
            this.pctPapel.Visible = false;
            // 
            // pctTesoura
            // 
            this.pctTesoura.Image = ((System.Drawing.Image)(resources.GetObject("pctTesoura.Image")));
            this.pctTesoura.Location = new System.Drawing.Point(70, 83);
            this.pctTesoura.Name = "pctTesoura";
            this.pctTesoura.Size = new System.Drawing.Size(262, 226);
            this.pctTesoura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctTesoura.TabIndex = 2;
            this.pctTesoura.TabStop = false;
            this.pctTesoura.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1132, 545);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 113);
            this.button2.TabIndex = 5;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pctTesouracomp
            // 
            this.pctTesouracomp.Image = ((System.Drawing.Image)(resources.GetObject("pctTesouracomp.Image")));
            this.pctTesouracomp.Location = new System.Drawing.Point(1002, 83);
            this.pctTesouracomp.Name = "pctTesouracomp";
            this.pctTesouracomp.Size = new System.Drawing.Size(262, 226);
            this.pctTesouracomp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctTesouracomp.TabIndex = 7;
            this.pctTesouracomp.TabStop = false;
            this.pctTesouracomp.Visible = false;
            // 
            // pctPapelcomp
            // 
            this.pctPapelcomp.Image = ((System.Drawing.Image)(resources.GetObject("pctPapelcomp.Image")));
            this.pctPapelcomp.Location = new System.Drawing.Point(1002, 84);
            this.pctPapelcomp.Name = "pctPapelcomp";
            this.pctPapelcomp.Size = new System.Drawing.Size(262, 226);
            this.pctPapelcomp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctPapelcomp.TabIndex = 8;
            this.pctPapelcomp.TabStop = false;
            this.pctPapelcomp.Visible = false;
            this.pctPapelcomp.Click += new System.EventHandler(this.pctPapelcomp_Click);
            // 
            // pctPedracomp
            // 
            this.pctPedracomp.Image = ((System.Drawing.Image)(resources.GetObject("pctPedracomp.Image")));
            this.pctPedracomp.Location = new System.Drawing.Point(1002, 86);
            this.pctPedracomp.Name = "pctPedracomp";
            this.pctPedracomp.Size = new System.Drawing.Size(256, 225);
            this.pctPedracomp.TabIndex = 9;
            this.pctPedracomp.TabStop = false;
            this.pctPedracomp.Visible = false;
            // 
            // pcwins
            // 
            this.pcwins.AutoSize = true;
            this.pcwins.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pcwins.Location = new System.Drawing.Point(582, 158);
            this.pcwins.Name = "pcwins";
            this.pcwins.Size = new System.Drawing.Size(157, 29);
            this.pcwins.TabIndex = 10;
            this.pcwins.Text = "PC VENCEU!";
            this.pcwins.Visible = false;
            // 
            // userwins
            // 
            this.userwins.AutoSize = true;
            this.userwins.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userwins.Location = new System.Drawing.Point(571, 158);
            this.userwins.Name = "userwins";
            this.userwins.Size = new System.Drawing.Size(191, 29);
            this.userwins.TabIndex = 11;
            this.userwins.Text = "VOCÊ VENCEU!";
            this.userwins.Visible = false;
            // 
            // empate
            // 
            this.empate.AutoSize = true;
            this.empate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empate.Location = new System.Drawing.Point(603, 158);
            this.empate.Name = "empate";
            this.empate.Size = new System.Drawing.Size(112, 29);
            this.empate.TabIndex = 12;
            this.empate.Text = "EMPATE";
            this.empate.Visible = false;
            this.empate.Click += new System.EventHandler(this.empate_Click);
            // 
            // textPontosPlayerCe
            // 
            this.textPontosPlayerCe.Location = new System.Drawing.Point(200, 514);
            this.textPontosPlayerCe.Multiline = true;
            this.textPontosPlayerCe.Name = "textPontosPlayerCe";
            this.textPontosPlayerCe.Size = new System.Drawing.Size(100, 23);
            this.textPontosPlayerCe.TabIndex = 13;
            this.textPontosPlayerCe.Visible = false;
            this.textPontosPlayerCe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textPontosCompCe
            // 
            this.textPontosCompCe.Location = new System.Drawing.Point(354, 514);
            this.textPontosCompCe.Name = "textPontosCompCe";
            this.textPontosCompCe.Size = new System.Drawing.Size(100, 23);
            this.textPontosCompCe.TabIndex = 14;
            this.textPontosCompCe.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(707, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 95);
            this.button1.TabIndex = 16;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textPontosEmpateCe
            // 
            this.textPontosEmpateCe.Location = new System.Drawing.Point(541, 514);
            this.textPontosEmpateCe.Name = "textPontosEmpateCe";
            this.textPontosEmpateCe.Size = new System.Drawing.Size(100, 23);
            this.textPontosEmpateCe.TabIndex = 15;
            this.textPontosEmpateCe.Visible = false;
            // 
            // cenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 670);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPontosEmpateCe);
            this.Controls.Add(this.textPontosCompCe);
            this.Controls.Add(this.textPontosPlayerCe);
            this.Controls.Add(this.empate);
            this.Controls.Add(this.userwins);
            this.Controls.Add(this.pcwins);
            this.Controls.Add(this.pctPedracomp);
            this.Controls.Add(this.pctPapelcomp);
            this.Controls.Add(this.pctTesouracomp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pctTesoura);
            this.Controls.Add(this.pctPapel);
            this.Controls.Add(this.pctPedra);
            this.Name = "cenario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cenario";
            ((System.ComponentModel.ISupportInitialize)(this.pctPedra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTesoura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTesouracomp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPapelcomp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPedracomp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public PictureBox pctPedra;
        public PictureBox pctPapel;
        public PictureBox pctTesoura;
        private Button button2;
        public PictureBox pctTesouracomp;
        public PictureBox pctPapelcomp;
        public PictureBox pctPedracomp;
        public Label pcwins;
        public Label userwins;
        public Label empate;
        private Button button1;
        public TextBox textPontosEmpateCe;
        public TextBox textPontosPlayerCe;
        public TextBox textPontosCompCe;
    }
}