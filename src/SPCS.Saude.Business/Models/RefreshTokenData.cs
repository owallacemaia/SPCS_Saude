using NetDevPack.Domain;
using System;

namespace SPCS.Saude.Business.Models
{
    public class RefreshTokenData : Entity, IAggregateRoot
    {
        public string RefreshToken { get; private set; }
        public string Email { get; private set; }
        public DateTime Expires { get; private set; }
        public DateTime Created { get; private set; }

        public RefreshTokenData(string refreshToken, string email, DateTime expires, DateTime created)
        {
            RefreshToken = refreshToken;
            Email = email;
            Expires = expires;
            Created = created;
        }
    }
}
