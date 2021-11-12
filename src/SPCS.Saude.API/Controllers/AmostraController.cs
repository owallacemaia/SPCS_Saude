using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SPCS.ApiModels.Amostra;
using SPCS.ApiModels.Ficha;
using SPCS.Saude.Business.Interfaces;
using System;
using System.Threading.Tasks;

namespace SPCS.Saude.API.Controllers
{
    [Authorize]
    [Route("api/amostras")]
    public class AmostraController : MainController
    {
        private readonly IPacienteRepository _pacienteRepository;
        //private readonly IFichaAgroRepository _fichaAgroRepository;
        private readonly IAgrotoxicoRepository _agrotoxicoRepository;

        [HttpPost("cadastrar")]
        public async Task<IActionResult> Cadastrar(FichaResponseApiModel model)
        {
            #region Conversão de Variaveis
            var paciente = await _pacienteRepository.ObterPorId(model.PacienteId);

            //var fichaAgro = await _fichaAgroRepository.ObterPorId(model.FichaAgros);
            //var agrotoxico = await _agrotoxicoRepository.ObterPorId(fichaAgro.AgrotoxicoId);

            int idade = (DateTime.Now.Year - paciente.DataNascimento.Year);
            double cafe = Convert.ToDouble(model.CafeMlDia);
            int tempoContato = Convert.ToInt32(model.TempoContatoPraguicida);
            int ultimoContato = Convert.ToInt32(model.UltimoContatoPraguicida);
            int qtdAdoeceu = Convert.ToInt32(model.QtdVezesAdoeceu);
            int numInternado = Convert.ToInt32(model.QtdVezesInternado);
            int QInternado = Convert.ToInt32(model.QuandoInterndo);
            double chT = Convert.ToDouble(model.Ch_t);
            double chE = Convert.ToDouble(model.Ch_e);
            double chP = Convert.ToDouble(model.Ch_p);
            double ast = Convert.ToDouble(model.Ast);
            double alt = Convert.ToDouble(model.Alt);
            double ygt = Convert.ToDouble(model.Y_gt);
            double creatinina = Convert.ToDouble(model.Creatinina);

            #endregion


            var response = new AmostraApiModel
            {

                Sexo = paciente.Sexo,
                Gestante = model.Gestante,
                IdadeDiscretizado = (idade > 0) && (idade <= 12) ? "Criança" : (idade > 12) && (idade <= 17) ? "Jovem" :
                                    (idade > 18) && (idade <= 59) ? "Adulto" : (idade >= 60) ? "Idoso" : null,
                Tabagismo = model.Tabagismo,
                TabagismoAnterior = model.TabagismoAnterior,
                TabagismoAtual = model.TabagismoAtual,
                Etilismo = model.Etilismo,
                EtilismoAnterior = model.EtilismoAnterior,
                EtilismoAtual = model.EtilismoAtual,
                IngestaoCafe = model.IngestaoCafe,
                CafeMldiaDiscretizado = (cafe == 0) ? "Sem Consumo" : (cafe >= 1) & (cafe <= 100) ? "Consumo Baixo" :
                                        (cafe > 100) && (cafe <= 300) ? "Consumo Moderado" : (cafe > 300) ? "Consumo Alto" : null,
                FuncaoTrabalho = model.FuncaoTrabalho,
                ContatoPraguicida = model.ContatoPraguicida,
                TempoContatoPraguicida = (tempoContato == 0) ? "Não Informado" : (tempoContato >= 1) && (tempoContato <= 3) ? "Tempo Baixo De Exposição" :
                                        (tempoContato > 3) && (tempoContato <= 6) ? "Tempo Médio De Exposição" : (tempoContato >= 7) ? "Tempo Alto De Exposição" : null,
                UltimoContatoPraguicida = ultimoContato == 0 ? "Não Informado" : (ultimoContato > 0) && (ultimoContato <= 7) ? "Exposição Aguda" :
                                        (ultimoContato > 7) && (ultimoContato <= 30) ? "Exposição Subaguda" : (ultimoContato > 30) && (ultimoContato <= 90) ? "Exposição Subcrônica" :
                                        (ultimoContato > 90) ? "Exposição Crônica" : null,
                ViaExposicao = model.ViaExposicao,
                Adoeceu = model.Adoeceu,
                NVezesAdoeceu = (qtdAdoeceu == 0) ? "Nenhuma Vez" : (qtdAdoeceu == 1) ? "Uma Única Vez" : (qtdAdoeceu > 1) ? "Mais De Uma Vez" : null,
                Internado = model.Internado,
                NvezesInternado = (numInternado == 0) ? "Nenhuma Vez" : (numInternado == 1) ? "Uma Única Vez" : (numInternado > 1) ? "Mais De Uma Vez" : null,
                QuandoInternado = (QInternado == 0) ? "Nenhuma Vez" : (QInternado < 10) ? "Há Menos de 10 Anos" : (QInternado > 10) ? "Há Mais de 10 Anos" : null,
                TipoContato = model.TipoContato,
                EquipamentoProtecao = model.EquipamentoProtecao,
                RoupaProtecao = model.RoupaProtecao,
                BotaProtecao = model.BotaProtecao,
                LuvasProtecao = model.LuvasProtecao,
                MascaraProtecao = model.MascaraProtecao,
                OculosProtecao = model.OculosProtecao,
                ProtetorAuricular = model.ProtetorAuricular,
                DoencaCardioVascular = model.DoencaCardioVascular,
                HipertensaoArterial = model.HipertensaoArterial,
                HipotensaoArterial = model.HipotensaoArterial,
                Arritmia = model.Arritmia,
                AlteracaoSNervoso = model.AlteracaoSNervoso,
                DorCabeca = model.DorCabeca,
                FraquezaMuscular = model.FraquezaMuscular,
                Tremedeira = model.Tremedeira,
                VisaoTurvaEmbacada = model.VisãoTurvaEmbacada,
                AgitacaoIrritabilidade = model.AgitacaoIrritabilidade,
                VertigensTonturas = model.VertigensTonturas,
                Formigamento = model.Formigamento,
                IncoordenacaoMotora = model.IncoordenacaoMotora,
                AparelhoDigestorio = model.AparelhoDigestorio,
                ColicasDorBarriga = model.ColicasDorBarriga,
                DorEstomago = model.DorEstomago,
                AziaQueimacao = model.AziaQueimacao,
                NauseasEnjoo = model.NauseasEnjoo,
                Vomito = model.Vomito,
                Diarreia = model.Diarreia,
                AparelhoRespiratorio = model.AparelhoRespiratorio,
                FaltaDeAr = model.FaltaDeAr,
                IrritaçaoNasal = model.IrritaçaoNasal,
                CatarroEscarro = model.CatarroEscarro,
                Tosse = model.Tosse,
                AparelhoAuditivo = model.AparelhoAuditivo,
                DiminuicaoAudicao = model.DiminuicaoAudicao,
                Zumbido = model.Zumbido,
                PeleMucosa = model.PeleMucosa,
                DcSensibilizante = model.DcSensibilizante,
                DcIrritativa = model.DcIrritativa,
                IrritacaoOcular = model.IrritacaoOcular,
                AparelhoUrinario = model.AparelhoUrinario,
                DiminuicaoUrina = model.DiminuicaoUrina,
                UrinaescuraSangue = model.UrinaescuraSangue,
                Outro = model.Outro,
                ExposicaoRaiox = model.ExposicaoRaiox,
                QuandodiasExposicao = model.QuandodiasExposicao,
                TeveCancer = model.TeveCancer,
                DigestorioCancer = model.DigestorioCancer,
                RespiratorioCancer = model.RespiratorioCancer,
                ReprodutorCancer = model.ReprodutorCancer,
                GlandularCancer = model.GlandularCancer,
                PeleOssoSangueCancer = model.PeleOssoSangueCancer,
                FamiliaCancer = model.FamiliaCancer,
                DigestorioCancerfamilia = model.DigestorioCancerfamilia,
                RespiratorioCancerfamilia = model.RespiratorioCancerfamilia,
                ReprodutorCancerfamilia = model.ReprodutorCancerfamilia,
                GlandularCancerfamilia = model.GlandularCancerfamilia,
                PeleOssoSangueCancerfamilia = model.PeleOssoSangueCancerfamilia,
                Ch_t_discretizado = (chT == 0) ? "Não Informado" : (chT < 15.5) ? "Baixo" : (chT >= 15.5) ? "Alterada" : null,
                Ch_e_discretizado = (chE == 0) ? "Não Informado" : (chE < 32.0) ? "Baixo" : (chE >= 32.0) ? "Alterada" : null,
                Ch_p_discretizado = (chP == 0) ? "Não Informado" : (chP < 1.3) ? "Baixo" : (chP >= 1.3) ? "Alterada" : null,
                Ast_discretizado = (ast == 0) ? "Não Informado" : (ast < 4.0) ? "Baixo" : (ast >= 4.0) && (ast <= 36.0) ? "Alterada" : null,
                Alt_discretizado = (alt == 0) ? "Não Informado" : (alt < 4.0) ? "Baixo" : (alt >= 4) && (alt <= 32) ? "Alterada" : null,
                Y_gt_discretizado = (ygt == 0) ? "Não Informado" : (ygt < 7) ? "Baixo" : (ygt >= 7) && (ygt <= 50) ? "Alterada" : null,
                CreatininaDiscretizado = (paciente.Sexo == "Masculino") && (creatinina < 0.9) ? "Baixo" : (paciente.Sexo == "Masculino") && (creatinina >= 0.9) && (creatinina <= 1.3) ? "Alterada" :
                                         (paciente.Sexo == "Feminino") && (creatinina < 0.6) ? "Baixo" : (paciente.Sexo == "Feminino") && (creatinina >= 0.6) && (creatinina <= 1.1) ? "Alterada" : null,
                Ambulatorio = model.Ambulatorio,
                HabitoAlimentarDiscretizado = model.HabitoAlimentar,
                ImcDiscretizado = (model.Imc <= 18.5) ? "Baixo Peso" : (model.Imc >= 18.5) && (model.Imc <= 24.99) ? "Peso Normal" : (model.Imc > 25.0) && (model.Imc <= 29.99) ? "Sobrepeso" :
                                  (model.Imc > 30.0) && (model.Imc <= 34.99) ? "Obeso I" : (model.Imc >= 35.0) && (model.Imc <= 39.99) ? "Obeso II" : (model.Imc > 40) ? "Obeso III" : null,
                CircunferenciaAbdominalDiscretizado = (model.CircunferenciaAbdominal == 0) ? "Não Informado" : (paciente.Sexo == "Masculino") && (model.CircunferenciaAbdominal <= 101) ? "Adequada:" :
                                                      (paciente.Sexo == "Masculino") && (model.CircunferenciaAbdominal >= 102) ? "Inadequada" : (paciente.Sexo == "Feminino") && (model.CircunferenciaAbdominal <= 87) ? "Adequada" :
                                                      (paciente.Sexo == "Feminino") && (model.CircunferenciaAbdominal >= 88) ? "Inadequada" : null,
                DificuldadeEngravidar = model.DificuldadeEngravidar,
                AbortoEspontaneo = model.AbortoEspontaneo,
                TemFilhos = model.TemFilhos,
                FilhoMaFormacao = model.FilhoMaFormacao,
                MedicamentoContinuo = model.MedicamentoContinuo,
                RemedioMicose = model.RemedioMicose,
                NomeRemedio = model.NomeRemedio,
                SiglaDiagnostico = null,

            };
            
            return Ok();
        }
    }
}
