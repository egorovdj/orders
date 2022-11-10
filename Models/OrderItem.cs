using System.ComponentModel.DataAnnotations.Schema;

namespace Orders.Models
{
    /// <summary>
    /// элемент заказа
    /// </summary>
    [Table("OrderItems")]
    public class OrderItem
    {
        public OrderItem()
        {
        }

        /// <summary>
        /// Ид базы данных
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ид заказа
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Наименование элемента *редактируется *используется для фильтрации
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Объём заказа *редактируется
        /// </summary>
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Ед измерения *редактируется *используется для фильтрации
        /// </summary>
        public string? Unit { get; set; }

        public virtual Order? OrderNavigation { get; set; }
    }
}
