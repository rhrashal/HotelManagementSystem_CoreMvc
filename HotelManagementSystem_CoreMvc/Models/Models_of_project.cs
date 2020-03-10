using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem_CoreMvc.Models
{
    public partial class Reservasion
    {
        public int ReservasionId { get; set; }
        [Required]
        [Display(Name = "Guest Name")]
        public Nullable<int> GuestId { get; set; }
        [Required]
        [Display(Name = "Room Name")]
        public Nullable<int> RoomId { get; set; }
        [Required]
        [Display(Name = "Number of Adult")]
        public Nullable<int> AdultId { get; set; }
        [Required]
        [Display(Name = "Number of Child")]
        public Nullable<int> ChildId { get; set; }
        [Required]
        [Display(Name = "Room Quantity")]
        public Nullable<int> RoomQuantityId { get; set; }
        [Required]
        [Display(Name = "Arrival Date")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> ArrivalTime { get; set; }
        [Required]
        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DepartureDate { get; set; }

        public virtual Adult Adult { get; set; }
        public virtual Child Child { get; set; }
        public virtual Guest Guest { get; set; }
        public virtual Room Room { get; set; }
        public virtual RoomQuantity RoomQuantity { get; set; }
    }
    public partial class OrderFood
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        [Display(Name = "Guest Name")]
        public Nullable<int> GuestId { get; set; }
        [Required]
        [Display(Name = "Food Name")]

        public Nullable<int> FoodId { get; set; }
        [Required]
        [Display(Name = "Item Quantity")]
        public int Quntity { get; set; }

        public virtual Food Food { get; set; }
        public virtual Guest Guest { get; set; }
    }
    public partial class Booking
    {
        public int BookingId { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + "  " + LastName;
            }
        }
        [Required]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Address")]
        [StringLength(50)]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Mobile")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "NID/Cr Card")]
        [DataType(DataType.PhoneNumber)]
        public string NID_No { get; set; }
        [Required]
        [Display(Name = "Arrival Time")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> ArrivalTime { get; set; }
        [Required]
        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DepartureDate { get; set; }
        [Required]
        [Display(Name = "Number of Adult")]
        public Nullable<int> AdultId { get; set; }
        [Required]
        [Display(Name = "Number of Child")]
        public Nullable<int> ChildId { get; set; }
        [Required]
        [Display(Name = "Room Type")]
        public Nullable<int> RoomTypeId { get; set; }
        [Required]
        [Display(Name = "Bedding Type")]
        public Nullable<int> BeddingTypeId { get; set; }
        [Required]
        [Display(Name = "Number Of Room")]
        public Nullable<int> RoomQuantityId { get; set; }
        [Required]
        [Display(Name = "Notes")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        public virtual Adult Adult { get; set; }
        public virtual BeddingType BeddingType { get; set; }
        public virtual Child Child { get; set; }
        public virtual RoomQuantity RoomQuantity { get; set; }
        public virtual RoomType RoomType { get; set; }
    }
    public partial class Guest
    {       
        public int GuestId { get; set; }
        [Display(Name = "Guest Name")]
        public string FullName
        {
            get
            {
                return FirstName + "  " + LastName;
            }
        }
        [Required]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Address")]
        [StringLength(50)]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Mobile")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "NID/Cr Card")]
        [DataType(DataType.CreditCard)]
        public string NID_No { get; set; }

        public virtual ICollection<OrderFood> OrderFoods { get; set; }
        public virtual ICollection<Reservasion> Reservasions { get; set; }
    }
    public partial class Room
    {
        public int RoomId { get; set; }
        [Required]
        [Display(Name = "Room Name")]
        [StringLength(50)]
        public string RoomTypeName { get; set; }
        [Required]
        [Display(Name = "Room Quality")]
        public Nullable<int> RoomTypeId { get; set; }
        [Required]
        [Display(Name = "Bedding Type")]
        public Nullable<int> BeddingTypeId { get; set; }

        [Display(Name = "Room Image")]
        [DataType(DataType.Upload)]
        public string ImageUrl { get; set; }
        [Required]
        [Display(Name = "Rate of Room")]
        [DataType(DataType.Currency)]
        public Nullable<decimal> Price { get; set; }

        public virtual BeddingType BeddingType { get; set; }
        public virtual ICollection<Reservasion> Reservasions { get; set; }
        public virtual RoomType RoomType { get; set; }
    }
    public partial class BeddingType
    {       
        public int BeddingTypeId { get; set; }
        [Required]
        [Display(Name = "Bedding Type")]
        [StringLength(50)]
        public string BeddingTypeName { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
    public partial class RoomQuantity
    {       
        public int RoomQuantityId { get; set; }
        [Required]
        [Display(Name = "Number Of Room")]
        [DataType(DataType.Text)]
        public int NumberOfRoom { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Reservasion> Reservasions { get; set; }
    }
    public partial class RoomType
    {
        public int RoomTypeId { get; set; }
        [Required]
        [Display(Name = "Room Type")]
        [DataType(DataType.Text)]
        public string RoomTypeName { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
    public partial class Child
    {
        public int ChildId { get; set; }
        [Required]
        [Display(Name = "Number Of Child")]
        public int NumberOfChild { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Reservasion> Reservasions { get; set; }
    }
    public partial class Adult
    {
        public int AdultId { get; set; }
        [Required]
        [Display(Name = "Number Of Adults")]
        [StringLength(50)]
        public int NumberOfAdults { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Reservasion> Reservasions { get; set; }
    }
    public partial class Food
    {
        public int FoodId { get; set; }
        [Required]
        [Display(Name = "Food Name")]
        [StringLength(50)]
        public string FoodName { get; set; }

        [Display(Name = "Food Image")]
        [DataType(DataType.Upload)]
        public string ImageUrl { get; set; }
        [Required]
        [Display(Name = "Item Price")]
        [DataType(DataType.Currency)]
        public Nullable<decimal> Price { get; set; }
        public virtual ICollection<OrderFood> OrderFoods { get; set; }
    }

}
