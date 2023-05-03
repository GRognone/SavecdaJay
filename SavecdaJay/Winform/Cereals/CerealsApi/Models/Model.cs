using System.ComponentModel.DataAnnotations;

namespace CerealsApi.Models
{
    abstract public class Model
    {

        [Key]
        public  int Id { get; set; }
    }
}
