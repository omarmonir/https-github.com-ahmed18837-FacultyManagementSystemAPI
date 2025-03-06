﻿namespace FacultyManagementSystemAPI.Models.DTOs.Class
{
    public class ClassDto
    {
        public int Id { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public string Day { get; set; }

        public string Location { get; set; }

        public string ProfessorName { get; set; }

        public string CourseName { get; set; }
    }
}
