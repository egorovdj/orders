using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders.Models
{
    /// <summary>
    /// заказ
    /// </summary>
    [Index(nameof(ProviderId), nameof(Number), IsUnique = true)]
    [Table("Orders")]
    public class Order
    {
        public Order()
        {
            Items = new HashSet<OrderItem>();
        }

        /// <summary>
        /// Ид базы данных
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ид провайдера *редактируется *используется для фильтрации
        /// </summary>
        public int? ProviderId { get; set; }

        /// <summary>
        /// Номер заказа - уникальный для провайдера *редактируется *используется для фильтрации
        /// </summary>
        public string? Number { get; set; }

        /// <summary>
        /// Дата заказа *редактируется *используется для фильтрации
        /// </summary>
        public DateTime? Date { get; set; }

        public virtual Provider? ProviderNavigation { get; set; }
        public virtual ICollection<OrderItem> Items { get; set; }
    }
}
