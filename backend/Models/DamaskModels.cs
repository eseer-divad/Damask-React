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

    [Table("PTO_requests", Schema = "payroll")]
    public class PtoRequest
    {
        [Key]
        [Column("RequestID", TypeName = "nvarchar(64)")]
        public string RequestId { get; set; }

        [Column("employeeID", TypeName = "nvarchar(64)")]
        public string EmployeeId { get; set; }

        [Column("rDate", TypeName = "date")]
        public DateTime RequestDate { get; set; }

        public bool? Approval { get; set; }
    }

    [Table("employeeInfo", Schema = "payroll")]
    public class EmployeeInfo
    {
        [Key]
        [Column("EmployeeID", TypeName = "nvarchar(64)")]
        public string EmployeeId { get; set; }

        [Column("UserID", TypeName = "nvarchar(64)")]
        public string UserId { get; set; }

        public bool Salary { get; set; }
        public bool Prorate { get; set; }
        public bool Exempt { get; set; }

        [Column(TypeName = "decimal(19, 4)")]
        public decimal Wage { get; set; }

        public float OvertimeDiff { get; set; }
        public float PTO { get; set; }
    }

    [Table("timeClock", Schema = "payroll")]
    public class TimeClock
    {
        [Key]
        [Column("punchID", TypeName = "nvarchar(64)")]
        public string PunchId { get; set; }

        [Column("employeeID", TypeName = "nvarchar(64)")]
        public string EmployeeId { get; set; }

        [Column("timePunch")]
        public DateTime TimePunch { get; set; }
    }

    [Table("userInfo", Schema = "payroll")]
    public class UserInfo
    {
        [Key]
        [Column("userID", TypeName = "nvarchar(64)")]
        public string UserId { get; set; }

        [Column("firstName", TypeName = "nvarchar(20)")]
        public string FirstName { get; set; }

        [Column("middleName", TypeName = "nvarchar(20)")]
        public string MiddleName { get; set; }

        [Column("lastName", TypeName = "nvarchar(20)")]
        public string LastName { get; set; }

        [Column("SSN", TypeName = "nvarchar(9)")]
        public string Ssn { get; set; }

        [Column("DOB", TypeName = "date")]
        public DateTime Dob { get; set; }

        [Column("routingNum", TypeName = "nvarchar(9)")]
        public string RoutingNumber { get; set; }

        [Column("accountNum", TypeName = "nvarchar(20)")]
        public string AccountNumber { get; set; }

        [Column("streetAddress", TypeName = "nvarchar(30)")]
        public string StreetAddress { get; set; }

        [Column("State", TypeName = "nvarchar(2)")]
        public string State { get; set; }

        [Column("zipcode", TypeName = "nvarchar(5)")]
        public string ZipCode { get; set; }

        public bool IsAdmin { get; set; }
    }
}