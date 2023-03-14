using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kasir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=db-kasir";
            string query = "INSERT INTO tb_barang(nama_barang,harga_barang,jumlah_barang)VALUES('" + this.tbNamaBarang.Text + "', '" + this.tbHargaBarang.Text + "', '" + this.tbJmlBarang.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully Saved");
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=db-kasir";
            string query = "UPDATE tb_barang SET nama_barang='" + this.tbNamaBarang.Text + "',harga_barang='" + this.tbHargaBarang.Text + "',jumlah_barang='" + this.tbJmlBarang.Text + "'WHERE kode_barang='" + this.tbKodeBarang.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record has been updated successfully");
            conn.Close();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=db-kasir";
            string query = "SELECT * FROM tb_barang";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=db-kasir";
            string query = "DELETE FROM tb_barang WHERE kode_barang='" + this.tbKodeBarang.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Data has been succesfully deleted!!");
            conn.Close();
        }
    }
}
