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
            ((System.ComponentModel.ISupportInitialize)(this.pctPedra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTesoura)).BeginInit();
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
            this.pctPapel.Location = new System.Drawing.Point(70, 83);
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
            // cenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 670);
            this.Controls.Add(this.pctTesoura);
            this.Controls.Add(this.pctPapel);
            this.Controls.Add(this.pctPedra);
            this.Name = "cenario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cenario";
            ((System.ComponentModel.ISupportInitialize)(this.pctPedra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTesoura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public PictureBox pctPedra;
        public PictureBox pctPapel;
        public PictureBox pctTesoura;
    }
}