using System;

namespace OOpsBasedSystemForStoringSchoolData
{
    public class Student
    {
        public Student(string name, string @class, string section)
        {
            Name = name;
            Class = @class;
            Section = section;
        }
        public Student() { }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
    }
}