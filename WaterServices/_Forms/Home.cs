using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaterServices._Bus;

namespace WaterServices
{
    public partial class Home : Form
    {

        IAccountLogBus accountBus;
        public Home()
        {
            InitializeComponent();
            accountBus = new AccountLogBus();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            load_DataGrid(accountBus.getAccountLogs());
           
            
        }

        private void load_DataGrid(DataTable dataSource)
        {
            dgvHome.DataSource = dataSource;
            dgvHome.Columns["sCompany"].HeaderText = "Company";
            dgvHome.Columns["sFirstName"].HeaderText = "First Name";
            dgvHome.Columns["sLastName"].HeaderText = "Last Name";
            dgvHome.Columns["sCode"].HeaderText = "Product";
            dgvHome.Columns["sPhone"].HeaderText = "Phone";
            dgvHome.Columns["iQuantity"].HeaderText = "Quantity";
            dgvHome.Columns["iInterval"].HeaderText = "Interval";
            dgvHome.Columns["fPrice"].HeaderText = "Price";
            dgvHome.Columns["kClient"].Visible = false;
            dgvHome.Columns["kProduct"].Visible = false;
            dgvHome.Columns["sName"].Visible = false;
            dgvHome.Columns["sType"].Visible = false;
            dgvHome.Columns["fAmount"].Visible = false;
            dgvHome.Columns["sUnit"].Visible = false;
            
        }

        private void dgvHome_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // For any other operation except, StateChanged, do nothing
            if (e.StateChanged != DataGridViewElementStates.Selected ||
                dgvHome.SelectedCells.Count == 0) return;
            int selectedrowindex = dgvHome.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvHome.Rows[selectedrowindex];
            txtGridCompany.Text = Convert.ToString(selectedRow.Cells["sCompany"].Value);
            txtGridCompany.Text = Convert.ToString(selectedRow.Cells["sCompany"].Value);
            txtGridFirstName.Text = Convert.ToString(selectedRow.Cells["sFirstName"].Value);
            txtGridLastName.Text = Convert.ToString(selectedRow.Cells["sLastName"].Value);
            //txtGrideContainer.Text = Convert.ToString(selectedRow.Cells["sCode"].Value);
            //txtGridPhone.Text = Convert.ToString(selectedRow.Cells["sPhone"].Value);
            //txtGridQuantity.Text = Convert.ToString(selectedRow.Cells["iQuantity"].Value);
            //txtGridInterval.Text = Convert.ToString(selectedRow.Cells["iInterval"].Value);
            //txtGridPrice.Text = Convert.ToString(selectedRow.Cells["fPrice"].Value);

           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_DataGrid(accountBus.getAccountLogs());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text;
            load_DataGrid(accountBus.getAccountLogs(name));
        }

    }
}
