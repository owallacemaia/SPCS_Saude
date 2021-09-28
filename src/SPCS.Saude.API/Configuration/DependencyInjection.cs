using Microsoft.Extensions.DependencyInjection;
using SPCS.Saude.API.Services;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Services;
using SPCS.Saude.Infra.Repository;

namespace SPCS.Saude.API.Configuration
{
    public static class DependencyInjection
    {
        public static void RegistrarDependencias(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            //Usuario
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<AccessManager>();

            //Paciente
            services.AddScoped<IPacienteRepository, PacienteRepository>();
            services.AddScoped<IPacienteService, PacienteService>();

            //Medico
            services.AddScoped<IMedicoRepository, MedicoRepository>();
            services.AddScoped<IMedicoService, MedicoService>();

            //Enfermeiro
            services.AddScoped<IEnfermeiroRepository, EnfermeiroRepository>();
            services.AddScoped<IEnfermeiroService, EnfermeiroService>();

            //Ficha
            services.AddScoped<IFichaRepository, FichaRepository>();
            services.AddScoped<IFichaService, FichaService>();
        }
    }
}
