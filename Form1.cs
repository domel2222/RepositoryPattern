using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;

namespace RepositoryPattern
{
    public partial class Form1 : Form
    {
        IProductRepository _productRepository;
        public Form1(IProductRepository productRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            ////SqlConnection con = new SqlConnection("Server=LAPTOP-R3P7DCQ0\\SQLEXPRESS;Database=northwind;User Id=Dominik;Password=Dominik6000");
            ////Console.WriteLine(con.State.ToString());
            ////SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            ////con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ////con.Open();
            ////con.BeginTransaction("Select * from Products");

            ////dataGridView1.DataSource = productRepository.GetProduct();
            //dataGridView1.DataSource = "ffffffdhgdfhfgjfgjfhjfgkj";
            //MessageBox.Show("Connection ok");

            //Console.ReadKey();
            ////lblTotalRecord.Text = $"Total records: {dataGridView1.RowCount}";

        }

        private void lblTotalRecord_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productRepository.GetProduct();
            lblTotalRecord.Text = $"Total record: {dataGridView1.RowCount}";

        }
    }
}
