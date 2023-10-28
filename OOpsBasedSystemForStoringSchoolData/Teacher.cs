using System;


namespace OOpsBasedSystemForStoringSchoolData
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
      
        public Teacher(string name, string @class, string section)
        {
            Name = name;
            Class = @class;
            Section = section;
            //SubjectCode = code;
        }
        public Teacher() { }
    }
}