using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xyd.SSOSample.EFCore.Users
{
    public class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("username")]
        public string UserName { get; set; } = null!;

        [Column("password")]
        public string PassWord { get; set; } = null!;

        [Column("departmentname")]
        public string DepartmentName { get; set; } = null!;
    }
}
