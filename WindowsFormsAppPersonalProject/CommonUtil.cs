﻿using System;
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
        }

        public static void AddGridTextColumn(
            DataGridView dgv,
            string headerText,
            string datapropertytype,
            int coldWidth = 100,
            bool visibility = true,
            DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft

            )
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            col.DataPropertyName = datapropertytype;
            col.Width = coldWidth;
            col.Visible = visibility;
            col.ReadOnly = true;

            dgv.Columns.Add(col);

        }
    }
}