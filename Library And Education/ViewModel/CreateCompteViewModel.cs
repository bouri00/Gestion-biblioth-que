using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library_And_Education.ViewModel
{
    public class CreateCompteViewModel
    {

        [Required(ErrorMessage ="Entrer Votre Nom du l'utilisateur !!!!",AllowEmptyStrings =false)]
        public string User_Name { get; set; }
        [Required(ErrorMessage = "Entrer Votre Nom du l'utilisateur !!!!", AllowEmptyStrings = false)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Entrer Votre Nom r !!!!", AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Entrer Votre Prenom !!!", AllowEmptyStrings = false)]
        public string Prenom { get; set; }


        [Required(ErrorMessage ="Entrer Mot de passe Correct !!",AllowEmptyStrings =false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [StringLength(30,MinimumLength =5,ErrorMessage ="Entrer Mot de passe Entre 30 Et 5 Caractere")]
        public string password { get; set; }
        [Compare("password",ErrorMessage ="Confirmer Le Mot de Passe SVP .")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Confirmpassword { get; set; }

        [Required(ErrorMessage = "Entrer Telephone !!!!", AllowEmptyStrings = false)]
        public string telephone { get; set; }
        [Required(ErrorMessage = "Entrer Votre Adresse !!!!", AllowEmptyStrings = false)]
        public string Adresse { get; set; }



    }
}