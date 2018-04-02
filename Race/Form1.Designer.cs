namespace Race
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.button1 = new System.Windows.Forms.Button();
         this.score_label = new System.Windows.Forms.Label();
         this.button2 = new System.Windows.Forms.Button();
         this.Lvl_Lbl = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
         this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button1.Location = new System.Drawing.Point(215, 69);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(146, 31);
         this.button1.TabIndex = 0;
         this.button1.TabStop = false;
         this.button1.Text = "Bắt đầu / Tạm dừng";
         this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
         // 
         // score_label
         // 
         this.score_label.AutoSize = true;
         this.score_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.score_label.Location = new System.Drawing.Point(212, 122);
         this.score_label.Name = "score_label";
         this.score_label.Size = new System.Drawing.Size(0, 19);
         this.score_label.TabIndex = 1;
         // 
         // button2
         // 
         this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
         this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button2.Location = new System.Drawing.Point(215, 193);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(146, 31);
         this.button2.TabIndex = 0;
         this.button2.TabStop = false;
         this.button2.Text = "Trở về Menu";
         this.button2.UseVisualStyleBackColor = false;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // Lvl_Lbl
         // 
         this.Lvl_Lbl.AutoSize = true;
         this.Lvl_Lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Lvl_Lbl.Location = new System.Drawing.Point(212, 141);
         this.Lvl_Lbl.Name = "Lvl_Lbl";
         this.Lvl_Lbl.Size = new System.Drawing.Size(62, 19);
         this.Lvl_Lbl.TabIndex = 3;
         this.Lvl_Lbl.Text = "Độ khó: ";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.ClientSize = new System.Drawing.Size(364, 322);
         this.Controls.Add(this.Lvl_Lbl);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.score_label);
         this.Controls.Add(this.button1);
         this.DoubleBuffered = true;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Race";
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
         this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Lvl_Lbl;
    }
}