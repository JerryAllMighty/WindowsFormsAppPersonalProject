namespace WindowsFormsAppPersonalProject
{
    partial class frmSendingMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendingMessage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblReceiverName = new System.Windows.Forms.Label();
            this.lblSenderName = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.lblReceiverName);
            this.groupBox1.Controls.Add(this.lblSenderName);
            this.groupBox1.Controls.Add(this.txtMsg);
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.lblFrom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "전송정보확인";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(632, 357);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(138, 63);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblReceiverName
            // 
            this.lblReceiverName.Location = new System.Drawing.Point(207, 101);
            this.lblReceiverName.Name = "lblReceiverName";
            this.lblReceiverName.Size = new System.Drawing.Size(100, 23);
            this.lblReceiverName.TabIndex = 5;
            this.lblReceiverName.Text = "수신자명";
            this.lblReceiverName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSenderName
            // 
            this.lblSenderName.Location = new System.Drawing.Point(207, 56);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(100, 23);
            this.lblSenderName.TabIndex = 4;
            this.lblSenderName.Text = "송신자명";
            this.lblSenderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMsg
            // 
            this.txtMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMsg.Location = new System.Drawing.Point(112, 182);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(658, 169);
            this.txtMsg.TabIndex = 0;
            this.txtMsg.TextChanged += new System.EventHandler(this.txtMsg_TextChanged);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(6, 156);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(100, 23);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "전달내용";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTo
            // 
            this.lblTo.Location = new System.Drawing.Point(6, 101);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(100, 23);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "수신자";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFrom
            // 
            this.lblFrom.Location = new System.Drawing.Point(6, 56);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(100, 23);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "송신자";
            this.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSendingMessage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSendingMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "메세지 전송";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSendingMessage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label lblReceiverName;
        private System.Windows.Forms.Label lblSenderName;
        private System.Windows.Forms.Button btnSend;
    }
}