﻿using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage ="Lütfen Kullanıcı Adınızı Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Resim URL Giriniz")]
        public string ImageURL { get; set; }


        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }
       
        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz")]
        [Compare("Password", ErrorMessage ="Şifreler uyumlu değil!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Mailinizi Giriniz")]
        public string Mail { get; set; }

    }
}
