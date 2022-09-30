namespace JokenPo
{
    partial class Forms1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdoPedra = new System.Windows.Forms.RadioButton();
            this.rdoPapel = new System.Windows.Forms.RadioButton();
            this.rdoTesoura = new System.Windows.Forms.RadioButton();
            this.btnJogar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textPontoEnemy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textPontoPlayer = new System.Windows.Forms.TextBox();
            this.textPontoEmpate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdoPedra
            // 
            this.rdoPedra.AutoSize = true;
            this.rdoPedra.Font = new System.Drawing.Font("Segoe UI Historic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rdoPedra.Location = new System.Drawing.Point(202, 137);
            this.rdoPedra.Name = "rdoPedra";
            this.rdoPedra.Size = new System.Drawing.Size(108, 41);
            this.rdoPedra.TabIndex = 0;
            this.rdoPedra.TabStop = true;
            this.rdoPedra.Text = "Pedra";
            this.rdoPedra.UseVisualStyleBackColor = true;
            // 
            // rdoPapel
            // 
            this.rdoPapel.AutoSize = true;
            this.rdoPapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoPapel.Location = new System.Drawing.Point(202, 245);
            this.rdoPapel.Name = "rdoPapel";
            this.rdoPapel.Size = new System.Drawing.Size(99, 33);
            this.rdoPapel.TabIndex = 1;
            this.rdoPapel.TabStop = true;
            this.rdoPapel.Text = "Papel";
            this.rdoPapel.UseVisualStyleBackColor = true;
            // 
            // rdoTesoura
            // 
            this.rdoTesoura.AutoSize = true;
            this.rdoTesoura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoTesoura.Location = new System.Drawing.Point(202, 373);
            this.rdoTesoura.Name = "rdoTesoura";
            this.rdoTesoura.Size = new System.Drawing.Size(77, 19);
            this.rdoTesoura.TabIndex = 2;
            this.rdoTesoura.TabStop = true;
            this.rdoTesoura.Text = "Tesoura";
            this.rdoTesoura.UseVisualStyleBackColor = true;
            // 
            // btnJogar
            // 
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJogar.Location = new System.Drawing.Point(1081, 204);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(229, 117);
            this.btnJogar.TabIndex = 3;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1081, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 113);
            this.button2.TabIndex = 4;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1081, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 117);
            this.button1.TabIndex = 5;
            this.button1.Text = "Creditos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(376, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "PONTUAÇÃOEnemy";
            // 
            // textPontoEnemy
            // 
            this.textPontoEnemy.Location = new System.Drawing.Point(414, 559);
            this.textPontoEnemy.Multiline = true;
            this.textPontoEnemy.Name = "textPontoEnemy";
            this.textPontoEnemy.Size = new System.Drawing.Size(143, 58);
            this.textPontoEnemy.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "PONTUAÇÃOPlayer";
            // 
            // textPontoPlayer
            // 
            this.textPontoPlayer.Location = new System.Drawing.Point(42, 559);
            this.textPontoPlayer.Multiline = true;
            this.textPontoPlayer.Name = "textPontoPlayer";
            this.textPontoPlayer.Size = new System.Drawing.Size(143, 58);
            this.textPontoPlayer.TabIndex = 17;
            // 
            // textPontoEmpate
            // 
            this.textPontoEmpate.Location = new System.Drawing.Point(773, 559);
            this.textPontoEmpate.Multiline = true;
            this.textPontoEmpate.Name = "textPontoEmpate";
            this.textPontoEmpate.Size = new System.Drawing.Size(143, 58);
            this.textPontoEmpate.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(746, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "PONTUAÇÃOEmpate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "label4";
            // 
            // Forms1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 694);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPontoEmpate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPontoEnemy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPontoPlayer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.rdoTesoura);
            this.Controls.Add(this.rdoPapel);
            this.Controls.Add(this.rdoPedra);
            this.Name = "Forms1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JokenPo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdoPedra;
        private RadioButton rdoPapel;
        private RadioButton rdoTesoura;
        private Button btnJogar;
        private Button button2;
        private Button button1;
        private Label label2;
        public TextBox textPontoEnemy;
        private Label label1;
        public TextBox textPontoPlayer;
        public TextBox textPontoEmpate;
        private Label label3;
        private Label label4;
    }
}