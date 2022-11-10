using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders.Models
{
    /// <summary>
    /// поставщик, заполнена изначально, нигде не редактируется
    /// </summary>
    [Table("Providers")]
    public class Provider
    {
        Provider()
        {
            Orders = new HashSet<Order>(); ;
        }

        /// <summary>
        /// Ид базы данных
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование поставщика *используется для фильтрации
        /// </summary>
        public string? Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
