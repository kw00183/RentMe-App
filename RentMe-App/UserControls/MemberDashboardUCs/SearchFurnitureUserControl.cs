using RentMe_App.Controller;
using RentMe_App.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RentMe_App.UserControls
{
    /// <summary>
    /// user control class that encapsulates the search furniture controls
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public partial class SearchFurnitureUserControl : UserControl
    {
        #region Data members

        private readonly FurnitureController furnitureController;
        private readonly StyleController styleController;
        private readonly CategoryController categoryController;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create the search furniture controls
        /// </summary>
        public SearchFurnitureUserControl()
        {
            InitializeComponent();
            furnitureController = new FurnitureController();
            styleController = new StyleController();
            categoryController = new CategoryController();

            ClearForm();
        }

        #endregion

        #region Methods

        private void PopulateStyleComboBox()
        {
            styleComboBox.DataSource = GetStyleList();
            styleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            styleComboBox.DisplayMember = "Name";
            styleComboBox.SelectedIndex = 0;
        }

        private List<Style> GetStyleList()
        {
            List<Style> newList = styleController.GetAllStyles();
            newList.Insert(0, new Style("--Select--"));
            return newList;
        }

        private string GetStyleSelected()
        {
            int styleIndexSelected = styleComboBox.SelectedIndex;
            return GetStyleList()[styleIndexSelected].Name;
        }

        private void PopulateCategoryComboBox()
        {
            categoryComboBox.DataSource = GetCategoryList();
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.SelectedIndex = 0;
        }

        private List<Category> GetCategoryList()
        {
            List<Category> newList = categoryController.GetAllCategories();
            newList.Insert(0, new Category("--Select--"));
            return newList;
        }

        private string GetCategorySelected()
        {
            int categoryIndexSelected = categoryComboBox.SelectedIndex;
            return GetCategoryList()[categoryIndexSelected].Name;
        }

        private void RefreshSearchDataGrid()
        {
            searchFurnitureDataGridView.DataSource = null;

            try
            {
                bool getFurnitureCheck = Int32.TryParse(furnitureIDTextBox.Text, out int furnitureID);
                string selectedStyleName = GetStyleSelected();
                string selectedCategoryName = GetCategorySelected();

                List<Furniture> furnitureList;

                if (getFurnitureCheck == true && furnitureID > 0)
                {
                    furnitureList = furnitureController.GetFurnitureByID(furnitureID);
                    CheckFurnitureFound(furnitureList);
                }
                else if (styleComboBox.SelectedIndex > 0 && categoryComboBox.SelectedIndex == 0)
                {
                    furnitureList = furnitureController.GetFurnitureByStyle(selectedStyleName);
                    CheckFurnitureFound(furnitureList);
                }
                else if (styleComboBox.SelectedIndex == 0 && categoryComboBox.SelectedIndex > 0)
                {
                    furnitureList = furnitureController.GetFurnitureByCategory(selectedCategoryName);
                    CheckFurnitureFound(furnitureList);
                }
                else if (styleComboBox.SelectedIndex > 0 && categoryComboBox.SelectedIndex > 0)
                {
                    furnitureList = furnitureController.GetFurnitureByCategoryStyle(selectedCategoryName, selectedStyleName);
                    CheckFurnitureFound(furnitureList);
                }
                else if (getFurnitureCheck == true && furnitureID <= 0)
                {
                    ClearDataGridView();
                    string errorMessage = "Furniture ID must be number greater than 0";
                    ShowInvalidErrorMessage(errorMessage);
                }
                else if (getFurnitureCheck == false && furnitureIDTextBox.Text.Length > 0)
                {
                    ClearDataGridView();
                    string errorMessage = "Furniture ID must be number";
                    ShowInvalidErrorMessage(errorMessage);
                }
                else
                {
                    ClearDataGridView();
                    string errorMessage = "Selection must be made to return result";
                    ShowInvalidErrorMessage(errorMessage);
                }
            }
            catch (Exception)
            {
                string errorMessage = "Invalid Logic";
                ShowInvalidErrorMessage(errorMessage);
            }
        }

        private void AdjustColumnOrder()
        {
            //searchFurnitureDataGridView.Columns["image_small_url"].DisplayIndex = 0;
            searchFurnitureDataGridView.Columns["furnitureID"].DisplayIndex = 1;
            searchFurnitureDataGridView.Columns["name"].DisplayIndex = 2;
            searchFurnitureDataGridView.Columns["description"].DisplayIndex = 3;
            searchFurnitureDataGridView.Columns["daily_rental_rate"].DisplayIndex = 4;
            searchFurnitureDataGridView.Columns["daily_fine_rate"].DisplayIndex = 5;
            searchFurnitureDataGridView.Columns["category_name"].DisplayIndex = 6;
            searchFurnitureDataGridView.Columns["style_name"].DisplayIndex = 7;
            searchFurnitureDataGridView.Columns["image_large_url"].Visible = false;
            searchFurnitureDataGridView.Columns["image_small_url"].Visible = false;
        }

        private void CheckFurnitureFound(List<Furniture> furnitureList)
        {
            if (furnitureList.Count > 0)
            {
                searchFurnitureDataGridView.DataSource = furnitureList;
                AdjustColumnOrder();
            }
            else
            {
                string errorMessage = "No furniture found";
                ShowInvalidErrorMessage(errorMessage);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            RefreshSearchDataGrid();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            searchFurnitureDataGridView.DataSource = null;
            furnitureIDTextBox.Text = "";
            PopulateStyleComboBox();
            PopulateCategoryComboBox();
            HideErrorMessage();
        }

        private void ClearDataGridView()
        {
            searchFurnitureDataGridView.Rows.Clear();
            searchFurnitureDataGridView.Refresh();
        }

        private void HideErrorMessage()
        {
            errorMessageLabel.Text = "";
        }

        private void ShowInvalidErrorMessage(string message)
        {
            errorMessageLabel.Text = message;
            errorMessageLabel.ForeColor = Color.Red;
        }

        private void FurnitureID_Enter(object sender, EventArgs e)
        {
            categoryComboBox.SelectedIndex = 0;
            styleComboBox.SelectedIndex = 0;
            HideErrorMessage();
        }

        private void StyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (furnitureIDTextBox.Text != "")
            {
                furnitureIDTextBox.Text = "";
            }
            HideErrorMessage();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (furnitureIDTextBox.Text != "")
            {
                furnitureIDTextBox.Text = "";
            }
            HideErrorMessage();
        }

        private void SearchFurnitureDataGridView_VisibleChanged(object sender, EventArgs e)
        {
            ClearForm();
        }

        #endregion
    }
}
