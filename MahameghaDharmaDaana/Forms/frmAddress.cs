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
    public partial class frmAddress : DevComponents.DotNetBar.Office2007Form
    {
        int addressID = 0;
        DBCore.UserLevel userLevel = DBCore.UserLevel.SystemUser;

        public frmAddress(int permissionLevel)
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
                    using (OtherAddress addr = new OtherAddress(true))
                    {

                        setObjectFromFieldValues(addr);

                        if (addressID == 0)
                        {
                            if (addr.Add() == 1)
                            {
                               // MessageView.ShowMsg("Sucessfully Added");

                                //errorProvider1.SetError(idTxt, string.Empty);
                                //errorProvider1.SetError(nameTxt, string.Empty);
                                statusText.Visible = true;
                                timer1.Enabled = true;

                                clear();
                            }

                        }
                        else
                        {
                            addr.ID = addressID;

                            if (MessageView.ShowQuestionMsg("Update Address") == DialogResult.OK)
                            {

                                if (addr.Update() == 1)
                                {
                                    MessageView.ShowMsg("Sucessfully Updated");

                                    //errorProvider1.SetError(idTxt, string.Empty);
                                    //errorProvider1.SetError(nameTxt, string.Empty);

                                    clear();
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

        private void setObjectFromFieldValues(OtherAddress addr)
        {
            addr.OrderNumber = Int32.Parse(orderNumText.Text);
            addr.Address = sentaAddressTextbox.Text;
            addr.numOfMag = (int)numOfMagText.Value;
            addr.ContactName = contactNameText.Text;
            addr.Mobile = mobileText.Text;
            addr.Land = homeTpText.Text;
            addr.categoryID = categoryCombo.SelectedIndex;

        }


        private void setFieldValsues(OtherAddress addr)
        {
            orderNumText.Text = addr.OrderNumber.ToString();
            sentaAddressTextbox.Text = addr.Address;
            numOfMagText.Value = addr.numOfMag;
            contactNameText.Text = addr.ContactName;
            mobileText.Text = addr.Mobile;
            homeTpText.Text = addr.Land;
            categoryCombo.SelectedIndex = addr.categoryID;
        }



        private void clear()
        {
            addressID = 0;
            addbtn.Text = "Insert";
            deleteBtn.Enabled = false;

            sentaAddressTextbox.Clear();
            contactNameText.Clear();
            mobileText.Clear();
            homeTpText.Clear();

            orderNumText.Text = getNextOrderNumber().ToString();
            sentaAddressTextbox.Focus();
            categoryCombo.SelectedIndex = -1;
            setUserPermissions();
        }

        private bool ValidateBeforeAdd()
        {
            bool retVal = true;

            if (string.IsNullOrEmpty(sentaAddressTextbox.Text))
            {
                errorProvider1.SetError(sentaAddressTextbox, "Index Number cannot be empty");
                retVal = false;
            }
            else
            {
                errorProvider1.SetError(sentaAddressTextbox, "");
            }

            return retVal;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (OtherAddress occu = new OtherAddress(true))
            {
                occu.ID = addressID;

                //if (MessageView.ShowQuestionMsg("Delete Details of '" + nameTextBoxX.Text + "'") == DialogResult.OK)
                //{
                //    occu.Delete();
                //    clear();
                //    MessageView.ShowMsg("Sucessfully Deleted");
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
                using (OtherAddress addre = new OtherAddress(true))
                {
                    setObjectFromFieldValues(addre);

                    DataTable ds = addre.SelectFind();
                    frmSearch frmSub = new frmSearch(ds, this.Text,3,50);
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

                if (userLevel == DBCore.UserLevel.SystemAdmin || userLevel == DBCore.UserLevel.SystemUser_IUD)
                {
                    deleteBtn.Enabled = true;
                    addbtn.Text = "Update";
                }
            }
            frmSub.Dispose();
        }

        public void FillSearchFilds(Hashtable hashtable)
        {
            try
            {
                addressID = (int)hashtable["ID"];

                using (OtherAddress adr = new OtherAddress(true))
                {
                    adr.Select(addressID);

                    setFieldValsues(adr);
                }


            }
            catch (Exception ex)
            {
                MessageView.ExceptionError(ex);
            }
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
                addbtn.Enabled =  true;
            }
        }

        private void frmOccupatition_Load(object sender, EventArgs e)
        {

            try
            {
                Font sinhalaFont = new System.Drawing.Font(DBCore.Utility.GetAppsetting(DBCore.AppSetting.SinhalaFontName), 12);

                sentaAddressTextbox.Font = sentaAddressTextbox.Font = sinhalaFont;

            }
            catch { }


            refreshCategory();

            setUserPermissions();
            clear();
        }

        private void refreshCategory()
        {
            using (Category cat = new Category(true))
            {
                cat.BindToCombo(categoryCombo);
            }
        }

        private void orderNumText_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            orderNumText.ReadOnly = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusText.Visible = false;
            timer1.Enabled = false;
        }

        private int getNextOrderNumber()
        {
            using (OtherAddress occu = new OtherAddress(true))
            {
                return occu.getNextOrderNumber();
            }
        }

        private void numOfMagText_Enter(object sender, EventArgs e)
        {
            ((NumericUpDown)sender).Select(0, 2);
        }

        private void addCat_Click(object sender, EventArgs e)
        {
            frmCategory cat = new frmCategory((int)userLevel);

            cat.ShowDialog();

            refreshCategory();
        }
    }
}
