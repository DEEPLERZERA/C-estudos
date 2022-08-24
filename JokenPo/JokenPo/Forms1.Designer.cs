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
            this.rdoPapel.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoPapel.Location = new System.Drawing.Point(202, 245);
            this.rdoPapel.Name = "rdoPapel";
            this.rdoPapel.Size = new System.Drawing.Size(109, 34);
            this.rdoPapel.TabIndex = 1;
            this.rdoPapel.TabStop = true;
            this.rdoPapel.Text = "Papel";
            this.rdoPapel.UseVisualStyleBackColor = true;
            // 
            // rdoTesoura
            // 
            this.rdoTesoura.AutoSize = true;
            this.rdoTesoura.Font = new System.Drawing.Font("RomanT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoTesoura.Location = new System.Drawing.Point(202, 373);
            this.rdoTesoura.Name = "rdoTesoura";
            this.rdoTesoura.Size = new System.Drawing.Size(92, 22);
            this.rdoTesoura.TabIndex = 2;
            this.rdoTesoura.TabStop = true;
            this.rdoTesoura.Text = "Tesoura";
            this.rdoTesoura.UseVisualStyleBackColor = true;
            // 
            // btnJogar
            // 
            this.btnJogar.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJogar.Location = new System.Drawing.Point(880, 204);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(229, 117);
            this.btnJogar.TabIndex = 3;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // Forms1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 694);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.rdoTesoura);
            this.Controls.Add(this.rdoPapel);
            this.Controls.Add(this.rdoPedra);
            this.Name = "Forms1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdoPedra;
        private RadioButton rdoPapel;
        private RadioButton rdoTesoura;
        private Button btnJogar;
    }
}