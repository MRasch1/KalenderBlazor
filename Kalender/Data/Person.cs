using System.ComponentModel.DataAnnotations;

namespace Kalender.Data
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public DateTime Fødselsdato { get; set; }
    }
}
