
namespace Salao.Models
{
    public class Cliente
    {
        public int Id_Cliente { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public string? Aniversario { get; set; }
        public DateTime DataCad { get; set; }

    }
}