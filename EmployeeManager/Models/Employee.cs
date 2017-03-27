using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeManager.Models
{
  public class Employee
  {
    [Key]
    public int EmployeeId { get; set; }
    public int PersonId { get; set; }
    [MaxLength(16), Required]
    [Display(Name = "Employee Number")]
    public string EmployeeNum { get; set; }
    [Required, DataType(DataType.Date)]
    [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}")]
    [Display(Name = "Employment Date")]
    public DateTime EmployedDate { get; set; }
    [DataType(DataType.Date)]
    [Display(Name = "Termination Date")]
    [DisplayFormat(NullDisplayText = "N/A", DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime? TerminatedDate { get; set; }

    [ForeignKey("PersonId")]
    [Display(Name = "Person")]
    public virtual Person Person { get; set; }
  }
}