using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    public class DashboardBLL
    {
        DashboardDAL dal = new DashboardDAL();

        public int GetNumStudents() => dal.CountStudents();
        public int GetNumClasses() => dal.CountClasses();
        public int GetNumFaculties() => dal.CountFaculties();
        public int GetNumSubjects() => dal.CountSubjects();
    }
}