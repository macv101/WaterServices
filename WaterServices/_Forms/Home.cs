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
        IProductBus productBus;

        public Home()
        {
            InitializeComponent();
            this.KeyPreview = true;
            accountBus = new AccountLogBus();
            productBus = new ProductBus();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            dtFilterFrom.Value = DateTime.Today;
            dtFilterTo.Value = DateTime.Today;
            Console.WriteLine(dtFilterTo);
            load_DataGrid(accountBus.getAccountLogs(name: "", from: dtFilterFrom.Value, to: dtFilterTo.Value.AddDays(1).AddTicks(-1)));
            load_comboBox(productBus.getProductContainers(), cbxGridContainer);
            load_comboBox(productBus.getProductTypes(), cbxGridType);
            load_comboBox(productBus.getProductVolumes(), cbxGridVolume);
            txtSearch.Text = "Search Name";
            txtSearch.ForeColor = Color.Gray;
            txtScan.Text = "Scan Code";
            txtScan.ForeColor = Color.Gray;
        }

        #region Form Event Functions

        /*
         * Grid Events
         */ 
        private void dgvHome_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected ||
                dgvHome.SelectedCells.Count == 0) return;
            populate_GridEdit();
        }

        private void dtFilterFrom_ValueChanged(object sender, EventArgs e)
        {
            dtFilterTo.Value = isValidDateRange(dtFilterFrom.Value, dtFilterTo.Value) ? dtFilterTo.Value : dtFilterFrom.Value;
            load_DataGrid(accountBus.getAccountLogs(name: "", from: dtFilterFrom.Value, to: dtFilterTo.Value.AddDays(1).AddTicks(-1)));
        }

        private void dtFilterTo_ValueChanged(object sender, EventArgs e)
        {
            dtFilterTo.Value = isValidDateRange(dtFilterFrom.Value, dtFilterTo.Value) ? dtFilterTo.Value : dtFilterFrom.Value;
            load_DataGrid(accountBus.getAccountLogs(name: "", from: dtFilterFrom.Value, to: dtFilterTo.Value.AddDays(1).AddTicks(-1)));
        }

        /*
         * Button Events
         */ 
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_DataGrid(accountBus.getAccountLogs(name: "", from: dtFilterFrom.Value, to: dtFilterTo.Value));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text;
            load_DataGrid(accountBus.getAccountLogs(name));
        }

        private void btnGridCancel_Click(object sender, EventArgs e)
        {
            populate_GridEdit();
        }

        /*
         * TextBox Events
         */ 
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            txtSearch.Text = txt == "Search Name" ? "" : txt;
            txtSearch.ForeColor = Color.Black;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            if(txt == "") 
            {
                txtSearch.Text = "Search Name";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void txtScan_Enter(object sender, EventArgs e)
        {
            string txt = txtScan.Text;
            txtScan.Text = txt == "Scan Code" ? "" : txt;
            txtScan.ForeColor = Color.Black;
        }

        private void txtScan_Leave(object sender, EventArgs e)
        {
            string txt = txtScan.Text;
            if (txt == "")
            {
                txtScan.Text = "Scan Code";
                txtScan.ForeColor = Color.Gray;
            }
        }

        private void txtScan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine(txtScan.Text);
                DataTable product = productBus.getProducts(txtScan.Text);
                if(product.Rows.Count > 0) lblProductDescription.Text = 
                        string.Format("{0} {1} {2} at {3} each", 
                            product.Rows[0].Field<string>("sUnitDescription"),
                            product.Rows[0].Field<string>("sName"),
                            product.Rows[0].Field<string>("sType"),
                            product.Rows[0].Field<object>("fPrice")
                            );
            } 
        }   

        #endregion

        #region Custom Private Functions

        private void load_DataGrid(DataTable dataSource)
        {
            dgvHome.DataSource = dataSource;
            dgvHome.Columns["dDate"].HeaderText = "Date";
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
            dgvHome.Columns["ContainerCode"].Visible = false;
            dgvHome.Columns["TypeCode"].Visible = false;
            dgvHome.Columns["VolumeCode"].Visible = false;
            dgvHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void load_comboBox(DataTable dataSource, ComboBox cbx)
        {
            cbx.DisplayMember = dataSource.Columns[1].ColumnName;
            cbx.ValueMember = dataSource.Columns[0].ColumnName;
            cbx.DataSource = dataSource;
        }

        private void populate_GridEdit()
        {
            int selectedrowindex = dgvHome.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvHome.Rows[selectedrowindex];
            if (selectedRow == null) return;
            DateTime date = Convert.ToDateTime(selectedRow.Cells["dDate"].Value == System.DBNull.Value ? DateTime.Today : selectedRow.Cells["dDate"].Value);
            dtGridDate.Value = dtGridTime.Value = date;
            txtGridCompany.Text = Convert.ToString(selectedRow.Cells["sCompany"].Value);
            txtGridFirstName.Text = Convert.ToString(selectedRow.Cells["sFirstName"].Value);
            txtGridLastName.Text = Convert.ToString(selectedRow.Cells["sLastName"].Value);
            cbxGridContainer.SelectedValue = selectedRow.Cells["ContainerCode"].Value;
            cbxGridType.SelectedValue = selectedRow.Cells["TypeCode"].Value;
            cbxGridVolume.SelectedValue = selectedRow.Cells["VolumeCode"].Value;
        }

        private bool isValidDateRange(DateTime from, DateTime to) 
        {
            if (dtFilterTo.Value < dtFilterFrom.Value)
            {
                // TODO: Create Alert for Invalid Date Range notice. 
                return false;
            }

            return true;
        }

        #endregion
    }
}
