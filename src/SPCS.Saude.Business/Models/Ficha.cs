using NetDevPack.Domain;
using Newtonsoft.Json;
using System;

namespace SPCS.Saude.Business.Models
{
    public class Ficha : Entity, IAggregateRoot
    {
        public Guid PacienteId { get; private set; }

        public bool Gestante { get; set; }
        public bool Tabagismo { get; set; }
        public bool? TabagismoAtual { get; set; }
        public bool? TabagismoAnterior { get; set; }
        public bool Etilismo { get; set; }
        public bool? EtilismoAtual { get; set; }
        public bool? EtilismoAnterior { get; set; }
        public bool IngestaoCafe { get; set; }
        public double CafeMlDia { get; set; }

        //Passar para um TIPO
        public string RelacaoTrabalho { get; set; }

        //Passar para um TIPO
        public string FuncaoTrabalho { get; set; }

        public bool ContatoPraguicida { get; set; }
        public string TempoContatoPraguicida { get; set; }

        //Passar para uma CLASSE 
        public string FrequenciaContatoPraguicida { get; set; }
        
        public string UltimoContatoPraguicida { get; set; }

        //Passar para um TIPO
        public string FormaAplicacao { get; set; }

        //Passar para um TIPO
        public string ViaExposicao { get; set; }

        public bool Adoeceu { get; set; }

        //Passar para um TIPO pode ser reutilizado
        public string QtdVezesAdoeceu { get; set; }

        public bool Internado { get; set; }

        public string QtdVezesInternado { get; set; }

        public string QuandoInterndo { get; set; }

        //Passar para um TIPO
        public string TipoContato { get; set; }

        public bool EquipamentoProtecao { get; set; }

        
        string roupa_protecao;
        string bota_protecao;
        string luvas_protecao;
        string mascara_protecao;
        string oculos_protecao;
        string protetor_auricular;
        string doenca_cardiovascular;
        string hipertensao_arterial;
        string hipotensao_arterial;
        string arritmia;
        string alteracao_snervoso;
        string dor_cabeca;
        string fraqueza_muscular;
        string tremedeira;
        string tremor_muscular;
        string visãoturva_embacada;
        string agitacao_irritabilidade;
        string vertigens_tonturas;
        string formigamento;
        string incoordenacao_motora;
        string aparelho_digestorio;
        string colicas_dorbarriga;
        string dor_estomago;
        string azia_queimacao;
        string nauseas_enjoo;
        string vomito;
        string diarreia;
        string aparelho_respiratorio;
        string falta_dear;
        string irritaçao_nasal;
        string catarro_escarro;
        string tosse;
        string aparelho_auditivo;
        string diminuicao_audicao;
        string zumbido;
        string pele_mucosa;
        string dc_sensibilizante;
        string dc_irritativa;
        string irritacao_ocular;
        string aparelho_urinario;
        string diminuicao_urina;
        string urinaescura_sangue;
        string outro;
        string exposicao_raiox;
        int quandodias_exposicao;
        string teve_cancer;
        string snc_cancer;
        string digestorio_cancer;
        string respiratorio_cancer;
        string reprodutor_cancer;
        string glandular_cancer;
        string pele_osso_sangue_cancer;
        string familia_cancer;
        string snc_cancerfamilia;
        string digestorio_cancerfamilia;
        string respiratorio_cancerfamilia;
        string reprodutor_cancerfamilia;
        string glandular_cancerfamilia;
        string pele_osso_sangue_cancerfamilia;
        string eda_regiao;
        double ch_t;
        double ch_e;
        double ch_p;
        double ast;
        double alt;
        double y_gt;
        double creatinina;
        string ambulatorio;
        double habito_alimentar;
        double imc;
        int circunferencia_abdominal;
        string dificuldade_engravidar;
        string aborto_espontaneo;
        string tem_filhos;
        string filho_maformacao;
        string medicamento_continuo;
        string medicamento;
        string remedio_micose;
        string nome_remedio;

        public Paciente Paciente { get; private set; }
    }

    public class Diagnostico : Entity, IAggregateRoot
    {
        public string Sigla { get; private set; }
        public string Descricao { get; private set; }

        protected Diagnostico() { }

        public Diagnostico(string sigla, string descricao)
        {
            Sigla = sigla;
            Descricao = descricao;
        }
    }

    public class Agrotoxico : Entity, IAggregateRoot
    {
        public string Nome { get; private set; }
        public string Tipo { get; private set; }
        public string PrincipioAtivo { get; private set; }

        protected Agrotoxico() { }

        public Agrotoxico(string nome, string tipo, string principioAtivo)
        {
            Nome = nome;
            Tipo = tipo;
            PrincipioAtivo = principioAtivo;
        }
    }

    public class FichaAgro : Entity, IAggregateRoot
    {
        public Guid FichaId { get; private set; }
        public Guid AgrotoxicoId { get; private set; }

        public Ficha Ficha { get; private set; }
        public Agrotoxico Agrotoxico { get; private set; }

        protected FichaAgro() { }

        public FichaAgro(Guid fichaId, Guid agrotoxicoId, Ficha ficha, Agrotoxico agrotoxico)
        {
            FichaId = fichaId;
            AgrotoxicoId = agrotoxicoId;
            Ficha = ficha;
            Agrotoxico = agrotoxico;
        }
    }
}
