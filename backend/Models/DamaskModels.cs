using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Damask.Models 
{
    [Table("Login", Schema = "payroll")]
    public class Login
    {
        [Key]
        [Column("userID", TypeName = "nvarchar(64)")]
        public string UserId { get; set; }

        [Column("password", TypeName = "nvarchar(20)")]
        public string Password { get; set; }

        [Column("username", TypeName = "nvarchar(20)")]
        public string Username { get; set; }
    }
}