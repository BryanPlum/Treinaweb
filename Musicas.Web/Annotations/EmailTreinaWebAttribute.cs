using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Musicas.Web.Annotations
{
    public class EmailTreinaWebAttribute : ValidationAttribute // Herda a datanotation de validação
    {
        public override bool IsValid(object value)
        {
            return value.ToString().EndsWith("@treinaweb.com.br");
        }

    }
}