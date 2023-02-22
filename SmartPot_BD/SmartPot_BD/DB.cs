using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SmartPot_BD
{
    [Table("DB")]
    public class DB
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public int Brightness { get; set; }
        public int Humidity { get; set; }
        public int WaterLevel { get; set; }
    }
}
