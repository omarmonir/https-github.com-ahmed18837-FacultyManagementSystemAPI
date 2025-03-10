﻿using FacultyManagementSystemAPI.Models.DTOs.Classes;
using FacultyManagementSystemAPI.Models.DTOs.Courses;
using FacultyManagementSystemAPI.Models.Entities;

namespace FacultyManagementSystemAPI.Repositories.Interfaces
{
    public interface IClassRepository : IGenericRepository<Class>
    {
        Task<IEnumerable<ClassDto>> GetAllClassesWithProfNameAndCourseNameAsync();
        Task<ClassDto> GetClassByIdAsync(int courseId);
        Task<Professor> GetProfessorByNameAsync(string professorName);
        Task<Class> GetClassByProfessorNameAsync(string professorName);
        Task UpdateClassAsync(Class classEntity);
        Task<bool> IsCourseAlreadyAssignedAsync(int courseId, int departmentId);
        Task AssignCourseToProfessorAsync(int courseId, string professorName);
        Task<bool> ClassExistsAsync(int? ClassId);
        Task<bool> IsTimeAndLocationConflictAsync(TimeSpan startTime, TimeSpan endTime, string day, string location);
        Task<int> CountAsync();
        Task<IEnumerable<string>> GetAllLocationsNameAsync();
    }
}
