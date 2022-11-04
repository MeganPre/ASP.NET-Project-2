using System;
using System.ComponentModel.DataAnnotations;
using System.Web.ModelBinding;


namespace _10207_Megan_Pretorius_SLD521_SA.Models.Data
{
    public class Paper
    {
        [Key]
        [BindNever]

        public int PaperId { get; set; }

        public string PaperTitle { get; set; }
        [Display(Name = "Title")]
        [Required(ErrorMessage = "This field is Required")]

        public string PaperAbstract { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Abstract")]

        public string PaperAuthor { get; set; }
        public string UserEmail { get; set; }

        [Display(Name = "Submission Date")]
        [DataType(DataType.Date)]
        public DateTime PaperDateSubmitted { get; set; }

        public Paper()
        {
            this.PaperDateSubmitted = DateTime.Now;
        }
         
        [BindNever]

        public int TopicId { get; set; }

        public string TopicName { get; set; }
    }
}