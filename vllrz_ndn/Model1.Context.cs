﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vllrz_ndni
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using vllrz_ndn;
    using vllrz_ndni;

    public partial class EnrollmentDBEntities : DbContext
    {
        public EnrollmentDBEntities()
            : base("name=EnrollmentDBEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }

        public virtual int insertNewStudent(string firstname, string lastname)
        {
            var firstnameParameter = firstname != null ?
                new ObjectParameter("Firstname", firstname) :
                new ObjectParameter("Firstname", typeof(string));

            var lastnameParameter = lastname != null ?
                new ObjectParameter("Lastname", lastname) :
                new ObjectParameter("Lastname", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertNewStudent", firstnameParameter, lastnameParameter);
        }

        public virtual ObjectResult<myListofStudents_Result> myListofStudents()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<myListofStudents_Result>("myListofStudents");
        }
    }
}