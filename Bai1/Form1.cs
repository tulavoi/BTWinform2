using System;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            dtpDateJoin.Format = DateTimePickerFormat.Short;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        bool itemsIsAdded = false;
        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCountry.SelectedIndex == 1 && !itemsIsAdded)
            {
                cboCountry.Items.Add("Pattaya");
                cboCountry.Items.Add("ChiengMai");
                cboCountry.Items.Add("Bangkok");
                itemsIsAdded = true;
            }
            if (cboCountry.SelectedIndex == 0)
            {
                cboCountry.Items.Remove("Pattaya");
                cboCountry.Items.Remove("ChiengMai");
                cboCountry.Items.Remove("Bangkok");
                itemsIsAdded = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string dob = txtDOB.Text;
            string address = txtAddress.Text.Trim();
            string city = lstCity.SelectedItem.ToString();
            string country = cboCountry.SelectedItem.ToString();
            string qualification = lstQualification.SelectedItem.ToString();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            int day = dtpDateJoin.Value.Day;
            int month = dtpDateJoin.Value.Month;
            int year = dtpDateJoin.Value.Year;
            DateTime dateJoining = new DateTime(year, month, day);
            MessageBox.Show($"Name: {name}\n" +
                $"Date of Birth: {dob}\n" +
                $"Address: {address}\n" +
                $"City: {city}\n" +
                $"Country: {country}\n" +
                $"Qualification: {qualification}\n" +
                $"Phone: {phone}\n" +
                $"Email: {email}\n" +
                $"Date of Joining: {dateJoining.ToShortDateString()}");
        }

        private void CheckListBox(ListBox listBox)
        {
            if (listBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(listBox, "Not selected yet");
                listBox.Focus();
            }
            else
                errorProvider1.Clear();
        }

        private void CheckTextBox(System.Windows.Forms.TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider1.SetError(textBox, "Can't be blank");
                textBox.Focus();
            }
            else
                errorProvider1.Clear();
        }

        private void lstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckListBox(lstCity);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox(txtEmail);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox(txtName);
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox(txtAddress);
        }
    }
}
