namespace SPCS.ApiModels.Usuario
{
    public class UsuarioLoginResponseApiModel
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public int ExpiresIn { get; set; }
        public UsuarioToken UsuarioToken { get; set; }
    }
}
