using System;
using SQLite;

namespace App1
{
    [Table("CarCards")]
    public class CarCard
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public string Price { get; set; }

        public string Probeg { get; set; }

        public string Toplivo { get; set; }

        public string Transmission { get; set; }

        public string Color { get; set; }

        public string Privod { get; set; }

        public string Kuzov { get; set; }

        public string Image { get; set; }

        public string God { get; set; }

        public string Rul { get; set; }

        public string Users { get; set; }

        public string PTS { get; set; }

        public string Tam { get; set; }
    }
}
