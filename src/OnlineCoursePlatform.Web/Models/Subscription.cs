using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OnlineCoursePlatform.Web.Models
{
  public class Subscription
  {
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Título do Premium")]
    [StringLength(80, ErrorMessage = "O Título deve conter até 80 caracteres")]
    [MinLength(5, ErrorMessage = "O Título deve conter pelo menos 5 caracteres")]
    [DisplayName("Título")]
    public string Title { get; set; } = string.Empty;

    [DataType(DataType.DateTime)]
    [DisplayName("Início")]
    public DateTime StartDate { get; set; }

    [DataType(DataType.DateTime)]
    [DisplayName("Término")]
    public DateTime EndDate { get; set; }

    [Required(ErrorMessage = "Aluno inválido")]
    [DisplayName("Aluno")]
    public int StudentId { get; set; }

    public Student? Student { get; set; }
  }
}
