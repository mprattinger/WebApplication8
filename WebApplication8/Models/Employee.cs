using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication8.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Der Vorname ist erforderlich!")]
        [Display(Name = "Vorname")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Der Nachname ist erforderlich!")]
        [Display(Name = "Nachname")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Die Wochenarbeitszeit ist erforderlich!")]
        [Display(Name = "Wochenarbeitszeit")]
        public decimal WorkingHoursWeek { get; set; }
        [Display(Name = "Montag")]
        public bool Monday { get; set; }
        [Display(Name = "Dienstag")]
        public bool Tuesday { get; set; }
        [Display(Name = "Mittwoch")]
        public bool Wednesday { get; set; }
        [Display(Name = "Donnerstag")]
        public bool Thursday { get; set; }
        [Display(Name = "Freitag")]
        public bool Friday { get; set; }
        [Display(Name = "Samstag")]
        public bool Saturday { get; set; }
        [Display(Name = "Sonntag")]
        public bool Sunday { get; set; }
        [Required(ErrorMessage = "Die Pausen pro Tag sind erforderlich!")]
        [Display(Name = "Pause / Tag")]
        public float? PauseMinPerDay { get; set; }
        [Required(ErrorMessage = "Die Anzahl der Urlaubstage pro Jahr ist erforderlich!")]
        [Display(Name = "Urlaubstage / Jahr")]
        public float? VacationDays { get; set; }
        [Required(ErrorMessage = "Der erste Arbeitstag ist erforderlich!")]
        [Display(Name = "Erster Arbeitstag")]
        public DateTime? FirstDayOfWork { get; set; }

        [Display(Name = "Zugeordneter Benutzer")]
        public string UserPrincipalName { get; set; }

        //public TMSUser User { get; set; }

        [NotMapped]
        public string Name { get { return $"{FirstName} {LastName}"; } }
    }
}
