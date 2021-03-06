using RentMe_App.Controller;
using RentMe_App.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RentMe_App.View.AdminModals
{
    /// <summary>
    /// Class for employee adding modal.
    /// </summary>
    public partial class AddEmployeeModal : Form
    {
        #region Data Members

        private readonly EmployeeController _employeeController;
        private readonly StatesController _statesController;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for class.
        /// </summary>
        public AddEmployeeModal()
        {
            InitializeComponent();
            _employeeController = new EmployeeController();
            _statesController = new StatesController();
            PopulateFields();
        }

        #endregion

        #region Methods

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Validation();
                Employee newEmployee = new Employee()
                {
                    FName = fNameTextBox.Text,
                    LName = lNameTextBox.Text,
                    Sex = sexComboBox.SelectedValue.ToString(),
                    Address1 = address1TextBox.Text,
                    Address2 = address2TextBox.Text,
                    City = cityTextBox.Text,
                    State = stateComboBox.SelectedValue.ToString(),
                    Zip = zipTextBox.Text,
                    BirthDate = dateTimePicker.Value,
                    Phone = RemovePhoneSpecialCharacters(phoneTextBox.Text),
                    Password = passwordTextBox.Text,
                    IsActive = activeCheckbox.Checked,
                    Username = usernameTextBox.Text,
                    IsAdmin = isAdminCheckbox.Checked,
                };
                newEmployee.EmployeeId = _employeeController.AddEmployee(newEmployee);
                errorLabel.Text = "Employee #" + newEmployee.EmployeeId + " added!";
            }
            catch (SqlException)
            {
                errorLabel.Text = "Username already exists";
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            fNameTextBox.Text = "";
            lNameTextBox.Text = "";
            sexComboBox.SelectedIndex = 0;
            address1TextBox.Text = "";
            address2TextBox.Text = "";
            cityTextBox.Text = "";
            stateComboBox.SelectedIndex = 0;
            zipTextBox.Text = "";
            dateTimePicker.Value = DateTime.Today;
            phoneTextBox.Text = "";
            passwordTextBox.Text = "";
            activeCheckbox.Checked = false;
            errorLabel.Text = "";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void PopulateFields()
        {
            var sex = new List<string>() { "--Select--", "female", "male", "other" };
            sexComboBox.DataSource = new BindingSource(sex, null);

            var states = new List<string>() { "--Select--" };
            states.AddRange(_statesController.GetStatesList().StatesList);
            stateComboBox.DataSource = new BindingSource(states, null);

            activeCheckbox.Checked = true;
        }

        private void Validation()
        {
            if (fNameTextBox.Text == "" ||
                lNameTextBox.Text == "" ||
                sexComboBox.SelectedIndex == 0 ||
                address1TextBox.Text == "" ||
                cityTextBox.Text == "" ||
                stateComboBox.SelectedIndex == 0 ||
                zipTextBox.Text == "" ||
                phoneTextBox.Text == "" ||
                passwordTextBox.Text == "" ||
                confirmPasswordTextBox.Text == "")
            {
                throw new ArgumentException("Must populate required fields");
            }
            else if (passwordTextBox.Text != "" && passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                throw new ArgumentException("Make sure your password fields match");
            }
        }

        private string RemovePhoneSpecialCharacters(string phone)
        {
            var stringPhone = phone;
            var charactersToRemove = new string[] { " ", ".", "-", ")", "(", "'" };
            foreach (var c in charactersToRemove)
            {
                stringPhone = stringPhone.Replace(c, string.Empty);
            }
            return stringPhone;
        }

        #endregion

        private void ClearError(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }
    }
}
