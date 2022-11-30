using System.ComponentModel.DataAnnotations;

namespace HomeworkBlog.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(50),Display(Name ="Kategori Adı")]
        public string Name { get; set; }
        [Display(Name= "Açıklama")]
        public string? Description { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime CreatedTime { get; set; }
        public virtual List<Post> Posts { get; set; } // burada post sınfı ile category sınıfı arasında 1  çok ilişki kurduk. 
    }
}
