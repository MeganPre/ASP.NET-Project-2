using System.ComponentModel.DataAnnotations;
using System.Web.ModelBinding;

namespace _10207_Megan_Pretorius_SLD521_SA.Models.Data
{
    public class Topic
    {
        [Key]
        [BindNever]

        public int TopicId { get; set; }

        [Display(Name = "Topic")]
        public string Details { get; set; }
    }
}