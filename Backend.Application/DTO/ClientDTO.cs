namespace Backend.Apllication.DTO
{
    public class ClientDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsBlocked { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
