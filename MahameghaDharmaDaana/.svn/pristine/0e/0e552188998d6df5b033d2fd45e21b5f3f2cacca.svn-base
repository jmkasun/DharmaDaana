using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBCore.Classes;
using YBS.Common;
using System.Collections;

namespace YBS.Forms
{
    public partial class frmPayments : DevComponents.DotNetBar.Office2007Form
    {
        int paymentID = 0;
        int memberID = 0;
        int monthlyAmount = 0;

        DBCore.UserLevel userLevel = DBCore.UserLevel.SystemUser;

        public frmPayments(int permissionLevel)
        {
            userLevel = (DBCore.UserLevel)permissionLevel;
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateBeforeAdd())
                {
                    int numberofMonths = (int)amountText.Value / monthlyAmount;
                    for (int i = 0; i < numberofMonths; i++)
                    {
                        using (MonthlyPayment pay = new MonthlyPayment(true))
                        {




                            setObjectFromFieldValues(pay, i);

                            if (paymentID == 0)
                            {
                                if (pay.Add() == 1)
                                {
                                    // MessageView.ShowMsg("Sucessfully Added");

                                    //errorProvider1.SetError(idTxt, string.Empty);
                                    //errorProvider1.SetError(nameTxt, string.Empty);
                                    statusText.Visible = true;
                                    timer1.Enabled = true;

                                    
                                }

                            }
                            else
                            {
                                pay.ID = paymentID;

                                if (MessageView.ShowQuestionMsg("Update Address") == DialogResult.OK)
                                {

                                    if (pay.Update() == 1)
                                    {
                                        MessageView.ShowMsg("Sucessfully Updated");

                                        //errorProvider1.SetError(idTxt, string.Empty);
                                        //errorProvider1.SetError(nameTxt, string.Empty);

                                    }
                                }
                            }
                        }
                    }

                    clear();
                }

            }
            catch (Exception ex)
            {
                MessageView.ShowErrorMsg(ex.Message);
            }
        }

        private void setObjectFromFieldValues(MonthlyPayment pay, int monthNumber)
        {
            int month = 1 + (monthCombo.SelectedIndex + monthNumber) % 12;
            int year = Int32.Parse(yearText.Text) + ((monthCombo.SelectedIndex + monthNumber) / 12);

            pay.MemberID = memberID;
            pay.Month = new DateTime(year, month, 1);
            pay.Amount = monthlyAmount;
        }


        private void setFieldValsues(OtherAddress addr)
        {
            regNumText.Text = addr.OrderNumber.ToString();
            amountText.Value = addr.numOfMag;
            nameText.Text = addr.ContactName;
        }



        private void clear()
        {
            paymentID = 0;
            memberID = 0;
            addbtn.Text = "Insert";
            deleteBtn.Enabled = false;

            regNumText.Focus();
            regNumText.Clear();
            nameText.Clear();
            mobileText.Clear();
            homeTpText.Clear();
            initialAmountTxt.Text = "";
            monthslbl.Text = "";

            dataGridView1.Rows.Clear();

            setUserPermissions();
        }

        private bool ValidateBeforeAdd()
        {
            return true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (OtherAddress occu = new OtherAddress(true))
            {
                occu.ID = paymentID;

                //}
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void findButton_Click(object sender, EventArgs e)
        {

            try
            {
                using (MemberInfo mem = new MemberInfo(true))
                {
                    mem.Name = nameText.Text;
                    mem.Mobile = mobileText.Text;
                    mem.HomeTP = homeTpText.Text;
                    mem.Address = "";
                    mem.Email = "";

                    DataTable ds = mem.SelectFind();
                    frmSearch frmSub = new frmSearch(ds, this.Text, 3, 50);
                    frmSub.Width = 800;
                    HandleSearch(frmSub);
                }
            }
            catch (Exception ex)
            {
                MessageView.ExceptionError(ex);
            }
        }

        // hadle operations after search
        private void HandleSearch(frmSearch frmSub)
        {
            //ApplicationSettings.ChildFormView(this.MdiParent, ref frmSub);
            if (frmSub.ShowDialog() == DialogResult.OK)
            {
                FillSearchFilds(frmSub.DataRowValues);

            }
            frmSub.Dispose();
        }

        public void FillSearchFilds(Hashtable hashtable)
        {
            try
            {
                memberID = (int)hashtable["ID"];

                using (MemberInfo memInfo = new MemberInfo(true))
                {
                    memInfo.SelectMember(memberID);

                    findMember(memInfo);
                }


            }
            catch (Exception ex)
            {
                MessageView.ExceptionError(ex);
            }
        }

        private void findMember(MemberInfo memInfo)
        {
            setMemberFields(memInfo);

            using (MonthlyPayment pay = new MonthlyPayment(true))
            {
                pay.MemberID = memInfo.ID;
                SetHistryGrid(pay.GetPaymentHistry());


            }
            amountText.Focus();
            amountText.Select(0, 5);
        }

        private void setUserPermissions()
        {
            if (userLevel == DBCore.UserLevel.SystemUser)
            {
                addbtn.Enabled = deleteBtn.Enabled = false;
            }

            if (userLevel == DBCore.UserLevel.SystemUser_I)
            {
                addbtn.Enabled = true;
                deleteBtn.Enabled = false;
            }

            if (userLevel == DBCore.UserLevel.SystemUser_IUD || userLevel == DBCore.UserLevel.SystemAdmin)
            {
                addbtn.Enabled = true;
            }
        }

        private void frmOccupatition_Load(object sender, EventArgs e)
        {


            setUserPermissions();
            clear();
        }

        private void regNumText_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                selectMember();
            } 
        }

        private void selectMember()
        {
            using (MemberInfo memInfo = new MemberInfo(true))
            {
                if (!string.IsNullOrEmpty(regNumText.Text))
                {
                    memInfo.SelectMemberbyRegNumber(regNumText.Text);

                    if (memInfo.ID > 0)
                    {
                        findMember(memInfo);

                    }
                }
            }
        }

        private void SetHistryGrid(List<PaymentHistry> list)
        {
            dataGridView1.Rows.Clear();
            foreach (PaymentHistry p in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();

                cell1.Value = p.Month.Year + "   " + monthCombo.Items[p.Month.Month - 1].ToString();
                cell2.Value = p.Amount;

                row.Cells.Add(cell1);
                row.Cells.Add(cell2);

                dataGridView1.Rows.Add(row);                     
            }
        }
        

        private void setMemberFields(MemberInfo memInfo)
        {
            regNumText.Text = memInfo.regNumber;
            memberID = memInfo.ID;
            nameText.Text = memInfo.Name;
            mobileText.Text = memInfo.Mobile;
            homeTpText.Text = memInfo.HomeTP;
            initialAmountTxt.Text = memInfo.Amount.ToString();
            monthlyAmount = memInfo.Amount;
            amountText.Value = memInfo.Amount;

            if (string.IsNullOrEmpty(yearText.Text))
                yearText.Text = DateTime.Now.Year.ToString();

            if (monthCombo.SelectedIndex == -1)
                monthCombo.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void yearText_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            yearText.ReadOnly = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusText.Visible = false;
        }

        private void nameText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Control == true)
            {
                findButton_Click(sender, e);
            }
        }

        private void amountText_Leave(object sender, EventArgs e)
        {
            calculateMonths();
        }

        private void calculateMonths()
        {
            if (monthlyAmount > 0)
            {
                int numberofMonths = (int)amountText.Value / monthlyAmount;
                monthslbl.Text = "";


                for (int i = 0; i < numberofMonths; i++)
                {
                    monthslbl.Text += monthCombo.Items[(monthCombo.SelectedIndex + i) % 12] + "\n";
                }
            }
        }

        private void monthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateMonths();
        }

        private void regNumText_Leave(object sender, EventArgs e)
        {
            selectMember();
        }
    }
}
