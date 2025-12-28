using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VpProject_PoS
{
    public partial class PoS_System : Form
    {
        private int currentInvoiceID = 1001;
        private decimal grandTotal = 0;
        public PoS_System()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void PoS_System_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ProductID", "Product ID");
                dataGridView1.Columns.Add("ProductName", "Name");
                dataGridView1.Columns.Add("Qty", "Qty");
                dataGridView1.Columns.Add("Price", "Price");
                dataGridView1.Columns.Add("SubTotal", "SubTotal");
            }

            // 2. Set initial Date and Invoice Number
            label4.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
            label3.Text = currentInvoiceID.ToString();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
            PoS_System newInvoiceForm = new PoS_System();
            newInvoiceForm.Show();
            this.Close();

            // Increment the ID locally for the next "New" invoice
            currentInvoiceID++;
            label3.Text = currentInvoiceID.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox8.Text, out decimal price))
            {
                int qty = (int)numericUpDown1.Value;
                decimal rowSubtotal = price * qty;

                // Add data to the DataGridView (the grey area in your image)
                // Column Order: ProductID, Name, Qty, Price, SubTotal
                dataGridView1.Rows.Add(comboBox2.Text, textBox7.Text, qty, price, rowSubtotal);

                UpdateGrandTotal();
            }
            else
            {
                MessageBox.Show("Please enter a valid price.");
            }
        }

        private void UpdateGrandTotal()
        {
            grandTotal = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    grandTotal += Convert.ToDecimal(row.Cells[4].Value);
                }
            }
            // Label 17 displays the auto-calculated sum
            label17.Text = grandTotal.ToString("0:00");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Without SQL, we display a success message and trigger the print dialog
            string summary = $"Invoice #{label3.Text} Saved Locally!\nTotal: {label17.Text}";
            MessageBox.Show(summary, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            PrintInvoice();
        }

        // --- PRINTING LOGIC ---
        private void PrintInvoice()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPageDesign);
            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = pd };
            ppd.ShowDialog();
        }

        private void PrintPageDesign(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 12);

            g.DrawString("ARIAN'S CAFETERIA RECEIPT", headerFont, Brushes.Black, 50, 50);
            g.DrawString($"Date: {label4.Text}", bodyFont, Brushes.Black, 50, 90);
            g.DrawString($"Invoice No: {label3.Text}", bodyFont, Brushes.Black, 50, 110);
            g.DrawString("------------------------------------------", bodyFont, Brushes.Black, 50, 140);
            g.DrawString($"Total Amount: ${label17.Text}", headerFont, Brushes.Black, 50, 170);
            g.DrawString("Thank you for your visit!", bodyFont, Brushes.Black, 50, 210);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox1.Clear();
            textBox2.Clear();
            comboBox2.Text = "";
            textBox7.Clear();
            textBox8.Clear();
            numericUpDown1.Value = 0;
            dataGridView1.Rows.Clear();
            label17.Text = "0.00";
            grandTotal = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
        }
    }
}
