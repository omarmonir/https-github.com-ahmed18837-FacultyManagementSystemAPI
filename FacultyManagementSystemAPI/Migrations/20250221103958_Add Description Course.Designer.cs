﻿// <auto-generated />
using System;
using FacultyManagementSystemAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FacultyManagementSystemAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250221103958_Add Description Course")]
    partial class AddDescriptionCourse
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence<int>("CommonSequence", "dbo")
                .StartsAt(1000L)
                .IncrementsBy(5);

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Attendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR dbo.CommonSequence");

                    b.Property<int>("ClassesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassesId");

                    b.HasIndex("StudentId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR dbo.CommonSequence");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("TIME");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("TIME");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR dbo.CommonSequence");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PreCourseId")
                        .HasColumnType("int");

                    b.Property<byte>("Semester")
                        .HasColumnType("tinyint");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("PreCourseId")
                        .IsUnique()
                        .HasFilter("[PreCourseId] IS NOT NULL");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.CourseDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR dbo.CommonSequence");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("CourseDepartments");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR dbo.CommonSequence");

                    b.Property<string>("HeadOfDepartment")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProfessorCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Enrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR dbo.CommonSequence");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<decimal>("Exam1Grade")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Exam2Grade")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("FinalGrade")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Grade")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Semester")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR dbo.CommonSequence");

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("DATE");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Join_Date")
                        .HasColumnType("DATE");

                    b.Property<string>("NationalId")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Professors");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR dbo.CommonSequence");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("CreditsCompleted")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("DATE");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("DATE");

                    b.Property<decimal>("GPA")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("High_School_Section")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("High_School_degree")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NationalId")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("Nationality")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Semester")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Attendance", b =>
                {
                    b.HasOne("FacultyManagementSystemAPI.Models.Entities.Class", "Class")
                        .WithMany("Attendances")
                        .HasForeignKey("ClassesId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FacultyManagementSystemAPI.Models.Entities.Student", "Student")
                        .WithMany("Attendances")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Class", b =>
                {
                    b.HasOne("FacultyManagementSystemAPI.Models.Entities.Course", "Course")
                        .WithMany("Classes")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FacultyManagementSystemAPI.Models.Entities.Professor", "Professor")
                        .WithMany("Classes")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Course", b =>
                {
                    b.HasOne("FacultyManagementSystemAPI.Models.Entities.Course", "PreCourse")
                        .WithOne()
                        .HasForeignKey("FacultyManagementSystemAPI.Models.Entities.Course", "PreCourseId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("PreCourse");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.CourseDepartment", b =>
                {
                    b.HasOne("FacultyManagementSystemAPI.Models.Entities.Course", "Course")
                        .WithMany("CourseDepartments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FacultyManagementSystemAPI.Models.Entities.Department", "Department")
                        .WithMany("CourseDepartments")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Enrollment", b =>
                {
                    b.HasOne("FacultyManagementSystemAPI.Models.Entities.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FacultyManagementSystemAPI.Models.Entities.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Professor", b =>
                {
                    b.HasOne("FacultyManagementSystemAPI.Models.Entities.Department", "Department")
                        .WithMany("Professors")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Student", b =>
                {
                    b.HasOne("FacultyManagementSystemAPI.Models.Entities.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Class", b =>
                {
                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Course", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("CourseDepartments");

                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Department", b =>
                {
                    b.Navigation("CourseDepartments");

                    b.Navigation("Professors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Professor", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("FacultyManagementSystemAPI.Models.Entities.Student", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
