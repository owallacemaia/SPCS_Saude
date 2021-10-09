using FluentValidation;
using SPCS.Saude.Core.DomainObjects;
using System;

namespace SPCS.Saude.Business.Models
{
    public class Usuario : Entity, IAggregateRoot
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public string Imagem { get; private set; }
        public string Sexo { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Telefone { get; private set; }
        public string Escolaridade { get; private set; }
        public TipoUsuario TipoUsuario { get; private set; }

        //EF Constructor
        protected Usuario() { }



        public Usuario(Guid id, string nome, string email, string cpf, string imagem, 
                       char sexo, DateTime dataNascimento, string telefone, 
                       string escolaridade, Guid tipoUsuarioId)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Imagem = imagem;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Escolaridade = escolaridade;
            TipoUsuario = tipoUsuarioId;
        }

        public Usuario(Guid id, string nome, string email, string cpf, Guid tipoUsuario)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
            TipoUsuario = tipoUsuario;
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
