using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace projet_freelancers.Models
{
    public class entreprise
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "ce champ est obligatoire")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "ce champ est obligatoire")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "ce champ est obligatoire")]
        public int Telephone { get; set; }

        [Required(ErrorMessage = "ce champ est obligatoire")]
        public string Pays { get; set; }

        [Required(ErrorMessage = "ce champ est obligatoire")]
        public string Adresse { get; set; }

        [Required(ErrorMessage = "ce champ est obligatoire")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter valid email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "ce champ est obligatoire")]
        public string Pseudo { get; set; }

        [Required(ErrorMessage = "ce champ est obligatoire")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Please confirm your password.")]
        [DataType(DataType.Password)]
        public string Confirmpassword { get; set; }

        

    }
}