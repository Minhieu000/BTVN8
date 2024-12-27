using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.BUS
{
    public class FacultyService
    {
        public List<Faculty> getAllFaculty()
        {
            StudentModel studentModel = new StudentModel();
            return studentModel.Faculties.ToList();
        }
        public Faculty findFaculty(int id)
        {
            StudentModel studentModel = new StudentModel();
            return studentModel.Faculties.FirstOrDefault(p => p.FacultyID == id);
        }
        public void insertFaculty(Faculty facItem)
        {
            StudentModel studentModel = new StudentModel();
            studentModel.Faculties.AddOrUpdate(facItem);
            studentModel.SaveChanges();
        }
        public void updateFaculty(Faculty facItem)
        {
            StudentModel studentModel = new StudentModel();
            studentModel.Faculties.AddOrUpdate(facItem);
            studentModel.SaveChanges();
        }
        public void deleteFaculty(int facID)
        {
            StudentModel studentModel = new StudentModel();
            Faculty item = studentModel.Faculties.FirstOrDefault(p => p.FacultyID == facID);
            studentModel.Faculties.Remove(item);
            studentModel.SaveChanges();
        }
    }
}