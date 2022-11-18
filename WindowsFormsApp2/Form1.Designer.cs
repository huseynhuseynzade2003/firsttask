namespace WindowsFormsApp2
{
    partial class Form1
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
            this.timeLbl = new System.Windows.Forms.Label();
            this.BakuBtn = new System.Windows.Forms.Button();
            this.LondonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeLbl
            // 
            this.timeLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.timeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.Location = new System.Drawing.Point(300, 30);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.timeLbl.MaximumSize = new System.Drawing.Size(300, 300);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(100, 50);
            this.timeLbl.TabIndex = 0;
            this.timeLbl.Text = "START";
            // 
            // BakuBtn
            // 
            this.BakuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BakuBtn.Location = new System.Drawing.Point(28, 354);
            this.BakuBtn.Name = "BakuBtn";
            this.BakuBtn.Size = new System.Drawing.Size(80, 80);
            this.BakuBtn.TabIndex = 1;
            this.BakuBtn.Text = "BAku";
            this.BakuBtn.UseVisualStyleBackColor = true;
            this.BakuBtn.Click += new System.EventHandler(this.BakuBtn_Click);
            // 
            // LondonBtn
            // 
            this.LondonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LondonBtn.Location = new System.Drawing.Point(638, 354);
            this.LondonBtn.Name = "LondonBtn";
            this.LondonBtn.Size = new System.Drawing.Size(80, 80);
            this.LondonBtn.TabIndex = 2;
            this.LondonBtn.Text = "London";
            this.LondonBtn.UseVisualStyleBackColor = true;
            this.LondonBtn.Click += new System.EventHandler(this.LondonBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LondonBtn);
            this.Controls.Add(this.BakuBtn);
            this.Controls.Add(this.timeLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button BakuBtn;
        private System.Windows.Forms.Button LondonBtn;
    }
}

