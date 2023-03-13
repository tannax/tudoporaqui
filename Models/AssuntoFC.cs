using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace atvIII.Models
{
    public class AssuntoFC
    {
        [Key]
        public int idAssuntofaleConosco { get; set; }

        [MaxLength(50)]
        public string nome { get; set; }

        [MaxLength(15)]
        public string telefone { get; set; }

        [MaxLength(450)]
        public string Assunto { get; set; }

        [MaxLength(100)]
        public string email { get; set; }
    }

}
