using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Admin_pro.Models
{
    public class Users
    {
        public int id { get; set; }
        [Required (ErrorMessage ="Entrer votre Email Valide SVP !!!!",AllowEmptyStrings =false)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Entrer votre Prenom Valide SVP !!!!", AllowEmptyStrings = false)]
        public string prenom { get; set; }
        [Required(ErrorMessage = "Entrer votre Name Valide SVP !!!!", AllowEmptyStrings = false)]
        public string Name { get; set; }
        public DateTime DateCreation { get; set; }
        [Required(ErrorMessage = "Entrer Format Telephone Valide SVP !!!!", AllowEmptyStrings = false)]
        public string telephone { get; set; }
        [Required (ErrorMessage ="SVP Entrer Votre Pssword  !!!!!!",AllowEmptyStrings =false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [StringLength (50,MinimumLength =6,ErrorMessage ="La taille de password est 6 Caractére au minimum .")]
        public string password { get; set; }
        [Required(ErrorMessage = "Entrer votre Adresse  Correct SVP !!!!", AllowEmptyStrings = false)]
        public string Adresse { get; set; }
        [Compare("Password",ErrorMessage ="Entrer Votre Password Existe SVP  !!!!") ]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Confirmpassword { get; set; }
    }
}