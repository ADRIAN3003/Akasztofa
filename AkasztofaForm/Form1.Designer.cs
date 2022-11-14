
namespace AkasztofaForm
{
    partial class frmFo
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
            this.btnKilepes = new System.Windows.Forms.Button();
            this.pbKepek = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbKepek)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(977, 581);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(88, 33);
            this.btnKilepes.TabIndex = 0;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // pbKepek
            // 
            this.pbKepek.Image = global::AkasztofaForm.Properties.Resources.kep0;
            this.pbKepek.Location = new System.Drawing.Point(265, 59);
            this.pbKepek.Name = "pbKepek";
            this.pbKepek.Size = new System.Drawing.Size(547, 377);
            this.pbKepek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKepek.TabIndex = 1;
            this.pbKepek.TabStop = false;
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 626);
            this.ControlBox = false;
            this.Controls.Add(this.pbKepek);
            this.Controls.Add(this.btnKilepes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Játék";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFo_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbKepek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.PictureBox pbKepek;
    }
}

