﻿using System.Collections.Generic;

namespace SPCS.ApiModels.Usuario
{
    public class UsuarioToken
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public IEnumerable<UsuarioClaim> Claims { get; set; }
    }
}
