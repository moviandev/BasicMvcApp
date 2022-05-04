using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppMvcBasica.Models
{
    public class Fornecedor : Entity
	{
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 11)]
        public string Documento { get; set; }

        public TipoForncedor TipoForncedor { get; set; }

        public Endereco Endereco { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        /* EF Relations */
         public IEnumerable<Produto> Produtos { get; set; }
    }
}

