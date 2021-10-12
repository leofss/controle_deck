using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNOVO_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            try
            {
                conexao.novo(txtNome.Text, txtTipo.Text);
                MessageBox.Show("Carta Cadastrada.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.close();
            }
        }

        private void btnEXIBIR_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            try
            {
                dgvDados.DataSource = conexao.exibir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEDITAR_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            try
            {
                conexao.editar(txtID.Text, txtNome.Text, txtTipo.Text);
                MessageBox.Show("Carta alterada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.close();
            }
        }

        private void btnEXCLUIR_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            try
            {
                conexao.excluir(txtID.Text);
                MessageBox.Show("Carta excluida");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.close();
            }
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            try
            {
                MySqlDataReader dr = conexao.consultar(txtID.Text);

                while (dr.Read())
                {
                    txtNome.Text = Convert.ToString(dr["nome"]);
                    txtTipo.Text = Convert.ToString(dr["nome"]);

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.close();
            }

        }
    }
}
