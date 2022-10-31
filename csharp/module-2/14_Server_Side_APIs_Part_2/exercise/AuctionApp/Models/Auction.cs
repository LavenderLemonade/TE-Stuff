using System.ComponentModel.DataAnnotations;

namespace AuctionApp.Models
{
    public class Auction
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You need a title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "You need a description.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "You need a username.")]
        public string User { get; set; }

        [Range(1, 20, ErrorMessage = "Bid cannot be 0.")]
        public double CurrentBid { get; set; }
        

        public Auction()
        {
        }

    }
}
