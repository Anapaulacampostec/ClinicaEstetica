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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = textEmail.Text;
            string senha = textSenha.Text;

            UsuarioDTO usuarioDTO = new UsuarioDTO();
            UsuarioBLL usuarioBLL = new UsuarioBLL();

            usuarioDTO = usuarioBLL.AutenticarUsuario(email,senha);

            if (usuarioDTO != null)
            {
                MessageBox.Show($"Bem-vindo(a) {usuarioDTO.Nome}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show($"Não foi possível efetuar o logi, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
