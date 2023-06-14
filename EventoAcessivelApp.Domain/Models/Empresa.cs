using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace EventoAcessivelApp.Domain.Models
{

    [Table("Empresa")]
    public class Empresa
    {
        
        public int Id { get; set; }
        public string Foto { get; set; } = "";
        public string Nome { get; set; } = "";
        public string Cnpj { get; set; } = "";
        public int Telefone { get; set; }
        public string Cep { get; set; } = "";
        public string Endereco { get; set; } = "";
        public string Numero { get; set; } = "";
        public string Descricao { get; set; } = "";

        [NotMapped]
        [Display(Name = "Foto")]
        public IFormFile? FotoFile { get; set; }
    }
}