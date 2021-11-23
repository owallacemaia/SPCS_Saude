using SPCS.Saude.Core.DomainObjects;
using System;

namespace SPCS.Saude.Business.Models
{
    public class RefreshTokenData : Entity, IAggregateRoot
    {
        public string RefreshToken { get; set; }
        public string Email { get; set; }
        public DateTime Expires { get; set; }
        public DateTime Created { get; set; }

        public RefreshTokenData(string refreshToken, string email, DateTime expires, DateTime created)
        {
            RefreshToken = refreshToken;
            Email = email;
            Expires = expires;
            Created = created;
        }
    }
}
