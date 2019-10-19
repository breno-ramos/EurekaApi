namespace Eureka.Domain.Commands.ModelCommands
{
    public class UpdateModelCommand
    {
        public UpdateModelCommand(string nome, int idBrand)
        {
            Nome = nome;
            IdBrand = idBrand;
        }

        public string Nome { get; set; }
        public int IdBrand { get; set; }
    }
}
