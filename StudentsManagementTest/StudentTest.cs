using Microsoft.AspNetCore.Mvc;
using StudentsManagementAPI.Controllers;
using StudentsManagementAPI.Interface;
using StudentsManagementAPI.Models;
using StudentsManagementAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagementTest
{
    [TestClass]
    public class StudentTest
    {
        private readonly StudentsController _studentsController;
        private readonly IDataRepository<Student> _dataRepository;
        public StudentTest()
        {
            _dataRepository = new StudentManager();
            _studentsController = new StudentsController(_dataRepository);
        }

        [TestMethod]
        public void Get_WhenCalled_ReturnsAllStudent()
        {
            var okResult = _studentsController.Get() as OkObjectResult;
            // Assert
            var items = (IEnumerable<Student>)okResult?.Value;
            
            Assert.AreEqual(2, items.Count());
        }
    }
}
