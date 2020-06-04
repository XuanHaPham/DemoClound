namespace RetailAPI.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int OrderId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TimeCreated { get; set; }

        public string Creater { get; set; }

        public bool? Status { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
