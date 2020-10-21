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
    public partial class Sending : Form
    {
        string str = "";
        string danwee = "";

        public Sending()
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
            if (!bChange)
            {
                errorProvider1.SetError(temp, "숫자만 입력하세요.");
                e.Handled = true;
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
           
            str += temp.Text.ToString().Trim();
            List<string> Hi = new List<string>();


            str.Replace('1', '일');
            str.Replace('2', '이');
            str.Replace("3", "삼");
            str.Replace("4", "사");
            str.Replace("5", "오");
            str.Replace("6", "육");
            str.Replace("7", "칠");
            str.Replace("8", "팔");
            str.Replace("9", "구");
            str.Replace("0", "영");          //쓰벌 이거 왜 바껴서 출력 안되냐 바뀌고 바로 원래대로 돌아가는거냐


            label4.Text = $"{str}원";
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
