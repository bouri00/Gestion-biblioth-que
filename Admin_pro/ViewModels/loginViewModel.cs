﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Admin_pro.ViewModels
{
    public class loginViewModel
    {

        [Required(ErrorMessage = "Entrer Votre User Name  !!!!", AllowEmptyStrings = false)]
        public string User_Name { get; set; }

        public string Roles { get; set; }


        [Required(ErrorMessage = "Entrer Votre Nom du l'utilisateur !!!!", AllowEmptyStrings = false)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Entrer Votre Nom r !!!!", AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Entrer Votre Prenom !!!", AllowEmptyStrings = false)]
        public string Prenom { get; set; }
        [Required(ErrorMessage = "Entrer Mot de passe Correct !!", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Entrer Mot de passe Entre 30 Et 5 Caractere")]
        public string Password_cle { get; set; }
    }
}