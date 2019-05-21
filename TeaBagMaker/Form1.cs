using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        string[] teaList = new string[]{"홍차", "녹차", "루이보스차", "국화차"};
        string orgStr = "";
        int CountOrgNum = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < teaList.Length; i++)
            {
                this.cbList.Items.Add(teaList[i]);
            }
            if (cbList.Items.Count > 0)
            {
                this.cbList.SelectedIndex = 0;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.cbList.Text == "홍차")
            {
                this.lblResult.Text = "2분";
            }
            if (this.cbList.Text == "녹차")
            {
                this.lblResult.Text = "3분";
            }
            if (this.cbList.Text == "루이보스차")
            {
                this.lblResult.Text = "5분";
            }
            if (this.cbList.Text == "국화차")
            {
                this.lblResult.Text = "2분";
            }


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(this.cbList.Text == "홍차")
            {
                this.Timer.Enabled = false;
                this.lblResult.Text = orgStr;

            }
            if (this.cbList.Text == "녹차")
            {
                this.Timer.Enabled = false;
                this.lblResult.Text = orgStr;

            }
            if (this.cbList.Text == "루이보스차")
            {
                this.Timer.Enabled = false;
                this.lblResult.Text = orgStr;

            }
            if (this.cbList.Text == "국화차")
            {
                this.Timer.Enabled = false;
                this.lblResult.Text = orgStr;

            }
        }

        private bool IntCheck()
        {
            if (Information.IsNumeric(this.lblResult.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("숫자 입력하세요~", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
