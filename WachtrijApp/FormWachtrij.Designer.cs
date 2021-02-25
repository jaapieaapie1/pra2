namespace WachtrijApp
{
    partial class FormWachtrij
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWachtrij));
            this.labelTitel = new System.Windows.Forms.Label();
            this.labelWachttijd = new System.Windows.Forms.Label();
            this.labelWachttijdMelding = new System.Windows.Forms.Label();
            this.AttractieLogo = new System.Windows.Forms.PictureBox();
            this.labelKar2 = new System.Windows.Forms.Label();
            this.labelKar1 = new System.Windows.Forms.Label();
            this.labelKar3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AttractieLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.BackColor = System.Drawing.Color.Transparent;
            this.labelTitel.Font = new System.Drawing.Font("Inter", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitel.ForeColor = System.Drawing.Color.Black;
            this.labelTitel.Location = new System.Drawing.Point(25, 36);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(151, 30);
            this.labelTitel.TabIndex = 0;
            this.labelTitel.Text = "Debug Hero";
            this.labelTitel.Click += new System.EventHandler(this.labelTitel_Click);
            // 
            // labelWachttijd
            // 
            this.labelWachttijd.AutoSize = true;
            this.labelWachttijd.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWachttijd.Location = new System.Drawing.Point(25, 158);
            this.labelWachttijd.Name = "labelWachttijd";
            this.labelWachttijd.Size = new System.Drawing.Size(106, 25);
            this.labelWachttijd.TabIndex = 4;
            this.labelWachttijd.Text = "Wachttijd";
            this.labelWachttijd.Click += new System.EventHandler(this.labelWachttijd_Click);
            // 
            // labelWachttijdMelding
            // 
            this.labelWachttijdMelding.AutoSize = true;
            this.labelWachttijdMelding.BackColor = System.Drawing.Color.Pink;
            this.labelWachttijdMelding.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWachttijdMelding.Location = new System.Drawing.Point(29, 192);
            this.labelWachttijdMelding.Name = "labelWachttijdMelding";
            this.labelWachttijdMelding.Size = new System.Drawing.Size(72, 18);
            this.labelWachttijdMelding.TabIndex = 5;
            this.labelWachttijdMelding.Text = "0 minuten";
            // 
            // AttractieLogo
            // 
            this.AttractieLogo.ErrorImage = null;
            this.AttractieLogo.Image = ((System.Drawing.Image)(resources.GetObject("AttractieLogo.Image")));
            this.AttractieLogo.Location = new System.Drawing.Point(300, 121);
            this.AttractieLogo.Name = "AttractieLogo";
            this.AttractieLogo.Size = new System.Drawing.Size(167, 170);
            this.AttractieLogo.TabIndex = 6;
            this.AttractieLogo.TabStop = false;
            this.AttractieLogo.Click += new System.EventHandler(this.AttractieLogo_Click);
            // 
            // labelKar2
            // 
            this.labelKar2.AutoSize = true;
            this.labelKar2.BackColor = System.Drawing.Color.Pink;
            this.labelKar2.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKar2.Location = new System.Drawing.Point(29, 108);
            this.labelKar2.Name = "labelKar2";
            this.labelKar2.Size = new System.Drawing.Size(63, 18);
            this.labelKar2.TabIndex = 8;
            this.labelKar2.Text = "Kar 2: ...";
            // 
            // labelKar1
            // 
            this.labelKar1.AutoSize = true;
            this.labelKar1.BackColor = System.Drawing.Color.Pink;
            this.labelKar1.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKar1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelKar1.Location = new System.Drawing.Point(29, 85);
            this.labelKar1.Name = "labelKar1";
            this.labelKar1.Size = new System.Drawing.Size(63, 18);
            this.labelKar1.TabIndex = 9;
            this.labelKar1.Text = "Kar 1: ...";
            this.labelKar1.Click += new System.EventHandler(this.labelKar1_Click);
            // 
            // labelKar3
            // 
            this.labelKar3.AutoSize = true;
            this.labelKar3.BackColor = System.Drawing.Color.Pink;
            this.labelKar3.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKar3.Location = new System.Drawing.Point(29, 131);
            this.labelKar3.Name = "labelKar3";
            this.labelKar3.Size = new System.Drawing.Size(63, 18);
            this.labelKar3.TabIndex = 10;
            this.labelKar3.Text = "Kar 3: ...";
            this.labelKar3.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormWachtrij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 275);
            this.Controls.Add(this.labelKar3);
            this.Controls.Add(this.labelKar1);
            this.Controls.Add(this.labelKar2);
            this.Controls.Add(this.AttractieLogo);
            this.Controls.Add(this.labelWachttijdMelding);
            this.Controls.Add(this.labelWachttijd);
            this.Controls.Add(this.labelTitel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWachtrij";
            this.Text = "Debug Hero";
            this.Load += new System.EventHandler(this.FormWachtrij_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttractieLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Label labelWachttijd;
        private System.Windows.Forms.Label labelWachttijdMelding;
        private System.Windows.Forms.PictureBox AttractieLogo;
        private System.Windows.Forms.Label labelKar2;
        private System.Windows.Forms.Label labelKar1;
        private System.Windows.Forms.Label labelKar3;
    }
}

