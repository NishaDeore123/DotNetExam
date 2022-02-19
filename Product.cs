using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DotNetExam.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [DataType(DataType.Text)]
        [Required (ErrorMessage ="Please Enter Product Name")]
        public string ProductName{ get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Rate of Product")]
        public decimal Rate { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Product Description")]
        public string Description { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Product Category")]
        public string CategoryName { get; set; }
    }
}