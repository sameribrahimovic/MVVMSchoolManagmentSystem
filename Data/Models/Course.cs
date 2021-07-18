namespace Data.Models
{
    public class Course
    {
        private int _id;
        private string _courseName;
        private string _duration;
        private string _price;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }
        public string Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
