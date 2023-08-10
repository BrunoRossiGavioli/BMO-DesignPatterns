namespace FactoryMethod.Abstract
{
    public interface IPessoa
    {
        public int Id { get; init; }
        public string Nome { get; set; }
        public void Respirar();
    }
}
