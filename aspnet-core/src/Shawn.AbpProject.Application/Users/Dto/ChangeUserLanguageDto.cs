using System.ComponentModel.DataAnnotations;

namespace Shawn.AbpProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}