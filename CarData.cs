using System;
using SQLite;

namespace App1
{
    [Table("CarCards1")]
    public class CarData
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Transmission { get; set; }

        public string Image { get; set; }

        public string God { get; set; }

        public string Rul { get; set; }

        public string Users { get; set; }

        public string PTS { get; set; }

        public string Tam { get; set; }
    }
}
