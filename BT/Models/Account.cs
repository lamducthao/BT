namespace BT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [StringLength(10)]
        public string UserName { get; set; }

        [StringLength(10)]
        public string PassWord { get; set; }
    }
}
