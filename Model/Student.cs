using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Api_CRUD_Dotnet_Core_8.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column]
        public string StudentName { get; set; } = null!;
        [Column]
        public string StudentClass { get; set; } = null!;
        [Column]
        public int Age { get; set; }
    }
}
