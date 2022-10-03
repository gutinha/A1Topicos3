namespace A1Topicos3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Carro")]
    public partial class Carro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Carro()
        {
            Revisao = new HashSet<Revisao>();
        }
        public enum Status
        {
            Novo = 1,
            Usado = 2
        }
        public int id { get; set; }

        public string nome { get; set; }

        public string modelo { get; set; }

        public DateTime anoModelo { get; set; }

        public DateTime anoFabricacao { get; set; }

        public int cavalos { get; set; }

        public int litrosMotor { get; set; }

        public int quantPortas { get; set; }

        public Status status { get; set; }

        public int? marca_id1 { get; set; }

        public int? Usuario_id { get; set; }

        public int? marca_id { get; set; }

        public virtual Marca Marca { get; set; }

        public virtual Usuario Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Revisao> Revisao { get; set; }
    }
}
