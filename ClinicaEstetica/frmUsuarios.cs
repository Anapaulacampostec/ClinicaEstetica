using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaEstetica.BLL;
using ClinicaEstetica.DTO;

namespace ClinicaEstetica
{
    public partial class frmUsuarios : Form
    {
       private UsuarioBLL usuarioBLL = new UsuarioBLL();
       private UsuarioDTO usuarioDTO = new UsuarioDTO();
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void CarregarUsuarios()
        {
            var ususarios = usuarioBLL. ListarTodosUsuarios();
            dgvUsuarios.DataSource = ususarios;
            dgvUsuarios.ClearSelection();
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            cboTipo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            chkStatus.Checked = false;

            
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
            cboTipo.DisplayMember = "Nome";
            cboTipo.DataSource = usuarioBLL.GetTipoUsuario();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count>0)
            {
                var usuario = (UsuarioDTO)dgvUsuarios.SelectedRows[0].DataBoundItem;
                usuarioDTO = usuario;

                txtId.Text = usuario.IdUsuario.ToString();
                var tipo = usuario.IdTipoUsuario == 1 ? "Administrador" : "Operador";
                cboTipo.Text = tipo;

                txtNome.Text = usuario.Nome.ToString();
                txtEmail.Text = usuario.Email.ToString();
                txtSenha.Text = usuario.Senha.ToString();
                chkStatus.Checked = usuario.Status;
            }
        }
    }
}
