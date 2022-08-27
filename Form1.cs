using System;
using System.Windows.Forms;
using System.Text;
using System.Data;
namespace notetakingversion
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           table = new DataTable();
            table.Columns.Add("Title",typeof(string));
            table.Columns.Add("Messages", typeof(string));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Title"].Width = 130;
            
        }

        private void bttnnew_Click(object sender, EventArgs e)
        {
            txttitle.Clear();
            txtmessage.Clear();
        }

        private void bttnsave_Click(object sender, EventArgs e)
        {
            int count = table.Rows.Count;
            table.Rows.Add(txttitle.Text,txtmessage.Text);

            if(table.Rows.Count > 3)
            {
                bttnsave.Visible = false;
            }
            txttitle.Clear();
            txtmessage.Clear();

            count++;
        }

        private void bttnread_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if(index>-1)
            {
                txttitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtmessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void bttndelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}