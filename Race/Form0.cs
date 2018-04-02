using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace Race
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            f1 = new Form1(this);
            InitializeComponent();
        }
        Form1 f1;
        
        void Scoring(List<int> scores)
        {
            int temp;
            for (int i = 0; i < scores.Count; i++)
            {
                for (int j = 0; j < scores.Count - i - 1; j++)
                {
                    if (scores[j] > scores[j + 1])
                    {
                        temp = scores[j];
                        scores[j] = scores[j + 1];
                        scores[j + 1] = temp;
                    }
                }
            }
            while (scores.Count > 10)
                scores.RemoveAt(0);
        }
        private void Easy_lvl_Click(object sender, EventArgs e)
        {
            f1.Level = Levels.Easy;
            f1.Show();
            Hide();
        }
        private void Middle_lvl_Click(object sender, EventArgs e)
        {
            f1.Level = Levels.Medium;
            f1.Show();
            Hide();
        }
        private void Hard_lvl_Click(object sender, EventArgs e)
        {
            f1.Level = Levels.Hard;
            f1.Show();
            Hide();
        }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      private void Form0_Load(object sender, EventArgs e)
      {
         label1.Focus();
      }
   }
}