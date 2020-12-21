using Final_Assessment_Digital_Diary.Business_Logic_Leyar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Assessment_Digital_Diary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            ///okay,we can start work.///
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EventService eventService =  new EventService();
            loadEventsdataGridView1.DataSource = eventService.GetCreateEvenstList();

        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            /*
            EventService eventService = new EventService();
            int result = eventService.ad(addProductNameTextBox.Text, addPriceTextBox.Text, addQuantityTextBox.Text, addProductCategoryComboBox.Text);
            if (result > 0)
            {
                MessageBox.Show("Proudct added successfully.");

            }
            else
            {
                MessageBox.Show("Error in adding product");
            }
            */

            EventService eventService = new EventService();
            int result = eventService.AddNewEvent(addTitletextBox.Text, addImportancetextBox.Text,addEventTextBox.Text);
            if (result > 0)
            {
                MessageBox.Show("Event added successfully.");

            }
            else
            {
                MessageBox.Show("Error in adding Event");
            }
        }
    }
}
