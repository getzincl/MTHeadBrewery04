using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MTHeadBrewery.Models
{
    public class Beer
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="You must provide a name for the beer")]
        public string BeerName { get; set; }

        [Required(ErrorMessage ="You must provide the ABV so people know what they are drinking")]
        [RegularExpression(@"^\d*.\d{0,1}$", ErrorMessage = "Make sure that your ABV has only 1 decimal point : )")]
        public double ABV { get; set; }
        
        [Required(ErrorMessage = "Yah, you should probably provide a description here.  What should people expect when they drink your concoction?")]
        public string BeerDescription { get; set; }
        [Required(ErrorMessage = "Yah, I'm going to need this too.  It helps build out the database.")]
        public DateTime FirstBrewed { get; set; }

        public byte[] Photo { get; set; }
  

    public virtual ICollection<Brewed> Brewing { get; set; }
    public virtual ICollection<File> Files { get; set; }
    }

}