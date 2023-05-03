using ControleDeContatos.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = " Digite o nome do Usuário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = " Digite o Login do Usuário")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o Email do Usuário")]
        [EmailAddress(ErrorMessage = "O Email informado não é válido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe o perfil  do Usuário")]
        public PerfilEnum? Perfil { get; set; }
        

    }


}
