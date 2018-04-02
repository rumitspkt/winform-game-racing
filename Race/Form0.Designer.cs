namespace Race
{
    partial class Form0
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
         this.Easy_lvl = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.Middle_lvl = new System.Windows.Forms.Button();
         this.Hard_lvl = new System.Windows.Forms.Button();
         this.Exit_btn = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // Easy_lvl
         // 
         this.Easy_lvl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Easy_lvl.Location = new System.Drawing.Point(218, 61);
         this.Easy_lvl.Name = "Easy_lvl";
         this.Easy_lvl.Size = new System.Drawing.Size(180, 60);
         this.Easy_lvl.TabIndex = 0;
         this.Easy_lvl.TabStop = false;
         this.Easy_lvl.Text = "Dễ";
         this.Easy_lvl.UseVisualStyleBackColor = true;
         this.Easy_lvl.Click += new System.EventHandler(this.Easy_lvl_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(257, 22);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(95, 24);
         this.label1.TabIndex = 1;
         this.label1.Text = "ĐỘ KHÓ";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // Middle_lvl
         // 
         this.Middle_lvl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Middle_lvl.Location = new System.Drawing.Point(218, 141);
         this.Middle_lvl.Name = "Middle_lvl";
         this.Middle_lvl.Size = new System.Drawing.Size(180, 60);
         this.Middle_lvl.TabIndex = 0;
         this.Middle_lvl.TabStop = false;
         this.Middle_lvl.Text = "Trung bình";
         this.Middle_lvl.UseVisualStyleBackColor = true;
         this.Middle_lvl.Click += new System.EventHandler(this.Middle_lvl_Click);
         // 
         // Hard_lvl
         // 
         this.Hard_lvl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Hard_lvl.Location = new System.Drawing.Point(218, 221);
         this.Hard_lvl.Name = "Hard_lvl";
         this.Hard_lvl.Size = new System.Drawing.Size(180, 60);
         this.Hard_lvl.TabIndex = 0;
         this.Hard_lvl.TabStop = false;
         this.Hard_lvl.Text = "Khó";
         this.Hard_lvl.UseVisualStyleBackColor = true;
         this.Hard_lvl.Click += new System.EventHandler(this.Hard_lvl_Click);
         // 
         // Exit_btn
         // 
         this.Exit_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
         this.Exit_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Exit_btn.Location = new System.Drawing.Point(193, 309);
         this.Exit_btn.Name = "Exit_btn";
         this.Exit_btn.Size = new System.Drawing.Size(230, 41);
         this.Exit_btn.TabIndex = 0;
         this.Exit_btn.TabStop = false;
         this.Exit_btn.Text = "Thoát";
         this.Exit_btn.UseVisualStyleBackColor = false;
         this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(57, 108);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(86, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "Hướng dẫn chơi:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(56, 132);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(53, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "W - đi lên";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(56, 156);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(64, 13);
         this.label4.TabIndex = 2;
         this.label4.Text = "S - đi xuống";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(56, 178);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(63, 13);
         this.label5.TabIndex = 2;
         this.label5.Text = "A - sang trái";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(56, 202);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(70, 13);
         this.label6.TabIndex = 2;
         this.label6.Text = "D - sang phải";
         // 
         // Form0
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(584, 362);
         this.ControlBox = false;
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.Exit_btn);
         this.Controls.Add(this.Hard_lvl);
         this.Controls.Add(this.Middle_lvl);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.Easy_lvl);
         this.Cursor = System.Windows.Forms.Cursors.Default;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "Form0";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Đua xe phân khối lớn";
         this.Load += new System.EventHandler(this.Form0_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Easy_lvl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Middle_lvl;
        private System.Windows.Forms.Button Hard_lvl;
        private System.Windows.Forms.Button Exit_btn;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
   }
}