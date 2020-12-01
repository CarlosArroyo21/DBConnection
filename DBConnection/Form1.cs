using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True"))
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Conectado.", "", MessageBoxButtons.OK);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
    }
}
