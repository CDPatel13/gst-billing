using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GST_Billing
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            Invoice generateInvoice = new Invoice();
            DialogResult result = generateInvoice.ShowDialog();
        }

        private void btnEditInvoice_Click(object sender, EventArgs e)
        {
            // TODO : Edit existing invoice
            if(dgvInvoice.SelectedRows.Count > 0)
            {
                int index = dgvInvoice.SelectedRows[0].Index;
                dgvInvoice.ClearSelection();
                dgvInvoice.Rows[index].Selected = true;
            }
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            // TODO : Delete selected invoice
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            // TODO : print selected invoice
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO : fill datagrid with data from DB

            // UI : Select first row
            if (dgvInvoice.RowCount > 0)
                dgvInvoice.Rows[0].Selected = true;
        }
    }
}
