using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserWebApi.Models
{
    public class RegisterViewModel
    {
        [Required]
        //[Display(Name = "Tài khoản")]
        public string UserName { get; set; }

        [Required]
        //[Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        //[Display(Name = "Họ và tên")]
        public string Fullname { get; set; }

        [Required]
        //[Display(Name = "Tuổi")]
        public int Age { get; set; }

        [Required]
        //[Display(Name = "Thành phố")]
        public string City { get; set; }
    }
}
