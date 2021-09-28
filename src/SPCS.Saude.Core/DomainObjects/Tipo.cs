namespace SPCS.Saude.Core.DomainObjects
{
    public class Tipo<T> where T : struct
    {
        public T Id { get; set; }
        public string Descricao { get; set; }

        public override string ToString() => Descricao;
    }
}
