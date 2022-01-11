using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Gramada_Cosmin_Lab10.Models
{
    public class ListProduct
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [ForeignKey(typeof(ShopList))]
        public int ShopListId { get; set; }
        public int ProductId { get; set; }
    }
}