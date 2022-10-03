namespace A1Topicos3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogSystem")]
    public partial class LogSystem
    {
        public int id { get; set; }

        public DateTime logDateTime { get; set; }

        public string texto { get; set; }

        public string usuario { get; set; }
        public LogSystem(DateTime date, string texto, string usuario)
        {
            this.logDateTime = date;
            this.texto = texto;
            this.usuario = usuario;
        }
    }
}
