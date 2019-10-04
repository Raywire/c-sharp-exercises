using System.Collections.Generic;

namespace Treehouse
{
    class SchoolRoll
    {
        private List<Student> _students = new List<Student>();
        
        // public List<Student> Students { get { return _students; } } 
        // This is dangerous as it allows anyone to bypass AddStudents 
        // and we only wanted to get students not perform other functions
        // on the _students List to avoid this we can change the List to IEnumerable
        public IEnumerable<Student> Students { get { return _students; } } 
        public void AddStudents(IEnumerable<Student> students)
        {
            _students.AddRange(students);
        }
    }
}
