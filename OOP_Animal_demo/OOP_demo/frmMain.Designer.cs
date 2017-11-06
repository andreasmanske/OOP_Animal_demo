namespace OOP_demo
{
    partial class frmMain
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCreateDolphin = new System.Windows.Forms.Button();
            this.btnCreatePolarBear = new System.Windows.Forms.Button();
            this.btnCreateHuman = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateBrownBear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(28, 163);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(796, 192);
            this.lblDescription.TabIndex = 0;
            // 
            // btnCreateDolphin
            // 
            this.btnCreateDolphin.Location = new System.Drawing.Point(28, 45);
            this.btnCreateDolphin.Name = "btnCreateDolphin";
            this.btnCreateDolphin.Size = new System.Drawing.Size(167, 47);
            this.btnCreateDolphin.TabIndex = 1;
            this.btnCreateDolphin.Text = "Create Dolphin";
            this.btnCreateDolphin.UseVisualStyleBackColor = true;
            this.btnCreateDolphin.Click += new System.EventHandler(this.btnCreateDolphin_Click);
            // 
            // btnCreatePolarBear
            // 
            this.btnCreatePolarBear.Location = new System.Drawing.Point(216, 45);
            this.btnCreatePolarBear.Name = "btnCreatePolarBear";
            this.btnCreatePolarBear.Size = new System.Drawing.Size(207, 48);
            this.btnCreatePolarBear.TabIndex = 2;
            this.btnCreatePolarBear.Text = "Create Polar Bear";
            this.btnCreatePolarBear.UseVisualStyleBackColor = true;
            this.btnCreatePolarBear.Click += new System.EventHandler(this.btnCreatePolarBear_Click);
            // 
            // btnCreateHuman
            // 
            this.btnCreateHuman.Location = new System.Drawing.Point(669, 46);
            this.btnCreateHuman.Name = "btnCreateHuman";
            this.btnCreateHuman.Size = new System.Drawing.Size(155, 47);
            this.btnCreateHuman.TabIndex = 3;
            this.btnCreateHuman.Text = "Create Human";
            this.btnCreateHuman.UseVisualStyleBackColor = true;
            this.btnCreateHuman.Click += new System.EventHandler(this.btnCreateHuman_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "About Me";
            // 
            // btnCreateBrownBear
            // 
            this.btnCreateBrownBear.Location = new System.Drawing.Point(447, 44);
            this.btnCreateBrownBear.Name = "btnCreateBrownBear";
            this.btnCreateBrownBear.Size = new System.Drawing.Size(202, 48);
            this.btnCreateBrownBear.TabIndex = 5;
            this.btnCreateBrownBear.Text = "Create Brown Bear";
            this.btnCreateBrownBear.UseVisualStyleBackColor = true;
            this.btnCreateBrownBear.Click += new System.EventHandler(this.btnCreateBrownBear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(861, 391);
            this.Controls.Add(this.btnCreateBrownBear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateHuman);
            this.Controls.Add(this.btnCreatePolarBear);
            this.Controls.Add(this.btnCreateDolphin);
            this.Controls.Add(this.lblDescription);
            this.Name = "frmMain";
            this.Opacity = 0.8D;
            this.Text = "OOP Demo";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnCreateDolphin;
        private System.Windows.Forms.Button btnCreatePolarBear;
        private System.Windows.Forms.Button btnCreateHuman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateBrownBear;
    }
}

