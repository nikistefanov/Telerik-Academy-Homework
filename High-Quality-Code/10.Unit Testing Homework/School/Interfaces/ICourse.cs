namespace SchoolSystem.Interfaces
{
    using System.Collections.Generic;

    public interface ICourse
    {
        string Name { get; }
        IList<IStudent> Students { get; }
        void AddStudent(IStudent student);
        void RemoveStudent(IStudent student);
    }
}
