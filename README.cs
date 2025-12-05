using System;

class PersonName
{
    public string? FirstName { get; set; }
    public string? Surname { get; set; }
    public string? Lastname { get; set; }
}

class Address
{
    public string? Country { get; set; }
    public string? Region { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
    public int HouseNumber { get; set; }
    public char Korpus { get; set; }
    public short PostalCode { get; set; }
}

class BirthInfo
{
    public int BirthDay { get; set; }
    public int BirthMonth { get; set; }
    public int BirthYear { get; set; }
    public string? ZnakZodiaka { get; set; }
}

class StudyInfo
{
    public int StartDay { get; set; }
    public int StartMonth { get; set; }
    public int StartYear { get; set; }

    public int Kurs { get; set; }
    public string? GroupName { get; set; }
    public string? Specialization { get; set; }
    public int StudentsCount { get; set; }
}

class AcademicPerformance
{
    public int LessonsVisited { get; set; }
    public int LessonsLate { get; set; }

    public string? TeacherName { get; set; }
    public string? SubjectName { get; set; }

    public int[]? DzRates { get; set; }
    public float DzAverageRate { get; set; }

    public int[]? PracticeRates { get; set; }
    public float PracticeAverageRate { get; set; }

    public int[]? ExamRates { get; set; }
    public float ExamAverageRate { get; set; }

    public int[]? ZachetRates { get; set; }
    public int ZachetCount { get; set; }
    public float ZachetAverageRate { get; set; }

    public double TotalAverageRate { get; set; }
}

class Student
{
    public PersonName Name { get; set; }
    public Address Address { get; set; }
    public BirthInfo Birth { get; set; }
    public StudyInfo Study { get; set; }
    public AcademicPerformance Performance { get; set; }

    public Student()
    {
        Name = new PersonName();
        Address = new Address();
        Birth = new BirthInfo();
        Study = new StudyInfo();
        Performance = new AcademicPerformance();
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            Name = new PersonName
            {
                FirstName = "Kirill",
                Surname = "Ovsianikov",
                Lastname = "Andriyovich"
            },

            Address = new Address
            {
                Country = "Ukraine",
                Region = "odesskiy",
                City = "odessa",
                Street = "bogdana chmelnyckiy",
                HouseNumber = 29,
                Korpus = 'П',
                PostalCode = 12345
            },

            Birth = new BirthInfo
            {
                BirthDay = 5,
                BirthMonth = 2,
                BirthYear = 2010,
                ZnakZodiaka = "vodoley"
            },

            Study = new StudyInfo
            {
                StartDay = 1,
                StartMonth = 9,
                StartYear = 2016,
                Kurs = 3,
                GroupName = "П-45",
                Specialization = "IT",
                StudentsCount = 28
            },

            Performance = new AcademicPerformance
            {
                LessonsVisited = 120,
                LessonsLate = 5,
                TeacherName = "Kirill Ovsianikov",
                SubjectName = "ZOP",
                DzRates = new int[] { 9, 11, 8 },
                PracticeRates = new int[] { 12, 10, 12 },
                ExamRates = new int[] { 9 },
                ZachetRates = new int[] { 8 },
                ZachetCount = 2,
                TotalAverageRate = 9.8
            }
        };

        Console.WriteLine("студент создан");
        Console.WriteLine($"имя: {student.Name.FirstName} {student.Name.Surname}");
        Console.WriteLine($"место учебы: {student.Address.City}");
        Console.WriteLine($"спецальность: {student.Study.Specialization}");
        Console.WriteLine($"средний арефмитический балл за все задания: {student.Performance.TotalAverageRate}");
    }
}
