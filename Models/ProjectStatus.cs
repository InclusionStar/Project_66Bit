using System.ComponentModel.DataAnnotations;

namespace Project_66_bit.Models
{
    public enum ProjectStatus
    {
        [Display(Name = "������������")]
        Planning,
        [Display(Name = "����. �������")]
        PreSale,
        [Display(Name = "� ����������")]
        InDevelopment,
        [Display(Name = "��������")]
        Complete
    }
}
