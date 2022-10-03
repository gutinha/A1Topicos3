namespace A1Topicos3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log")]
    public partial class Log
    {
        public int id { get; set; }

        public DateTime logDateTime { get; set; }

        public string texto { get; set; }

        public string usuario { get; set; }
        public Log(DateTime logDateTime, string texto, string usuario)
        {
            this.logDateTime = logDateTime;
            this.texto = texto;
            this.usuario = usuario;
        }
    }
}
