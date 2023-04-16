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
            [Required(ErrorMessage = "Cógigo Obrigatório.")]//ErrorMessage = Código obrigatório
            [RegularExpression("([0-9]+)",ErrorMessage = "Código só aceita numéricos.")]//Expressão regular para testar números
            [StringLength(6, MinimumLength = 6, ErrorMessage = "Código do cliente deve ter 6 digitos.")]//Valor = 6
            public string Id { get; set; }

            [Required(ErrorMessage = "Nome Obrigatório.")]//ErrorMessage = Código obrigatório
            [StringLength(50, ErrorMessage = "Nome do Cliente, deve ter no máximo 50 caracteres.")]//Valor máximo 50
            public string Nome { get; set; }

            [StringLength(50, ErrorMessage = "Nome do Pai do Cliente, deve ter no máximo 50 caracteres.")]//Valor máximo 50
            public string NomePai { get; set; }

            [Required(ErrorMessage = "Nome da Mãe Obrigatório.")]//ErrorMessage = Código obrigatório
            [StringLength(50, ErrorMessage = "Nome da Mãe, deve ter no máximo 50 caracteres.")]//Valor máximo 50
            public string NomeMae { get; set; }

            public bool TemPai { get; set; }//Não é obrigatório

            [Required(ErrorMessage = "CPF Obrigatório.")]//ErrorMessage = Código obrigatório
            [RegularExpression("([0-9]+)", ErrorMessage = "CPF só aceita numéricos.")]//Expressão regular para testar números
            [StringLength(11, MinimumLength = 11, ErrorMessage = "Código do CPF deve ter 11 digitos.")]//Valor = 6
            public string Cpf { get; set; }

            [Required(ErrorMessage = "Gênero Obrigatório.")]//ErrorMessage = Código obrigatório
            public int Genero { get; set; }

            [Required(ErrorMessage = "CEP Obrigatório.")]//ErrorMessage = Código obrigatório
            [RegularExpression("([0-9]+)", ErrorMessage = "CEP só aceita numéricos.")]//Expressão regular para testar números
            [StringLength(8, MinimumLength = 8, ErrorMessage = "Código do CEP, deve ter 8 digitos.")]//Valor = 6
            public string Cep { get; set; }

            [Required(ErrorMessage = "Logradouro é Obrigatório.")]//ErrorMessage = Código obrigatório
            [StringLength(100, ErrorMessage = "Logradouro, deve ter no máximo 100 caracteres.")]//Valor máximo 50
            public string Logradouro { get; set; }

            [Required(ErrorMessage = "Complemento é Obrigatório.")]//ErrorMessage = Código obrigatório
            [StringLength(100, ErrorMessage = "Complemento, deve ter no máximo 100 caracteres.")]//Valor máximo 50
            public string Complemento { get; set; }

            [Required(ErrorMessage = "Bairro é Obrigatório.")]//ErrorMessage = Código obrigatório
            [StringLength(50, ErrorMessage = "Bairro, deve ter no máximo 50 caracteres.")]//Valor máximo 50
            public string Bairro { get; set; }

            [Required(ErrorMessage = "Cidade é Obrigatório.")]//ErrorMessage = Código obrigatório
            [StringLength(50, ErrorMessage = "Cidade, deve ter no máximo 50 caracteres.")]//Valor máximo 50
            public string Cidade { get; set; }

            [Required(ErrorMessage = "Telefone é Obrigatório.")]//ErrorMessage = Código obrigatório
            [StringLength(50, ErrorMessage = "Telefone, deve ter no máximo 50 caracteres.")]//Valor máximo 50
            public string Estado { get; set; }

            [Required(ErrorMessage = "Número do Telefone é Obrigatório.")]//ErrorMessage = Código obrigatório
            [RegularExpression("([0-9]+)", ErrorMessage = "Número do Telefone só aceita números.")]//Expressão regular para testar números
            public string Telefone { get; set; }

            public string Profissao { get; set; }//Não é obrigatório

            [Required(ErrorMessage = "Renda Familiar é Obrigatório")]//ErrorMessage = Código obrigatório
            [Range(0, double.MaxValue, ErrorMessage = "Renda Familiar, deve ser um valor positivo.")]//Testa o máximo da variavel variavel double
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
