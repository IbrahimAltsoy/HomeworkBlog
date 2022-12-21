//using System.ComponentModel.DataAnnotations;

//namespace HomeworkBlog.Models
//{
//    public class Category
//    {
//        public int Id { get; set; }
//        [StringLength(50),Display(Name ="Kategori Adı")]
//        public string Name { get; set; }
//        [Display(Name= "Açıklama")]
//        public string? Description { get; set; }
//        [Display(Name = "Eklenme Tarihi")]
//        public DateTime CreatedTime { get; set; }
//        public virtual List<Post> Posts { get; set; } // burada post sınfı ile category sınıfı arasında 1  çok ilişki kurduk. 
//    }
//}
using HomeworkBlog.Models;
using System.ComponentModel.DataAnnotations;

namespace HomeworkBlog.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(50), Display(Name = "Kategori Adı")]
        public string Name { get; set; }
        [Display(Name = "Kategori Açıklaması")]
        public string? Description { get; set; }
        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public virtual List<Post>? Posts { get; set; } // Burada Category sınıfı ile Post sınıfı arasında 1 e çok bir ilişki kurduk
    }
}
