using Desktop_DaviESilva_F0450H6.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_DaviESilva_F0450H6
{
    public partial class frmDesktop : Form
    {
        public frmDesktop()
        {
            InitializeComponent();
            controlador = new DesktopController();
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {

        }

        private DesktopController controlador;
        private int? idSelecionado;

        private void LimparCampos()
        {
            idSelecionado = null;
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtBirthday.Text = "";
            txtDocument.Text = "";
            btnDel.Enabled = false;
        }
        private void ListarTodos()
        {
            dgvData.DataSource = controlador.ListarTodos().Tables[0];
            dgvData.ClearSelection();
        }

        private void frmDesktop_Load(object sender, EventArgs e)
        {
            ListarTodos();
            txtUsername.Select();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username;
            string email;
            string password;
            string document;
            string birthday;

            if (txtUsername.Text != "")
            {
                username = txtUsername.Text;
            }
            else
            {
                MessageBox.Show("Informe o Usuário.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }
            if (txtEmail.Text != "")
            {
                email = txtEmail.Text;
            }
            else
            {
                MessageBox.Show("Informe o email.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            if (txtPassword.Text != "")
            {
                password = txtPassword.Text;
            }
            else
            {
                MessageBox.Show("Informe a Senha.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }
            if (txtDocument.Text != "")
            {
                document = txtDocument.Text;
            }
            else
            {
                MessageBox.Show("Informe o documento.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocument.Focus();
                return;
            }
            if (txtBirthday.Text != "")
            {
                birthday = txtBirthday.Text;
            }
            else
            {
                MessageBox.Show("Informe a data de nascimento.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBirthday.Focus();
                return;
            }

            User user = new User(username, email, password, document, birthday);
            controlador.Salvar(user);
            LimparCampos();
            ListarTodos();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            controlador.Excluir(idSelecionado.Value);
            LimparCampos();
            ListarTodos();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ListarTodos();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];
                idSelecionado = int.Parse(row.Cells["IDUSER"].Value.ToString());
                txtUsername.Text = row.Cells["USERNAME"].Value.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                txtPassword.Text = row.Cells["PASSWORD"].Value.ToString();
                txtDocument.Text = row.Cells["DOCUMENT"].Value.ToString();
                txtBirthday.Text = row.Cells["BIRTHDAY"].Value.ToString();

                btnDel.Enabled = true;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        //private double CalcularTotal()
        //{
        //    double total = 0;
        //    foreach (DataGridViewRow row in dgvDados.Rows)
        //    {
        //        double valor = (double)row.Cells["VALOR"].Value;
        //        total += valor;
        //    }
        //    return total;
        //}
    }
}
