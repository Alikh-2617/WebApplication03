namespace WebApplication03.ViewModels
{
    public class UserRolesVM
    {  
        // vad ska den class skickar berående på Modelen 

        public string Name { get; set; }

        public string  UserId { get; set; }

        // här  kunde vara en List<IdentityRole> men det blivit svårt så vi kan ha en lista av stringar sen vi kan lägga i den istället 
        public List<string> Roles { get; set; } = new List<string>();   
    }
}
