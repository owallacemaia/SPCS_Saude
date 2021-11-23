using FluentValidation;
using SPCS.Saude.Core.DomainObjects;
using System;

namespace SPCS.Saude.Business.Models
{
    public class Usuario : Entity, IAggregateRoot
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Imagem { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public bool Ativo { get; set; }

        //EF Constructor
        protected Usuario() { }

        public Usuario(Guid id, string nome, string email, string cpf, string sexo, DateTime dataNascimento, string telefone, TipoUsuario tipoUsuario)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            TipoUsuario = tipoUsuario;
            Ativo = true;
        }

        internal bool EhValido()
        {
            ValidationResult = new UsuarioValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }

    public class UsuarioValidation : AbstractValidator<Usuario>
    {
        public UsuarioValidation()
        {
            RuleFor(a => a.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode estar vázio!");

            RuleFor(a => a.Cpf)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode estar vázio!")
                .Matches(@"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})").WithMessage("O campo {PropertyName} esta invalido!");
        }
    }
}
