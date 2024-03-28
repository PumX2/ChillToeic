using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using global::ChillToeic.Models;
namespace ChillToeic.Controllers
{
    


    
        public class CoursesController : Controller
        {
            // Action method for displaying the list of courses
            public IActionResult Index()
            {
                // Assuming you have some logic to fetch courses from the database or another source
                List<Course> courses = GetCoursesFromDatabase();

                // Pass the list of courses to the view using ViewData
                ViewData["Courses"] = courses;

                return View();
            }

            // Action method for displaying details of a specific course
            public IActionResult Details(int id)
            {
                // Assuming you have some logic to fetch the course details from the database based on the provided ID
                Course course = GetCourseByIdFromDatabase(id);

                // Check if the course exists
                if (course == null)
                {
                    // If the course doesn't exist, return a not found result
                    return NotFound();
                }

                // Pass the course details to the view using ViewData
                ViewData["Course"] = course;

                return View();
            }

            // Sample method to simulate fetching courses from a database
            private List<Course> GetCoursesFromDatabase()
            {
                // Sample data
                var courses = new List<Course>
            {
                new Course { Id = 1, Name = "Course 1", Price = 100 },
                new Course { Id = 2, Name = "Course 2", Price = 150 },
                new Course { Id = 3, Name = "Course 3", Price = 200 }
            };

                return courses;
            }

            // Sample method to simulate fetching a course by ID from a database
            private Course GetCourseByIdFromDatabase(int id)
            {
                // Sample data
                var courses = GetCoursesFromDatabase();

                // Find the course with the specified ID
                foreach (var course in courses)
                {
                    if (course.Id == id)
                    {
                        return course;
                    }
                }

                // Return null if the course with the specified ID is not found
                return null;
            }
        }
    }

