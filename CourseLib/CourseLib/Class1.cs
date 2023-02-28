namespace CourseLib;

public class Schedule
{
    public DateTime startTime;
    public DateTime endTime;
    public List<DayOfWeek> daysOfWeek;
}

public class Courses 
{
    public SortedList<string, Course> sortedList;
    public string this[string key]
    {
        get { return sortedList[key]; }
        set { sortedList[key] = value; }
    }
    

}

public class Course : IComparable<Course>
{
    public string courseCode;
    public string description;
    public string teacherEmail;
    public Schedule Schedule;


}
