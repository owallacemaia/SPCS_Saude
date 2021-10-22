﻿using SPCS.Saude.Core.DomainObjects;
using System;
using System.Collections.Generic;

namespace SPCS.Saude.Business.Models
{
    public class Ficha : Entity, IAggregateRoot
    {
        public Guid PacienteId { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string MunicipioTrabalho { get; private set; }
        public string Gestante { get; private set; }
        public string Tabagismo { get; private set; }
        public string TabagismoAtual { get; private set; }
        public string TabagismoAnterior { get; private set; }
        public string Etilismo { get; private set; }
        public string EtilismoAtual { get; private set; }
        public string EtilismoAnterior { get; private set; }
        public string IngestaoCafe { get; private set; }
        public string CafeMlDia { get; private set; }
        public string RelacaoTrabalho { get; private set; }
        public string FuncaoTrabalho { get; private set; }
        public string ContatoPraguicida { get; private set; }
        public string TempoContatoPraguicida { get; private set; }
        public string FrequenciaContatoPraguicida { get; private set; }
        public string UltimoContatoPraguicida { get; private set; }
        public string FormaAplicacao { get; private set; }
        public string ViaExposicao { get; private set; }
        public string Adoeceu { get; private set; }
        public string QtdVezesAdoeceu { get; private set; }
        public string Internado { get; private set; }
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
        public string DoencaCardioVascular { get; private set; }
        public string HipertensaoArterial { get; private set; }
        public string HipotensaoArterial { get; private set; }
        public string Arritmia { get; private set; }
        public string AlteracaoSNervoso { get; private set; }
        public string DorCabeca { get; private set; }
        public string FraquezaMuscular { get; private set; }
        public string Tremedeira { get; private set; }
        public string TremorMuscular { get; private set; }
        public string VisãoTurvaEmbacada { get; private set; }
        public string AgitacaoIrritabilidade { get; private set; }
        public string VertigensTonturas { get; private set; }
        public string Formigamento { get; private set; }
        public string IncoordenacaoMotora { get; private set; }
        public string AparelhoDigestorio { get; private set; }
        public string ColicasDorBarriga { get; private set; }
        public string DorEstomago { get; private set; }
        public string AziaQueimacao { get; private set; }
        public string NauseasEnjoo { get; private set; }
        public string Vomito { get; private set; }
        public string Diarreia { get; private set; }
        public string AparelhoRespiratorio { get; private set; }
        public string FaltaDeAr { get; private set; }
        public string IrritaçaoNasal { get; private set; }
        public string CatarroEscarro { get; private set; }
        public string Tosse { get; private set; }
        public string AparelhoAuditivo { get; private set; }
        public string DiminuicaoAudicao { get; private set; }
        public string Zumbido { get; private set; }
        public string PeleMucosa { get; private set; }
        public string DcSensibilizante { get; private set; }
        public string DcIrritativa { get; private set; }
        public string IrritacaoOcular { get; private set; }
        public string AparelhoUrinario { get; private set; }
        public string DiminuicaoUrina { get; private set; }
        public string UrinaescuraSangue { get; private set; }
        public string Outro { get; private set; }
        public string ExposicaoRaiox { get; private set; }
        public string QuandodiasExposicao { get; private set; }
        public string TeveCancer { get; private set; }
        public string SncCancer { get; private set; }
        public string DigestorioCcancer { get; private set; }
        public string RespiratorioCancer { get; private set; }
        public string ReprodutorCancer { get; private set; }
        public string GlandularCancer { get; private set; }
        public string PeleOssoSangueCancer { get; private set; }
        public string FamiliaCancer { get; private set; }
        public string SNCCancerFamilia { get; private set; }
        public string DigestorioCancerfamilia { get; private set; }
        public string RespiratorioCancerfamilia { get; private set; }
        public string ReprodutorCancerfamilia { get; private set; }
        public string GlandularCancerfamilia { get; private set; }
        public string PeleOssoSangueCancerfamilia { get; private set; }
        public string EdaRegiao { get; private set; }
        public string Ch_t { get; private set; }
        public string Ch_e { get; private set; }
        public string Ch_p { get; private set; }
        public string Ast { get; private set; }
        public string Alt { get; private set; }
        public string Y_gt { get; private set; }
        public string Creatinina { get; private set; }
        public string Ambulatorio { get; private set; }
        public string HabitoAlimentar { get; private set; }
        public string Imc { get; private set; }
        public string CircunferenciaAbdominal { get; private set; }
        public string DificuldadeEngravidar { get; private set; }
        public string AbortoEspontaneo { get; private set; }
        public string TemFilhos { get; private set; }
        public string FilhoMaFormacao { get; private set; }
        public string MedicamentoContinuo { get; private set; }
        public string Medicamento { get; private set; }
        public string RemedioMicose { get; private set; }
        public string NomeRemedio { get; private set; }
        public virtual IEnumerable<FichaAgro> Agrotoxicos { get; set; }
        public Diagnostico Diagnostico { get; set; }
        public Paciente Paciente { get; private set; }

        protected Ficha() { }

        public Ficha(Guid pacienteId, DateTime dataCadastro, string municipioTrabalho, string gestante, string tabagismo, string tabagismoAtual, 
                     string tabagismoAnterior, string etilismo, string etilismoAtual, string etilismoAnterior, string ingestaoCafe, string cafeMlDia, 
                     string relacaoTrabalho, string funcaoTrabalho, string contatoPraguicida, string tempoContatoPraguicida, string frequenciaContatoPraguicida, 
                     string ultimoContatoPraguicida, string formaAplicacao, string viaExposicao, string adoeceu, string qtdVezesAdoeceu, string internado, string qtdVezesInternado, 
                     string quandoInterndo, string tipoContato, string equipamentoProtecao, string roupaProtecao, string botaProtecao, string luvasProtecao, string mascaraProtecao, 
                     string oculosProtecao, string protetorAuricular, string doencaCardioVascular, string hipertensaoArterial, string hipotensaoArterial, string arritmia, 
                     string alteracaoSNervoso, string dorCabeca, string fraquezaMuscular, string tremedeira, string tremorMuscular, string visãoTurvaEmbacada, string agitacaoIrritabilidade, 
                     string vertigensTonturas, string formigamento, string incoordenacaoMotora, string aparelhoDigestorio, string colicasDorBarriga, string dorEstomago, string aziaQueimacao, 
                     string nauseasEnjoo, string vomito, string diarreia, string aparelhoRespiratorio, string faltaDeAr, string irritaçaoNasal, string catarroEscarro, string tosse, string aparelhoAuditivo, 
                     string diminuicaoAudicao, string zumbido, string peleMucosa, string dcSensibilizante, string dcIrritativa, string irritacaoOcular, string aparelhoUrinario, string diminuicaoUrina, 
                     string urinaescuraSangue, string outro, string exposicaoRaiox, string quandodiasExposicao, string teveCancer, string sncCancer, string digestorioCcancer, string respiratorioCancer, 
                     string reprodutorCancer, string glandularCancer, string peleOssoSangueCancer, string familiaCancer, string sNCCancerFamilia, string digestorioCancerfamilia, string respiratorioCancerfamilia, 
                     string reprodutorCancerfamilia, string glandularCancerfamilia, string peleOssoSangueCancerfamilia, string edaRegiao, string ch_t, string ch_e, string ch_p, string ast, string alt, 
                     string y_gt, string creatinina, string ambulatorio, string habitoAlimentar, string imc, string circunferenciaAbdominal, string dificuldadeEngravidar, string abortoEspontaneo, 
                     string temFilhos, string filhoMaFormacao, string medicamentoContinuo, string medicamento, string remedioMicose, string nomeRemedio, IEnumerable<FichaAgro> agrotoxicos)
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
            FormaAplicacao = formaAplicacao;
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
            VisãoTurvaEmbacada = visãoTurvaEmbacada;
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
            IrritaçaoNasal = irritaçaoNasal;
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
            DigestorioCcancer = digestorioCcancer;
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
