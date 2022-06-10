using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace masterautod
{
    [Table("vesi")]
    public class Water
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public DateTime Day { get; set; }
        public string waterValue { get; set; }
    }
}
