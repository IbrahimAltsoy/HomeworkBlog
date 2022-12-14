using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HomeworkBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        [StringLength(50), Display(Name = "Kategori Adı")]
        public string Name { get; set; }
        [Display(Name = "İçerik Açıklaması")]
        public string? Description { get; set; }
        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
        public DateTime CreatedTime { get; set; }
        [StringLength(150), Display(Name = "İçerik Resmi")]
        public string? Image { get; set; }

        [Display(Name = "Kategory")]
        public int CategoryId { get; set; }
        [Display(Name = "Kategory")]
        public virtual Category? Category { get; set; }// burada post sınıfı ile category sınıfı arasında 1 e 1 ilişki kuruldu. 
    }
}
