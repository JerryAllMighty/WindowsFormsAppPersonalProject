using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPersonalProject
{
    public partial class frmSending : Form
    {
        StringBuilder sb = new StringBuilder();

        public frmSending()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NumericCheck(object sender, KeyPressEventArgs e)
        {
            bool bChange = char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '\b';
            TextBox temp = (TextBox)sender;
            if (!bChange)       //숫자만 입력하게 체크
            {
                errorProvider1.SetError(temp, "숫자만 입력하세요.");
                e.Handled = true;
            }

            
            switch(e.KeyChar.ToString())
                {
                case "1":
                    sb.Append(e.KeyChar.ToString().Replace('1', '일'));
                    break;
                case "2":
                    sb.Append(e.KeyChar.ToString().Replace('2', '이'));
                    break;
                case "3":
                    sb.Append(e.KeyChar.ToString().Replace('3', '삼'));
                    break;
                case "4":
                    sb.Append(e.KeyChar.ToString().Replace('4', '사'));
                    break;
                case "5":
                    sb.Append(e.KeyChar.ToString().Replace('5', '오'));
                    break;
                case "6":
                    sb.Append(e.KeyChar.ToString().Replace('6', '육'));
                    break;
                case "7":
                    sb.Append(e.KeyChar.ToString().Replace('7', '칠'));
                    break;
                case "8":
                    sb.Append(e.KeyChar.ToString().Replace('8', '팔'));
                    break;
                case "9":
                    sb.Append(e.KeyChar.ToString().Replace('9', '구'));
                    break;
                case "0":
                    sb.Append(e.KeyChar.ToString().Replace('0', '영'));
                    break;

            }       //한글로 숫자를 치환해서 보여주기

            

            label4.Text = $"{sb.ToString()}원";


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void replace(string str)
        {
            switch (str)
            {
                case "1":
                    str.Replace("1", "일");
                    break;
            }
        }

        private void IsNumeric(object sender, KeyPressEventArgs e)
        {
            bool bChange = char.IsNumber(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '\b';
            TextBox temp = (TextBox)sender;
            if (!bChange)
            {
                errorProvider1.SetError(temp, "숫자만 입력하시기 바랍니다.");
                e.Handled = true;
            }
        }
    }
}
