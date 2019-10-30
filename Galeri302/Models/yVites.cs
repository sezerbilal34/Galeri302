using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Galeri302.Models
{
    public class yVites
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Vites { get; set; }

        public virtual ICollection<yVites> YVites{ get; set; }

    }
}