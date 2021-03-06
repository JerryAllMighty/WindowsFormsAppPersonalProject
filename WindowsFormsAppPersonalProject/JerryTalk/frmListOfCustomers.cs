﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPersonalProject
{
    public partial class frmListOfCustomers : Form
    {
        string CustomerNum;
        string CustomerName;
        string CustomerAddress;
        string CustomerID;
        string IsAdmin;
        string CustomerPw;
        string Phone;
        string CustomerEmail;
        string CustomerImage;

        frmJerryTalk frm;
        DataTable dt;
        string ReceiverNum;
        string ReceiverName;
        string ReceiverInfO;

        public frmListOfCustomers(Customer cusinfo, frmJerryTalk temp)
        {
            InitializeComponent();
            CustomerNum = cusinfo.CustomerNum;
            CustomerName = cusinfo.CustomerName;
            CustomerAddress = cusinfo.CustomerAddress;
            CustomerID = cusinfo.CustomerID;
            IsAdmin = cusinfo.IsAdmin;
            CustomerPw = cusinfo.CustomerPw;
            Phone = cusinfo.Phone;
            CustomerEmail = cusinfo.CustomerEmail;
            CustomerImage = cusinfo.CustomerImage;

            frm = temp;
        }

        public Customer customerInfo
        {
            get
            {
                return new Customer(CustomerNum, CustomerName, CustomerAddress,
                                            CustomerID, IsAdmin, CustomerPw, Phone, CustomerEmail, CustomerImage);
            }
        }
        public string receiverinfo {
            get { return (ReceiverInfO); } 
        
        }

        private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("해당 고객에게 메세지를 보내시겠습니까?", "선택확인", MessageBoxButtons
                .YesNo) == DialogResult.Yes)
            {
                ReceiverNum  = dt.Rows[e.RowIndex][0].ToString();
                ReceiverName = dt.Rows[e.RowIndex][1].ToString();
                ReceiverInfO = ReceiverNum + "." +ReceiverName;
                
                frm.receiverinfo = ReceiverInfO;
                this.Close();
            }
        }

        private void ListOfCustomers_Load(object sender, EventArgs e)
        {   //필요없는 정보는 주석~
            CommonUtil.SetinitGridView(dgvMember);
            CommonUtil.AddGridTextColumn(dgvMember, "고객 번호", "CustomerNum",100);
            CommonUtil.AddGridTextColumn(dgvMember, "고객 이름", "CustomerName",120);
            CommonUtil.AddGridTextColumn(dgvMember, "고객 ID", "CustomerID",80);
            CommonUtil.AddGridTextColumn(dgvMember, "관리자 여부", "IsAdmin",120);
            //CommonUtil.AddGridTextColumn(dgvMember, "고객 비밀번호", "CustomerPw");
            CommonUtil.AddGridTextColumn(dgvMember, "고객 연락처", "CustomerPhone",120);
            CommonUtil.AddGridTextColumn(dgvMember, "고객 이메일", "CustomerEmail",120);
            //CommonUtil.AddGridTextColumn(dgvMember, "고객 이미지 경로", "CustomerImage");
            CommonUtil.AddGridTextColumn(dgvMember, "휴면 여부", "IsResting",120);
            CommonUtil.AddGridTextColumn(dgvMember, "고객 주소", "CustomerAddress",480);



            CustomerDB db = new CustomerDB();
            dt = db.GetEveryData();

            if (dt != null)
            {
                dgvMember.DataSource = dt;
            }
            else { MessageBox.Show("고객의 정보를 가져오는데 실패하였습니다."); }
        }
    }
}
