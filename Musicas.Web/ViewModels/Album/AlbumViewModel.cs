using Musicas.Web.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Musicas.Web.ViewModels.Album
{
    public class AlbumViewModel
    {
        [Required(ErrorMessage = "Id é obrigatório")]
        public int Id { get; set; }

        [Display(Name = "Nome do álbum")]
        [Required(ErrorMessage = "O nome do álbum é obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome do álbum poderá ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Ano do álbum")]
        [Required(ErrorMessage = "Informe o ano do álbum")]
        public int Ano { get; set; }

        [Display(Name = "Observações")]
        [MaxLength(1000, ErrorMessage = "Você excedeu a quantidade máxima de caracteres")]
        public string Observacoes { get; set; }

        [Display(Name = "Email do fornecedor")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Informe o e-mail")]
        [MaxLength(50, ErrorMessage = "O email não pode ter mais que 50 caracteres")]
        [EmailTreinaWeb(ErrorMessage = "O email tem que ser do domínio institucional!")]
        public string Email { get; set; }
    }
}