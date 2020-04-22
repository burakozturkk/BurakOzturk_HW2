using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Comment
    {
        public int Id{ get; set; }
        
        
        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Yorumunuz 2 ile 10 karakter arasında olmalıdır.")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name = "Yorum")]
        public string Detail { get; set; }
        
        [Display(Name = "Puan")]
        public int? Rating { get; set; }
        [Display(Name = "Yapıldığı Tarih")]

        public DateTime CreatedDate { get; set; }
        [Display(Name = "Kitap Adı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int BookId { get; set; }
        
        [Display(Name = "Kitap Adı")]
        public Book Book { get; set; }

        public Comment()
        {
            CreatedDate = DateTime.Now;
          
        }
    }
}
