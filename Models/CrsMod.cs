namespace WP3.Models
{
    public class CrsMod
    {
        public List<Course> courses { get; set; }
    }

    public class Course
    {
        public string courseID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}
