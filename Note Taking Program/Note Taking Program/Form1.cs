using System.Data;

namespace Note_Taking_Program
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
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 315;

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (textTitle.Text.Length > 0)
            {

                table.Rows.Add(textTitle.Text, textMessage.Text);

                textTitle.Clear();
                textMessage.Clear();

            }
            else if (textMessage.Text.Length > 0)
            {
                MessageBox.Show("Please enter in a Title before saving", "Unable to Save");
            }
            else
            {
                MessageBox.Show("Please enter in data before saving", "Unable to Save");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Refuses to save if there is no title. 
            if (textTitle.Text.Length > 0)
            {

                table.Rows.Add(textTitle.Text, textMessage.Text);

                textTitle.Clear();
                textMessage.Clear();

            }
            else if (textMessage.Text.Length > 0)
            {
                MessageBox.Show("Please enter in a Title before saving", "Unable to Save");
            }
            else
            {
                MessageBox.Show("Please enter in data before saving", "Unable to Save");
            }

        }
        private void buttonRead_Click(object sender, EventArgs e)
        {
            //Ensure there is data in the data grid
            if (dataGridView1.Rows.Count > 0)
            {
                int index = dataGridView1.CurrentCell.RowIndex;

                if (index > -1)
                {
                    textTitle.Text = table.Rows[index]["Title"].ToString();
                    textMessage.Text = table.Rows[index]["Messages"].ToString();
                }
            };
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Ensure there is data in the data grid
            if (dataGridView1.Rows.Count > 0) 
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                table.Rows[index].Delete();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textMessage.Text = "";
        }
    }
}