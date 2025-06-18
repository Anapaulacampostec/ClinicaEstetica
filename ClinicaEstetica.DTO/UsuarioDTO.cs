namespace ClinicaEstetica.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public int IdTipoUsuario { get; set; }
        public string Usuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Status { get; set; }
    }
}
