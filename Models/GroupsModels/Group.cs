namespace OpenVkNetApi.Models.GroupsModels
{
    public class GroupsList
    {
        public int Count { get; set; }
        public Group[] Items { get; set; }
    }

    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Screen_Name { get; set; }
        public bool Is_Closed { get; set; }
        public bool Can_Access_Closed { get; set; }
        public int? Verified { get; set; }
        public int? Has_Photo { get; set; }
        public string? Photo_Max_Orig { get; set; }
        public string? Photo_Max { get; set; }
        public string? Photo_50 { get; set; }
        public string? Photo_100 { get; set; }
        public string? Photo_200 { get; set; }
        public string? Photo_200_Orig { get; set; }
        public string? Photo_400_Orig { get; set; }
        public int? Members_Count { get; set; }
    }
}
