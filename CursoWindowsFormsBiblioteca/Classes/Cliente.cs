using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CursoWindowsFormsBiblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage = "Cógigo Obrigatório")]//Código obrigatório
            [RegularExpression("([0-9]+)",ErrorMessage = "Código só aceita numéricos")]//Expressão regular para testar números
            [StringLength(6, MinimumLength = 6, ErrorMessage = "Código do cliente deve ter 6 digitos.")]//Valor = 6
            public string Id { get; set; }

            [Required(ErrorMessage = "Nome Obrigatório")]//Código obrigatório
            [StringLength(50, ErrorMessage = "Nome do Cliente deve ter no máximo 50 caracteres.")]//Valor máximo 50
            public string Nome { get; set; }

            [StringLength(50, ErrorMessage = "Nome do Cliente deve ter no máximo 50 caracteres.")]//Valor máximo 50
            public string NomePai { get; set; }

            [Required(ErrorMessage = "Nome da Mãe Obrigatório")]//Código obrigatório
            [StringLength(50, ErrorMessage = "Nome da Mãe deve ter no máximo 50 caracteres.")]//Valor máximo 50
            public string NomeMae { get; set; }

            public bool TemPai { get; set; }

            [Required(ErrorMessage = "CPF Obrigatório")]//Código obrigatório
            public string Cpf { get; set; }
            public int Genero { get; set; }
            public string Cep { get; set; }
            public string Logradouro { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
            public string Telefone { get; set; }
            public string Profissao { get; set; }
            public Double RendaFamiliar { get; set; }

            public void ValidaClasse()
            {
                 ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                 List<ValidationResult> results = new List<ValidationResult>();
                 bool isValid = Validator.TryValidateObject(this, context, results, true);

                 if (isValid == false)
                 {
                     StringBuilder sbrErrors = new StringBuilder();
                     foreach (var validationResult in results)
                     {
                         sbrErrors.AppendLine(validationResult.ErrorMessage);
                     }
                     throw new ValidationException(sbrErrors.ToString());
                 }
            }
        }
        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }
    }
}
