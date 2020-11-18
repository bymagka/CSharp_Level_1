public struct FindingParametrs
{
    //   д) сделал через статические поля, так как не понял как в предикат передать значение, с которым надо сравнивать поле
    public static string Value { get; set; }
    //   д) сделал через статические поля, так как не понял как в предикат передать значение, с которым надо сравнивать поле
    public static string Field { get; set; }

    //   д) разработать единый метод подсчета количества студентов по различным параметрам
    //      выбора с помощью делегата и методов предикатов.
    public static bool FindAll(Student st)
    {
        switch (Field.ToLower())
        {
            case "age":
                return st.age == int.Parse(Value);
            case "lastname":
                return st.lastName == Value;
            case "firstName":
                return st.firstName == Value;
            case "university":
                return st.university == Value;
            case "faculty":
                return st.faculty == Value;
            case "course":
                return st.course == int.Parse(Value);
            case "department":
                return st.department == Value;
            case "group":
                return st.group == int.Parse(Value);
            case "city":
                return st.city == Value;
            default:
                return false;
        }
      
            
    } 
}

public class Student
{
    public FindingParametrs FindingStruct;

    public string lastName;
    public string firstName;
    public string university;
    public string faculty;
    public int course;
    public string department;
    public int group;
    public string city;
    public int age;
    // Создаем конструктор
    public Student(string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.university = university;
        this.faculty = faculty;
        this.department = department;
        this.course = course;
        this.age = age;
        this.group = group;
        this.city = city;
    }
}
