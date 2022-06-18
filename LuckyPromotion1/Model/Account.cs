using System.ComponentModel.DataAnnotations;

namespace LuckyPromotion1.Model
{
    public class Account
    {
        [Key] public  int AccountID { get;set; }
        
        
        public string Username { get;set; }
       
        public int Password { get;set; }
       
        public string Email { get;set; }
        
        public Role Role { get;set; }

        }

    public enum Role
    {
        Admin, Customer
    }


}
