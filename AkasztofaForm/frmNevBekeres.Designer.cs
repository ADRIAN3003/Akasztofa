
namespace AkasztofaForm
{
    partial class frmUjJatek
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKezdes = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.rbKonnyu = new System.Windows.Forms.RadioButton();
            this.rbNehez = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(69, 31);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(158, 26);
            this.tbNev.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNehez);
            this.groupBox1.Controls.Add(this.rbKonnyu);
            this.groupBox1.Location = new System.Drawing.Point(27, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nehézség";
            // 
            // btnKezdes
            // 
            this.btnKezdes.BackColor = System.Drawing.Color.PaleGreen;
            this.btnKezdes.FlatAppearance.BorderSize = 0;
            this.btnKezdes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKezdes.Location = new System.Drawing.Point(27, 160);
            this.btnKezdes.Name = "btnKezdes";
            this.btnKezdes.Size = new System.Drawing.Size(90, 33);
            this.btnKezdes.TabIndex = 3;
            this.btnKezdes.Text = "Kezdés";
            this.btnKezdes.UseVisualStyleBackColor = false;
            this.btnKezdes.Click += new System.EventHandler(this.btnKezdes_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.BackColor = System.Drawing.Color.Red;
            this.btnKilepes.FlatAppearance.BorderSize = 0;
            this.btnKilepes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKilepes.Location = new System.Drawing.Point(137, 160);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(90, 33);
            this.btnKilepes.TabIndex = 3;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = false;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // rbKonnyu
            // 
            this.rbKonnyu.AutoSize = true;
            this.rbKonnyu.Location = new System.Drawing.Point(7, 26);
            this.rbKonnyu.Name = "rbKonnyu";
            this.rbKonnyu.Size = new System.Drawing.Size(80, 24);
            this.rbKonnyu.TabIndex = 0;
            this.rbKonnyu.TabStop = true;
            this.rbKonnyu.Text = "Könnyű";
            this.rbKonnyu.UseVisualStyleBackColor = true;
            // 
            // rbNehez
            // 
            this.rbNehez.AutoSize = true;
            this.rbNehez.Location = new System.Drawing.Point(110, 26);
            this.rbNehez.Name = "rbNehez";
            this.rbNehez.Size = new System.Drawing.Size(73, 24);
            this.rbNehez.TabIndex = 0;
            this.rbNehez.TabStop = true;
            this.rbNehez.Text = "Nehéz";
            this.rbNehez.UseVisualStyleBackColor = true;
            // 
            // frmUjJatek
            // 
            this.AcceptButton = this.btnKezdes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.CancelButton = this.btnKilepes;
            this.ClientSize = new System.Drawing.Size(255, 215);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnKezdes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUjJatek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Új játék";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNehez;
        private System.Windows.Forms.RadioButton rbKonnyu;
        private System.Windows.Forms.Button btnKezdes;
        private System.Windows.Forms.Button btnKilepes;
    }
}