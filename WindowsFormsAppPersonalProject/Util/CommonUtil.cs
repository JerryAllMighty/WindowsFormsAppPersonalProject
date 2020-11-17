using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPersonalProject
{
    public class CommonUtil
    {

        public static void SetinitGridView(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AutoGenerateColumns = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;

        }

        public static void AddGridTextColumn(
            DataGridView dgv,
            string headerText,
            string datapropertytype,
            int colWidth = 100,
            bool visibility = true,
            DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft    

            )
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = datapropertytype;
            col.HeaderText = headerText;
            col.DataPropertyName = datapropertytype;
            col.Width = colWidth;
            col.Visible = visibility;
            col.DefaultCellStyle.Alignment = textAlign;
            col.ReadOnly = true;

            dgv.Columns.Add(col);

        }

        public void AddGridTextColumn2(             //컬럼에 텍스트 적어주고 사라지게하고 싶을 때
            DataGridView dgv,
            string headerText,
            string datapropertytype,
            int colWidth = 100,
            bool visibility = true,
            DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft    

            )
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            col.DataPropertyName = datapropertytype;
            col.Width = colWidth;
            col.Visible = visibility;
            col.DefaultCellStyle.Alignment = textAlign;
            col.ReadOnly = true;

            dgv.Columns.Add(col);

        }


        public static bool NumberCheck(char a)
        {
            if (!char.IsDigit(a) && !a.Equals('\b') && !a.Equals((char)13))
            {
                MessageBox.Show("숫자만 입력해주시기 바랍니다.");
                return false;
            }
            return true;
        }
    }
}
