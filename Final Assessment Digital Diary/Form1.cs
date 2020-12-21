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
         int eventid = 0;

        public Form1()
        {
            InitializeComponent();
            addEventButton.Click += this.RefreshEventGridView;
            addEventButton.Click += this.ClearFields;

            UpdateButton.Click += this.RefreshEventGridView;
            UpdateButton.Click += this.ClearFields;

            deleteTextBox1.Click += this.RefreshEventGridView;
            deleteTextBox1.Click += this.ClearFields;
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
         

            EventService eventService = new EventService();
            int result = eventService.AddNewEvent(addTitletextBox.Text, addcomboBox.Text,addEventTextBox.Text, adddateTimePicker.Text);
            if (result > 0)
            {
                MessageBox.Show("Event added successfully.");

            }
            else
            {
                MessageBox.Show("Error in adding Event");
            }
        }

        private void loadEventsdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eventid = (int)loadEventsdataGridView1.Rows[e.RowIndex].Cells[0].Value;
            updateTextBox.Text = loadEventsdataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
           
        }

        void RefreshEventGridView(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            loadEventsdataGridView1.DataSource = eventService.GetCreateEvenstList();
        }

        void ClearFields(object sender, EventArgs e)
        {
            
            addTitletextBox.Text= addcomboBox.Text=addEventTextBox.Text= adddateTimePicker.Text = UpdateButton.Text = string.Empty;
        }

        

        void RefreshGridView(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            loadEventsdataGridView1.DataSource = eventService.GetCreateEvenstList();
        }

        private void deteEvent_Click(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            int result = eventService.DeleteEvent(Convert.ToInt32( deleteTextBox1.Text));
            if (result > 0)
            {
                MessageBox.Show("Event Deleted successfully.");

            }
            else
            {
                MessageBox.Show("Error in Deleting Event");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            int result = eventService.UpdateEvent(eventid, updateTextBox.Text);
            if (result > 0)
            {
                MessageBox.Show("Event Upadted successfully.");

            }
            else
            {
                MessageBox.Show("Error in Updating Event");
            }
        }
    }
}
