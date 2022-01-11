using System;
using SQLite;

namespace Gramada_Cosmin_Lab10.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}