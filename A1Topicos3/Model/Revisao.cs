namespace A1Topicos3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Revisao")]
    public partial class Revisao
    {
        public int id { get; set; }

        public string descricao { get; set; }

        public DateTime dataRevisao { get; set; }

        public int? carro_id { get; set; }

        public int? usuario_id1 { get; set; }

        public int? usuario_id { get; set; }

        public virtual Carro Carro { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
