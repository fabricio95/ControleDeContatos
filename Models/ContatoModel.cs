using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage =" Digite o nome do Contato")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Digite o Email do Contato")]
        [EmailAddress(ErrorMessage ="O Email informado não é válido!")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Digite o Número do Contato")]
        [Phone(ErrorMessage ="O Celular informado não é valido!")]
        public string Celular { get; set;  }
    }
}
