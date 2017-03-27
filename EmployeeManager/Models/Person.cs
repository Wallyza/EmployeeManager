using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeManager.Models
{  
  public class Person
  {
    [Key]
    public int PersonId { get; set; }
    [MaxLength(128)]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }
    [MaxLength(128)]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    [Display(Name = "Date of Birth")]
    public DateTime BirthDate { get; set; }

    [Display(Name ="Full Name")]
    public string FullName
    {
      get
      {
        return String.Format("{0}, {1}", LastName, FirstName);
      }
    }
  }
}