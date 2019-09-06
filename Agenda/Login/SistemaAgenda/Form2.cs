using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaAgenda
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPag2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cl_Banco.conn.ConnectionString = Cl_Banco.connect;
            OleDbCommand cmd = new OleDbCommand("INSERT INTO tabela1(nome) VALUES ('" + txtNome.Text + "')");
            cmd.Connection = Cl_Banco.conn;

            Cl_Banco.conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Dado cadastrado");
            Cl_Banco.conn.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cl_Banco.conn.ConnectionString = Cl_Banco.connect;
            OleDbCommand cmd = new OleDbCommand("DELETE FROM tabela1 WHERE nome = ('" + txtNome.Text + "')");
            cmd.Connection = Cl_Banco.conn;

            Cl_Banco.conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Dado apagado");
            Cl_Banco.conn.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cl_Banco.conn.ConnectionString = Cl_Banco.connect;
            OleDbCommand cmd = new OleDbCommand("UPDATE tabela1 SET nome = ('" + txtNovoNome.Text + "' WHERE)" + "nome = ('"+ txtNome.Text+"')");
            cmd.Connection = Cl_Banco.conn;

            Cl_Banco.conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Dado atualizado");
            Cl_Banco.conn.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Cl_Banco.conn.ConnectionString = Cl_Banco.connect;
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tabela1 WHERE nome LIKE ('" + txtNome.Text + "%') ORDER BY nome ASC");
            cmd.Connection = Cl_Banco.conn;
            Cl_Banco.conn.Open();
            OleDbDataReader aReader = cmd.ExecuteReader();
            txtTel.Text = ("Os valores retordados da tabela são:");


            while (aReader.Read())
            {
                txtTel.Text += Environment.NewLine + (aReader.GetString(0));
            }
            Cl_Banco.conn.Close();
        }
        public class Cl_Banco
        {
            public static OleDbConnection conn = new OleDbConnection();
            public static String endereco_do_banco = @"C:\User\jean.cnnunes\Downloads\teste(1).accdb";
            public static String connect = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + endereco_do_banco;
        }
    }
}
