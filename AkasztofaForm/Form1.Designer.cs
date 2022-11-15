
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
            this.lblEddigKitalalt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTipp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVoltak = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbKepek)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(977, 605);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(88, 33);
            this.btnKilepes.TabIndex = 1;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // pbKepek
            // 
            this.pbKepek.Image = global::AkasztofaForm.Properties.Resources.kep0;
            this.pbKepek.Location = new System.Drawing.Point(265, 79);
            this.pbKepek.Name = "pbKepek";
            this.pbKepek.Size = new System.Drawing.Size(547, 377);
            this.pbKepek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKepek.TabIndex = 1;
            this.pbKepek.TabStop = false;
            // 
            // lblEddigKitalalt
            // 
            this.lblEddigKitalalt.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEddigKitalalt.Location = new System.Drawing.Point(181, 459);
            this.lblEddigKitalalt.Name = "lblEddigKitalalt";
            this.lblEddigKitalalt.Size = new System.Drawing.Size(712, 79);
            this.lblEddigKitalalt.TabIndex = 3;
            this.lblEddigKitalalt.Text = "label1";
            this.lblEddigKitalalt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipp";
            // 
            // tbTipp
            // 
            this.tbTipp.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTipp.Location = new System.Drawing.Point(572, 6);
            this.tbTipp.Name = "tbTipp";
            this.tbTipp.Size = new System.Drawing.Size(67, 64);
            this.tbTipp.TabIndex = 0;
            this.tbTipp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTipp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTipp_KeyDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(194, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(712, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ezek a betűk voltak:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVoltak
            // 
            this.lblVoltak.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVoltak.Location = new System.Drawing.Point(194, 586);
            this.lblVoltak.Name = "lblVoltak";
            this.lblVoltak.Size = new System.Drawing.Size(712, 55);
            this.lblVoltak.TabIndex = 5;
            this.lblVoltak.Text = "label3";
            this.lblVoltak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 650);
            this.ControlBox = false;
            this.Controls.Add(this.tbTipp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVoltak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEddigKitalalt);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.PictureBox pbKepek;
        private System.Windows.Forms.Label lblEddigKitalalt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTipp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVoltak;
    }
}

