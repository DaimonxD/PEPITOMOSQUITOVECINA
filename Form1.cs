using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PEPITOMOSQUITOVECINA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            string sql = @"
            SELECT P.ProductID, P.ProductName, C.Description
            FROM Products P
            INNER JOIN Categories C On P.CategoryID=C.CategoryID            
            ORDER BY P.ProductName
            ";

            string cadena = "Data Source=PEPITO.db";


            SQLiteDataAdapter adaptador = new SQLiteDataAdapter(sql, cadena);

            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);

            dataGridView1.DataSource = tabla;
        }
    }
}
