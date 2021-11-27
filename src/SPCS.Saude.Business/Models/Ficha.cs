﻿using SPCS.Saude.Core.DomainObjects;
using System;
using System.Collections.Generic;

namespace SPCS.Saude.Business.Models
{
    public class Ficha : Entity, IAggregateRoot
    {
        public Guid PacienteId { get; set; }
        public Guid AmostraId { get; set; }
        public DateTime DataCadastro { get; set; }
        public string MunicipioTrabalho { get; set; }
        public string Gestante { get; set; }
        public string Tabagismo { get; set; }
        public string TabagismoAtual { get; set; }
        public string TabagismoAnterior { get; set; }
        public string Etilismo { get; set; }
        public string EtilismoAtual { get; set; }
        public string EtilismoAnterior { get; set; }
        public string IngestaoCafe { get; set; }
        public string CafeMlDia { get; set; }
        public string RelacaoTrabalho { get; set; }
        public string FuncaoTrabalho { get; set; }
        public string ContatoPraguicida { get; set; }
        public string TempoContatoPraguicida { get; set; }
        public string FrequenciaContatoPraguicida { get; set; }
        public string UltimoContatoPraguicida { get; set; }
        public Guid ProdutoContatoUltimaVez { get; set; }
        public string FormaAplicacao { get; set; }
        public string Cultura { get; set; }
        public string ViaExposicao { get; set; }
        public string Adoeceu { get; set; }
        public string QtdVezesAdoeceu { get; set; }
        public string Internado { get; set; }
        public string QtdVezesInternado { get; set; }
        public string QuandoInterndo { get; set; }
        public string TipoContato { get; set; }
        public string EquipamentoProtecao { get; set; }
        public string RoupaProtecao { get; set; }
        public string BotaProtecao { get; set; }
        public string LuvasProtecao { get; set; }
        public string MascaraProtecao { get; set; }
        public string OculosProtecao { get; set; }
        public string ProtetorAuricular { get; set; }
        public string DoencaCardioVascular { get; set; }
        public string HipertensaoArterial { get; set; }
        public string HipotensaoArterial { get; set; }
        public string Arritmia { get; set; }
        public string AlteracaoSNervoso { get; set; }
        public string DorCabeca { get; set; }
        public string FraquezaMuscular { get; set; }
        public string Tremedeira { get; set; }
        public string TremorMuscular { get; set; }
        public string VisaoTurvaEmbacada { get; set; }
        public string AgitacaoIrritabilidade { get; set; }
        public string VertigensTonturas { get; set; }
        public string Formigamento { get; set; }
        public string IncoordenacaoMotora { get; set; }
        public string AparelhoDigestorio { get; set; }
        public string ColicasDorBarriga { get; set; }
        public string DorEstomago { get; set; }
        public string AziaQueimacao { get; set; }
        public string NauseasEnjoo { get; set; }
        public string Vomito { get; set; }
        public string Diarreia { get; set; }
        public string AparelhoRespiratorio { get; set; }
        public string FaltaDeAr { get; set; }
        public string IrritacaoNasal { get; set; }
        public string CatarroEscarro { get; set; }
        public string Tosse { get; set; }
        public string AparelhoAuditivo { get; set; }
        public string DiminuicaoAudicao { get; set; }
        public string Zumbido { get; set; }
        public string PeleMucosa { get; set; }
        public string DcSensibilizante { get; set; }
        public string DcIrritativa { get; set; }
        public string IrritacaoOcular { get; set; }
        public string AparelhoUrinario { get; set; }
        public string DiminuicaoUrina { get; set; }
        public string UrinaescuraSangue { get; set; }
        public string Outro { get; set; }
        public string ExposicaoRaiox { get; set; }
        public string QuandodiasExposicao { get; set; }
        public string TeveCancer { get; set; }
        public string SncCancer { get; set; }
        public string DigestorioCancer { get; set; }
        public string RespiratorioCancer { get; set; }
        public string ReprodutorCancer { get; set; }
        public string GlandularCancer { get; set; }
        public string PeleOssoSangueCancer { get; set; }
        public string FamiliaCancer { get; set; }
        public string SNCCancerFamilia { get; set; }
        public string DigestorioCancerfamilia { get; set; }
        public string RespiratorioCancerfamilia { get; set; }
        public string ReprodutorCancerfamilia { get; set; }
        public string GlandularCancerfamilia { get; set; }
        public string PeleOssoSangueCancerfamilia { get; set; }
        public string EdaRegiao { get; set; }
        public string Ch_t { get; set; }
        public string Ch_e { get; set; }
        public string Ch_p { get; set; }
        public string Ast { get; set; }
        public string Alt { get; set; }
        public string Y_gt { get; set; }
        public string Creatinina { get; set; }
        public string Ambulatorio { get; set; }
        public string HabitoAlimentar { get; set; }
        public string Imc { get; set; }
        public string CircunferenciaAbdominal { get; set; }
        public string DificuldadeEngravidar { get; set; }
        public string AbortoEspontaneo { get; set; }
        public string TemFilhos { get; set; }
        public string FilhoMaFormacao { get; set; }
        public string MedicamentoContinuo { get; set; }
        public string Medicamento { get; set; }
        public string RemedioMicose { get; set; }
        public string NomeRemedio { get; set; }
        public virtual IEnumerable<FichaAgro> Agrotoxicos { get; set; }
        public IEnumerable<Diagnostico> Diagnosticos { get; set; }
        public Paciente Paciente { get; set; }
        public Amostra Amostra { get; set; }

