using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.BUS
{
    public class MajorService
    {
        public List<Major> getAllMajorLst()
        {
            StudentModel studentModel = new StudentModel();
            return studentModel.Majors.ToList();
        }
        public List<Major> getAllMajorLstByFacultyID(int facultyId)
        {
            using (StudentModel studentModel = new StudentModel())
            {
                return studentModel.Majors
                    .Where(m => m.FacultyID == facultyId)
                    .ToList();
            }
        }
    }
}