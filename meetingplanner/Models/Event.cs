namespace meetingplanner.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CityId { get; set; }
    }
}