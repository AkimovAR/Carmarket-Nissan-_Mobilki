using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App1
{
    [Table ("FavouritesCarCards")]
    public class FavouritesCarCard
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
    }
}
