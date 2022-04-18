﻿using RentMe_App.Model;
using RentMe_App.UserControls.MemberDashboardUCs;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe_App.View.EmployeeModals
{
    /// <summary>
    /// Defines a form that allows employee to view order details
    /// </summary>
    public partial class ViewOrderModal : Form
    {
        #region Data Members

        private List<Furniture> _furnitureList;
        private OrdersController ordersController;
        private readonly int memberID = SharedFormInfo.MemberIDForm;
        private Order currentOrder;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public ViewOrderModal(Order selectedOrder)
        {
            InitializeComponent();
            ordersController = new OrdersController();
            currentOrder = selectedOrder;
            PopulateGridView();
        }

        #endregion

        #region Methods

        private void RentAgainButton_Click(object sender, System.EventArgs e)
        {
            //check to see if there's any available in the inventory
            //add to rental cart
        }

        private void ReturnButton_Click(object sender, System.EventArgs e)
        {
            //Add to return cart
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void PopulateGridView()
        {
            _furnitureList = ordersController.GetOrderFurnitureList(currentOrder).FurnitureList;
            foreach (Furniture furniture in _furnitureList)
            {
                //furnitureOrderedDataGridView.Rows.Add([add columns here]);
            }
        }

        #endregion
    }
}
