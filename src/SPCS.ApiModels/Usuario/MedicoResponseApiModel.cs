namespace SPCS.ApiModels.Usuario
{
    public class MedicoResponseApiModel : UsuarioResponseApiModel
    {
        public string Crm { get; set; }
    }

    public class EnfermeiroResponseApiModel : UsuarioResponseApiModel
    {
        public string Coren { get; set; }
    }

    public class PacienteResponseApiModel : UsuarioResponseApiModel
    {
        public EnderecoResponseApiModel Endereco { get; set; }
    }
}
