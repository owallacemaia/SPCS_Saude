namespace SPCS.ApiModels.Usuario
{

    public class CadastrarPacienteRequestApiModel : CadastrarUsuarioRequestApiModel
    {
        public CadastrarEnderecoRequestApiModel Endereco { get; set; }
    }
}
