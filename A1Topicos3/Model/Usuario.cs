namespace A1Topicos3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            Carro = new HashSet<Carro>();
            Endereco = new HashSet<Endereco>();
            Revisao = new HashSet<Revisao>();
        }

        public int id { get; set; }

        public string nome { get; set; }

        public string email { get; set; }

        public string senha { get; set; }

        public DateTime dataNascimento { get; set; }

        public string rg { get; set; }

        public string cpf { get; set; }

        public string cnpj { get; set; }

        public bool admin { get; set; }

        public bool ativo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carro> Carro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Endereco> Endereco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Revisao> Revisao { get; set; }
    }
}
