namespace Mecanica
{
    partial class FormularioCadastroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCadastroClientes));
            this.topImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.topImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // topImagem
            // 
            this.topImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topImagem.Image = ((System.Drawing.Image)(resources.GetObject("topImagem.Image")));
            this.topImagem.InitialImage = null;
            this.topImagem.Location = new System.Drawing.Point(0, 0);
            this.topImagem.Name = "topImagem";
            this.topImagem.Size = new System.Drawing.Size(433, 160);
            this.topImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topImagem.TabIndex = 15;
            this.topImagem.TabStop = false;
            // 
            // FormularioCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 469);
            this.Controls.Add(this.topImagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormularioCadastroClientes";
            this.Text = "FormularioCadastroCliente";
            ((System.ComponentModel.ISupportInitialize)(this.topImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox topImagem;
    }
}