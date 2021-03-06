﻿//This is a source code or part of OpenMiracle project
//Copyright (C) 2013  Cybrosys Technologies Pvt.Ltd
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;using Profunia.Inventory.Desktop.ClassFiles.General;using Profunia.Inventory.Desktop.ClassFiles.Info;using Profunia.Inventory.Desktop.ClassFiles.SP;
using System.Drawing;using Profunia.Inventory.Desktop.Company;using Profunia.Inventory.Desktop.FinancialStatements;using Profunia.Inventory.Desktop.Masters;using Profunia.Inventory.Desktop.Others;using Profunia.Inventory.Desktop.Payroll;using Profunia.Inventory.Desktop.Registers;using Profunia.Inventory.Desktop.Reminder;using Profunia.Inventory.Desktop.Reports;using Profunia.Inventory.Desktop.Search;using Profunia.Inventory.Desktop.Settings;using Profunia.Inventory.Desktop.Transactions;using Profunia.Inventory.Desktop.Transfer;using Profunia.Inventory.Desktop.Budget;
using Profunia.Inventory.Desktop.ClassFiles.SP;using Profunia.Inventory.Desktop.ClassFiles.Info;using Profunia.Inventory.Desktop.ClassFiles.General;using System.Linq;
using Profunia.Inventory.Desktop.Others;using Profunia.Inventory.Desktop.Reports;using Profunia.Inventory.Desktop.Registers;using Profunia.Inventory.Desktop.Masters;using Profunia.Inventory.Desktop.Search;using System.Windows.Forms;
//using System.Web.Mail;
using System.Reflection;
using Profunia.Inventory.Desktop.Transfer;

namespace Profunia.Inventory.Desktop.Others
{
    public partial class frmSendMail : Form
    {
        #region Variables
        frmLoading frmLodingObj = new frmLoading();
        bool isSend = false;
        bool isCheck = false;
        int inBodyCount = 0;
        #endregion
        #region Functions

        public frmSendMail()
        {
            InitializeComponent();
        }
        public void clear()
        {
            try
            {
                txtMailId.Text = string.Empty;
                txtSubjest.Text = string.Empty;
                txtBody.Text = string.Empty;
                inBodyCount = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool ValidateEmail()
        {
            bool result = true;
            try
            {
                if (txtMailId.Text.Trim() != string.Empty)
                {
                    System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");//^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$
                    if (txtMailId.Text.Length > 0)
                    {
                        if (!rEMail.IsMatch(txtMailId.Text))
                        {
                            MessageBox.Show("Invalid Email", "Pharmasoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            result = false;
                            txtMailId.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return result;
        }

        public void SendAttachmentEmail()
        {
            //try
            //{
            //    Cursor.Current = Cursors.WaitCursor;
            //    MailMessage mailMsg = new MailMessage();
            //    mailMsg.From = "openmiracleuserfeedback@gmail.com";
            //    mailMsg.To = "openmiraclefeedback@gmail.com";
            //    mailMsg.Subject = txtMailId.Text.Trim()+ "--" + txtSubjest.Text.Trim();
            //    mailMsg.BodyFormat = MailFormat.Text;
            //    mailMsg.Body = txtBody.Text;
            //    foreach (string strPath in lstbxAttach.Items)
            //    {
            //        MailAttachment attach = new MailAttachment(strPath);
            //        mailMsg.Attachments.Add(attach);
            //    }
            //    mailMsg.Priority = MailPriority.High;
            //    SmtpMail.SmtpServer = "smtp.gmail.com";//smtp is :smtp.gmail.com
            //   // SmtpMail.SmtpServer = "plus.smtp.mail.yahoo.com";//smtp is :smtp.yahoo.com
            //    mailMsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
            //    mailMsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "openmiracleuserfeedback@gmail.com");
            //    mailMsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "humanwayofaccounting");
            //    // - smtp.gmail.com use port 465 or 587
            //    // - plus.smtp.mail.yahoo.com use port 465 or 587
            //    mailMsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", "465");
            //    mailMsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpusessl", "true");
            //    SmtpMail.Send(mailMsg);
            //    Cursor.Current = Cursors.Default;
            //    isSend = true;
            //    isCheck = true;
            //    MessageBox.Show("Mail sent successfully ", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception)
            //{
            //    Cursor.Current = Cursors.Default;
            //    isSend = true;
            //    MessageBox.Show("Mail sending failed", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
        public void SendMail()
        {
            try
            {
                if (ValidateEmail())
                {

                    if (txtSubjest.Text == string.Empty)
                    {
                        if (MessageBox.Show("Send this message without a subject ?", "OpenMiracle", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            if (txtBody.Text == string.Empty)
                            {
                                if (MessageBox.Show("Send this message without text in the body ?", "OpenMiracle", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                                {
                                    bwrk1.RunWorkerAsync();
                                    frmLodingObj.ShowFromSendMail();
                                }
                                else
                                {
                                    txtBody.Focus();
                                }
                            }
                            else
                            {
                                bwrk1.RunWorkerAsync();
                                frmLodingObj.ShowFromSendMail();
                            }
                        }
                        else
                        {
                            txtSubjest.Focus();
                        }
                    }
                    else
                    {
                        if (txtBody.Text == string.Empty)
                        {
                            if (MessageBox.Show("Send this message without text in the body ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                bwrk1.RunWorkerAsync();
                                frmLodingObj.ShowFromSendMail();
                            }
                            else
                            {
                                txtBody.Focus();
                            }
                        }
                        else
                        {
                            bwrk1.RunWorkerAsync();
                            frmLodingObj.ShowFromSendMail();
                        }
                    }
                }
                if (isCheck)
                {
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog folderB = new OpenFileDialog();
                folderB.ShowDialog();
                if (folderB.FileName.ToString() != string.Empty)
                {
                    lstbxAttach.Items.Add(folderB.FileName.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMailId.Text == string.Empty)
                {
                    MessageBox.Show("Enter your Email id to send mail", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    txtMailId.Focus();
                }
                else
                {
                    SendMail();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void frmSendMail_Load(object sender, EventArgs e)
        {
            try
            {
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bwrk1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                SendAttachmentEmail();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bwrk1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (frmLodingObj != null && isSend)
                {
                    frmLodingObj.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (Messages.CloseConfirmation())
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion
        #region Navigation
        private void txtMailId_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtSubjest.Focus();
                    txtSubjest.SelectionStart = 0;
                    txtSubjest.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtSubjest_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtBody.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtSubjest.Text.Trim() == string.Empty || txtSubjest.SelectionStart == 0)
                    {
                        txtMailId.SelectionStart = 0;
                        txtMailId.SelectionLength = 0;
                        txtMailId.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBody_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {


                if (e.KeyChar == 13)
                {
                    inBodyCount++;
                    if (inBodyCount == 3)
                    {
                        inBodyCount = 0;
                        btnSend.Focus();
                    }
                }
                else
                {
                    inBodyCount = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


    }
}
