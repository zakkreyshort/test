using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;


namespace CurrentMood.Models
{
  public class Chat
  {
    
    public int ChatId { get; set; }
    public int UserId { get; set; }
    public virtual ApplicationUser User { get; set; }
    public ICollection<Chat> Chats { get; }
  }
}