using System;


namespace OOpsBasedSystemForStoringSchoolData

{
    public class Subject
    {
        public Subject(string name, string subjectCode, string teacherName)
        {
            Name = name;
            SubjectCode = subjectCode;
            TeacherName = teacherName;
           
        }
        public Subject() { }
        public string Name { get; set; }
        public string SubjectCode { get; set; }
        public string TeacherName { get; set; }
    }
}