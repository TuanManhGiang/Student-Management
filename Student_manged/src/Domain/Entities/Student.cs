using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_manged.Domain.Entities;
[Table("Students")]
public class Student : BaseAuditableEntity
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }    
    public string Email { get; set; }   

}
