using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ass9
{
    public partial class Form1 : Form
    {
        private List<Vehicle> vehicleInventory;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Used to save inventory into list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveInventory_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle objVehicle;
                if (chkBoxNewCar.Checked)
                {
                    objVehicle = new Vehicle(vehicleInventory.Count + 1, txtYear.Text, txtMake.Text, txtModel.Text, txtVIN.Text);
                }
                else
                {
                    objVehicle = new Vehicle(vehicleInventory.Count + 1, txtYear.Text, txtMake.Text, txtModel.Text, txtMileage.Text, txtVIN.Text);
                }
                vehicleInventory.Add(objVehicle);
                ClearForms();
                objVehicle.ShowInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void chkBoxNewCar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxNewCar.Checked)
            {
                txtMileage.Clear();
                txtMileage.Enabled = false;
            }
            else
            {
                txtMileage.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vehicleInventory = new List<Vehicle>();
        }

        /// <summary>
        /// Used to clear form values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearForms_Click(object sender, EventArgs e)
        {
            try
            {
                ClearForms();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Used to delete item from list and reset id in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteInventory_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle objVehicle = new Vehicle(vehicleInventory.Count + 1, txtYear.Text, txtMake.Text, txtModel.Text, txtVIN.Text);
                var item = vehicleInventory.Where(x => x.Year == txtYear.Text && x.Make == txtMake.Text && x.Model == txtModel.Text && x.Vin == txtVIN.Text);
                if (item.Any())
                {
                    var searchedItems = item.Select(y => y).ToList();
                    #region Delete searched Item
                    foreach (var searchedItem in searchedItems)
                    {
                        vehicleInventory.Remove(searchedItem);
                    }
                    #endregion

                    #region Reset Ids
                    int initId = 0;
                    foreach (var itemListed in vehicleInventory)
                    {
                        itemListed.Id = ++initId;
                    }
                    #endregion
                    MessageBox.Show("Deleted successfully");
                }
                else
                {
                    MessageBox.Show("Cannot find a vehicle that matches your criteria to delete!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCheckInventory_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder objStringBuilder = new StringBuilder();
                objStringBuilder.AppendLine("Our Inventory has the following vehicles:");
                foreach (var item in vehicleInventory)
                {
                    objStringBuilder.AppendLine("#" + item.Id + " -" + item.Year + " " + item.Make + " " + item.Model + ",last 4 digits of VIN is " + item.Vin);
                }
                MessageBox.Show(objStringBuilder.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClearForms()
        {
            try
            {
                foreach (Control Cleartext in this.Controls)
                {
                    if (Cleartext is TextBox)
                    {
                        ((TextBox)Cleartext).Text = string.Empty;
                    }
                }
                chkBoxNewCar.Checked = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
