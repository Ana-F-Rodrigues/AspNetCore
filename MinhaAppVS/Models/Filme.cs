﻿

using System.ComponentModel.DataAnnotations;

namespace MinhaDemoMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatorio")]
        [StringLength(60, MinimumLength =  3 , ErrorMessage = "O título precisa ter entre 3 ou 60 caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "O campo Data de Lancamento é obrigatorio")]
        [Display(Name = "Data de Lançamento")]
        public System.DateTime DataLancamento { get; set; }

        [StringLength(30,ErrorMessage = "Maximo de 30 caracteres")]
        [Required(ErrorMessage = "Genero é obrigatorio")]
        public string Genero { get; set; }

        [Range(1,1000, ErrorMessage = "Valor de 1 a 1000")]
        [Required(ErrorMessage = "Preencha o campo Valor")]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Preencha o campo Avaliação")]
        [Display(Name = "Avaliação")]
        [RegularExpression(@"^[0-5]^$", ErrorMessage = "Somente Numeros")]
        public int Avaliacao { get; set; }

    }
}