        protected Ficha() { }

        public Ficha(Guid pacienteId, DateTime dataCadastro, string municipioTrabalho, string gestante, string tabagismo, string tabagismoAtual, string tabagismoAnterior, string etilismo, string etilismoAtual, string etilismoAnterior, string ingestaoCafe, string cafeMlDia, string relacaoTrabalho, string funcaoTrabalho, string contatoPraguicida, string tempoContatoPraguicida, string frequenciaContatoPraguicida, string ultimoContatoPraguicida, Guid produtoContatoUltimaVez, string formaAplicacao, string cultura, string viaExposicao, string adoeceu, string qtdVezesAdoeceu, string internado, string qtdVezesInternado, string quandoInterndo, string tipoContato, string equipamentoProtecao, string roupaProtecao, string botaProtecao, string luvasProtecao, string mascaraProtecao, string oculosProtecao, string protetorAuricular, string doencaCardioVascular, string hipertensaoArterial, string hipotensaoArterial, string arritmia, string alteracaoSNervoso, string dorCabeca, string fraquezaMuscular, string tremedeira, string tremorMuscular, string visaoTurvaEmbacada, string agitacaoIrritabilidade, string vertigensTonturas, string formigamento, string incoordenacaoMotora, string aparelhoDigestorio, string colicasDorBarriga, string dorEstomago, string aziaQueimacao, string nauseasEnjoo, string vomito, string diarreia, string aparelhoRespiratorio, string faltaDeAr, string irritacaoNasal, string catarroEscarro, string tosse, string aparelhoAuditivo, string diminuicaoAudicao, string zumbido, string peleMucosa, string dcSensibilizante, string dcIrritativa, string irritacaoOcular, string aparelhoUrinario, string diminuicaoUrina, string urinaescuraSangue, string outro, string exposicaoRaiox, string quandodiasExposicao, string teveCancer, string sncCancer, string digestorioCancer, string respiratorioCancer, string reprodutorCancer, string glandularCancer, string peleOssoSangueCancer, string familiaCancer, string sNCCancerFamilia, string digestorioCancerfamilia, string respiratorioCancerfamilia, string reprodutorCancerfamilia, string glandularCancerfamilia, string peleOssoSangueCancerfamilia, string edaRegiao, string ch_t, string ch_e, string ch_p, string ast, string alt, string y_gt, string creatinina, string ambulatorio, string habitoAlimentar, string imc, string circunferenciaAbdominal, string dificuldadeEngravidar, string abortoEspontaneo, string temFilhos, string filhoMaFormacao, string medicamentoContinuo, string medicamento, string remedioMicose, string nomeRemedio, IEnumerable<FichaAgro> agrotoxicos)
        {
            PacienteId = pacienteId;
            DataCadastro = dataCadastro;
            MunicipioTrabalho = municipioTrabalho;
            Gestante = gestante;
            Tabagismo = tabagismo;
            TabagismoAtual = tabagismoAtual;
            TabagismoAnterior = tabagismoAnterior;
            Etilismo = etilismo;
            EtilismoAtual = etilismoAtual;
            EtilismoAnterior = etilismoAnterior;
            IngestaoCafe = ingestaoCafe;
            CafeMlDia = cafeMlDia;
            RelacaoTrabalho = relacaoTrabalho;
            FuncaoTrabalho = funcaoTrabalho;
            ContatoPraguicida = contatoPraguicida;
            TempoContatoPraguicida = tempoContatoPraguicida;
            FrequenciaContatoPraguicida = frequenciaContatoPraguicida;
            UltimoContatoPraguicida = ultimoContatoPraguicida;
            ProdutoContatoUltimaVez = produtoContatoUltimaVez;
            FormaAplicacao = formaAplicacao;
            Cultura = cultura;
            ViaExposicao = viaExposicao;
            Adoeceu = adoeceu;
            QtdVezesAdoeceu = qtdVezesAdoeceu;
            Internado = internado;
            QtdVezesInternado = qtdVezesInternado;
            QuandoInterndo = quandoInterndo;
            TipoContato = tipoContato;
            EquipamentoProtecao = equipamentoProtecao;
            RoupaProtecao = roupaProtecao;
            BotaProtecao = botaProtecao;
            LuvasProtecao = luvasProtecao;
            MascaraProtecao = mascaraProtecao;
            OculosProtecao = oculosProtecao;
            ProtetorAuricular = protetorAuricular;
            DoencaCardioVascular = doencaCardioVascular;
            HipertensaoArterial = hipertensaoArterial;
            HipotensaoArterial = hipotensaoArterial;
            Arritmia = arritmia;
            AlteracaoSNervoso = alteracaoSNervoso;
            DorCabeca = dorCabeca;
            FraquezaMuscular = fraquezaMuscular;
            Tremedeira = tremedeira;
            TremorMuscular = tremorMuscular;
            VisaoTurvaEmbacada = visaoTurvaEmbacada;
            AgitacaoIrritabilidade = agitacaoIrritabilidade;
            VertigensTonturas = vertigensTonturas;
            Formigamento = formigamento;
            IncoordenacaoMotora = incoordenacaoMotora;
            AparelhoDigestorio = aparelhoDigestorio;
            ColicasDorBarriga = colicasDorBarriga;
            DorEstomago = dorEstomago;
            AziaQueimacao = aziaQueimacao;
            NauseasEnjoo = nauseasEnjoo;
            Vomito = vomito;
            Diarreia = diarreia;
            AparelhoRespiratorio = aparelhoRespiratorio;
            FaltaDeAr = faltaDeAr;
            IrritacaoNasal = irritacaoNasal;
            CatarroEscarro = catarroEscarro;
            Tosse = tosse;
            AparelhoAuditivo = aparelhoAuditivo;
            DiminuicaoAudicao = diminuicaoAudicao;
            Zumbido = zumbido;
            PeleMucosa = peleMucosa;
            DcSensibilizante = dcSensibilizante;
            DcIrritativa = dcIrritativa;
            IrritacaoOcular = irritacaoOcular;
            AparelhoUrinario = aparelhoUrinario;
            DiminuicaoUrina = diminuicaoUrina;
            UrinaescuraSangue = urinaescuraSangue;
            Outro = outro;
            ExposicaoRaiox = exposicaoRaiox;
            QuandodiasExposicao = quandodiasExposicao;
            TeveCancer = teveCancer;
            SncCancer = sncCancer;
            DigestorioCancer = digestorioCancer;
            RespiratorioCancer = respiratorioCancer;
            ReprodutorCancer = reprodutorCancer;
            GlandularCancer = glandularCancer;
            PeleOssoSangueCancer = peleOssoSangueCancer;
            FamiliaCancer = familiaCancer;
            SNCCancerFamilia = sNCCancerFamilia;
            DigestorioCancerfamilia = digestorioCancerfamilia;
            RespiratorioCancerfamilia = respiratorioCancerfamilia;
            ReprodutorCancerfamilia = reprodutorCancerfamilia;
            GlandularCancerfamilia = glandularCancerfamilia;
            PeleOssoSangueCancerfamilia = peleOssoSangueCancerfamilia;
            EdaRegiao = edaRegiao;
            Ch_t = ch_t;
            Ch_e = ch_e;
            Ch_p = ch_p;
            Ast = ast;
            Alt = alt;
            Y_gt = y_gt;
            Creatinina = creatinina;
            Ambulatorio = ambulatorio;
            HabitoAlimentar = habitoAlimentar;
            Imc = imc;
            CircunferenciaAbdominal = circunferenciaAbdominal;
            DificuldadeEngravidar = dificuldadeEngravidar;
            AbortoEspontaneo = abortoEspontaneo;
            TemFilhos = temFilhos;
            FilhoMaFormacao = filhoMaFormacao;
            MedicamentoContinuo = medicamentoContinuo;
            Medicamento = medicamento;
            RemedioMicose = remedioMicose;
            NomeRemedio = nomeRemedio;
            Agrotoxicos = agrotoxicos;
        }

        internal bool IsValid()
        {
            return true;
        }
    }
}
