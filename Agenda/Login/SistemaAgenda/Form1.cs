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
    public partial class SISTEMAABC : Form
    {
        String usuario_digitado, usuario_banco, senha_digitada, senha_banco;      

        Int32 numero_de_usurio_cadastrado_no_banco = 0;

        private void btnAccess_Click(object sender, EventArgs e)
        {
            usuario_digitado = txtLogin.Text;
            senha_digitada = txtPassword.Text;

            Form2 f_tela_principal = new Form2();

            if (txtLogin.Text != "" & txtPassword.Text != "")
            {
                try
                {
                    Cl_Banco.conn.ConnectionString = Cl_Banco.connect;
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM Tb_Usuário");
                    cmd.Connection = Cl_Banco.conn;
                    Cl_Banco.conn.Open();
                    OleDbDataReader aReader = cmd.ExecuteReader();

                    while (aReader.Read())
                    {
                        numero_de_usurio_cadastrado_no_banco += -1;
                    }
                    Cl_Banco.conn.Close();

                    if (numero_de_usurio_cadastrado_no_banco == 0)
                    {
                        MessageBox.Show("Não há usuários cadastrados, \n " +
                        "vamos cadastrar um ...\n" +
                        "Preencha os campos LOGIN e PASSWORD \n" +
                        "depois pressione o botão ACCESS.");

                        Cl_Banco.conn.Close();
                        Cl_Banco.conn.ConnectionString = Cl_Banco.connect;
                        OleDbCommand cmd2 = new OleDbCommand("INSERT INTO Tb_Usuário(usuário_tc, senha_tc) VALUES ('" + txtLogin.Text + "', '" + txtPassword.Text + "')");
                        cmd2.Connection = Cl_Banco.conn;

                        Cl_Banco.conn.Open();
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Novo usuário cadastrado");
                        Cl_Banco.conn.Close();
                    }
                }
                catch
                { }

                finally
                {
                    Cl_Banco.conn.ConnectionString = Cl_Banco.connect;
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM Tb_Usuário WHERE usuário_tc = ('" + txtLogin.Text + "')");
                    cmd.Connection = Cl_Banco.conn;
                    Cl_Banco.conn.Open();
                    OleDbDataReader aReader = cmd.ExecuteReader();

                    while (aReader.Read())
                    {
                        usuario_banco = aReader.GetString(0);
                        senha_banco = aReader.GetString(1);
                    }

                    Cl_Banco.conn.Close();

                    if (usuario_banco == usuario_banco & senha_digitada == senha_banco)
                    {
                        f_tela_principal.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha incorretos :-(");
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha TODOS os campos! \n" + "Se for a primira vez que o programa é executador, \n" + "os usuários/senha digitados serão salvos no banco.");

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public SISTEMAABC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public class Cl_Banco
        {
            public static OleDbConnection conn = new OleDbConnection();
            public static String endereco_do_banco = @"C:\Users\jean.cnnunes\Downloads\teste.accdb";
            public static String connect = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + endereco_do_banco;
        }      
    }
}
