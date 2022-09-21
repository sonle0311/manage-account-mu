using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class LogCredito
    {
        public int IdCreditos { get; set; }
        public string? Login { get; set; }
        public int Valor { get; set; }
        public DateTime Data { get; set; }
        public string? Ip { get; set; }
        public short Tipo { get; set; }
    }
}
