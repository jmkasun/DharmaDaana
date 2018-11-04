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
    public partial class frmPayments : Form
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

                    using (MonthlyPayment pay = new MonthlyPayment(true))
                    {


                        if (paymentID == 0 && monthlyAmount > 0)
                        {
                            int numberofMonths = (int)amountText.Value / monthlyAmount;
                            for (int i = 0; i < numberofMonths; i++)
                            {
                                setObjectFromFieldValues(pay, i);

                                if (pay.MemberID > 0 && pay.Add() == 1)
                                {
                                    // MessageView.ShowMsg("Sucessfully Added");

                                    //errorProvider1.SetError(idTxt, string.Empty);
                                    //errorProvider1.SetError(nameTxt, string.Empty);
                                    statusText.Visible = true;
                                    timer1.Enabled = true;

                                    clear(1);
                                }
                            }

                        }
                        else if (memberID > 0)
                        {
                            pay.ID = paymentID;
                            setObjectFromFieldValues(pay, 0);

                            if (MessageView.ShowQuestionMsg("Update record") == DialogResult.OK)
                            {

                                if (pay.Update() == 1)
                                {
                                    SetHistryGrid(pay.GetPaymentHistry());

                                    extraAmountNum.Value = 0;

                                }
                            }
                        }
                    }

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
            pay.Month = new DateTime(year, month, adhiPohoyaTick.Checked == true ? 2 : 1);
            pay.Amount = monthlyAmount;
            pay.paidDate = paidDate.Value;
            pay.ExtraAmount = (int)extraAmountNum.Value;
        }


        private void setFieldValsues(OtherAddress addr)
        {
            regNumText.Text = addr.OrderNumber.ToString();
            amountText.Value = addr.numOfMag;
            nameText.Text = addr.ContactName;

        }



        private void clear(int type)
        {
            paymentID = 0;
            memberID = 0;
            addbtn.Text = "Insert";
            deleteBtn.Enabled = false;
            amountText.Maximum = 100000;
            regNumText.Focus();
            regNumText.Clear();
            nameText.Clear();
            mobileText.Clear();
            homeTpText.Clear();
            initialAmountTxt.Text = "";
            monthslbl.Text = "";

            dataGridView1.Rows.Clear();


            extraAmountNum.Value = 0;
            setUserPermissions();
            adhiPohoyaTick.Checked = false;
            paidDate.Value = DateTime.Now;
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
            clear(0);
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
            clear(0);
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

                // DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();

                row.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Month.Year + "   " + monthCombo.Items[p.Month.Month - 1].ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Amount });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = p.ExtraAmount == 0 ? "" : p.ExtraAmount.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Id });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Month });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = p.PaidDate });

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

                if (numberofMonths == 1)
                {
                    adhiPohoyaTick.Enabled = true;
                }
                else
                {
                    adhiPohoyaTick.Enabled = false;
                }

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection Cells = dataGridView1.Rows[e.RowIndex].Cells;

            paymentID = Int32.Parse(Cells["id"].Value.ToString());
            DateTime month = (DateTime)Cells["dateMonth"].Value;

            yearText.Text = month.Year.ToString();
            monthCombo.SelectedIndex = month.Month - 1;

            amountText.Value = Int32.Parse(Cells["amount"].Value.ToString());
            string extAmount = Cells["extraAmount"].Value.ToString();

            extraAmountNum.Value = string.IsNullOrEmpty(extAmount) ? 0 : Int32.Parse(extAmount);
            paidDate.Value = ((DateTime)Cells["paidDateTime"].Value) == new DateTime() ? paidDate.MinDate : (DateTime)Cells["paidDateTime"].Value;

            addbtn.Text = "Update";
            amountText.Maximum = monthlyAmount;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paymentTypeCombo.SelectedIndex == 0)
            {
                receptNum.Visible = true;
            }
            else
            {
                receptNum.Visible = false;
            }
        }
    }
}
