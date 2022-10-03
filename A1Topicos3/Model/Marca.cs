namespace A1Topicos3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Marca")]
    public partial class Marca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Marca()
        {
            Carro = new HashSet<Carro>();
        }
        public Marca(string nome, string descricao, string imagem)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.imagem = imagem;
        }
        public override string ToString()
        {
            return nome;
        }

        public int id { get; set; }

        public string nome { get; set; }

        public string descricao { get; set; }

        public string imagem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carro> Carro { get; set; }
    }
}
