namespace OpenVkNetApi.Models.UsersModels
{
    public class UsersList
    {
        public int count { get; set; }
        public User[] items { get; set; }
    }
    public class User
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public bool Is_Closed { get; set; }
        public bool Can_Access_Closed { get; set; }
        public int Online { get; set; }
        public int? Verified { get; set; }
        public int? Sex { get; set; }
        public int? Has_Photo { get; set; }
        public string? Photo_Max_Orig { get; set; }
        public string? Photo_Max { get; set; }
        public string? Photo_50 { get; set; }
        public string? Photo_100 { get; set; }
        public string? Photo_200 { get; set; }
        public string? Photo_200_Orig { get; set; }
        public string? Photo_400_Orig { get; set; }
        public string? Status { get; set; }
        public string? Screen_Name { get; set; }
        public int? Friend_Status { get; set; }
        public Last_Seen? Last_Seen { get; set; }
        public string? Music { get; set; }
        public string? Movies { get; set; }
        public string? TV { get; set; }
        public string? Books { get; set; }
        public string? City { get; set; }
        public string? Interests { get; set; }
    }
    public class Last_Seen
    {
        public int Platform { get; set; }
        public int Time { get; set; }
    }
}
