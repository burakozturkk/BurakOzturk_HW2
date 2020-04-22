using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Kitap adı 2 ile 10 karakter arasında olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name ="Kitap Adı")]
        public string Title { get; set; } // nvarchar(512), not nullable
        
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name = "Sayfa Sayısı")]
        public int? PageCount { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Yazar adı 2 ile 10 karakter arasında olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name = "Yazarlar")]
        public string Authors { get; set; }
        [Display(Name = "Açıklama")]
        public string Description  { get; set; }

        [Required(ErrorMessage = "Fiyat bilgisi girilmesi zorunludur. Eğer kitap ücretsiz ise lütfen 0 ile belirtiniz.")]
        [Display(Name = "Fiyat")]
        public Decimal Price { get; set; }

        [Display(Name = "Basım Yılı")]
        public int PressYear { get; set; }
        [Display(Name = "Stok Adedi")]
        public int StockCount { get; set; }

        
        public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]
        [Display(Name = "Kategori")]
        public  Category Category { get; set; }
        [Display(Name = "Oluşturma Tarihi")]
        public DateTime CreatedDate { get; set; }

        public virtual List<Comment> Comments { get; set; }
        public Book()
        {
            CreatedDate = DateTime.Now;
          //  double result = 4.0 / 2.0; //2.0000000000000000000000001 1.9999999999999999999999998
        }

    }
}
