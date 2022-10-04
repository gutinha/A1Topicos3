namespace A1Topicos3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Endereco")]
    public partial class Endereco
    {
        public int id { get; set; }

        [Column("endereco")]
        public string endereco1 { get; set; }

        public int numero { get; set; }

        public string complemento { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public string cep { get; set; }

        public int? Usuario_id { get; set; }

        public virtual Usuario Usuario { get; set; }
        public Endereco(string endereco, int numero, string complemento, string bairro, string cidade, string estado, string cep, int Usuario_id)
        {
            this.endereco1 = endereco;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
            this.Usuario_id = Usuario_id;
        }
        public Endereco(string endereco, int numero, string complemento, string bairro, string cidade, string estado, string cep)
        {
            this.endereco1 = endereco;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
        }
        public Endereco()
        {

        }
    }
}
