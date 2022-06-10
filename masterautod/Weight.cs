using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace masterautod
{
    [Table("weight")]
    public class Weight
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public DateTime Day { get; set; }
        public string weightValue { get; set; }
    }
}
