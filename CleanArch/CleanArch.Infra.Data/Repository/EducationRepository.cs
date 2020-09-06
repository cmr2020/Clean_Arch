using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class EducationRepository : IEducationRepository
    {
        private UniversityDBContext _context;

        public EducationRepository(UniversityDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Education> GetAllEducation()
        {
            return _context.Educations.ToList();
        }

        public Education GetEducationById(int educationId)
        {
            return _context.Educations.Find(educationId);
        }

        public void InsertEducation(Education educatio)
        {
            _context.Educations.Add(educatio);
        }
        public void UpdateEducation(Education education)
        {
            _context.Entry(education).State = EntityState.Modified;
        }
        public void DeleteEducation(Education education)
        {
            _context.Entry(education).State = EntityState.Deleted;
        }

        public void DeleteEducation(int educationId)
        {
            var education = GetEducationById(educationId);
            DeleteEducation(education);
        }

        public bool EducationExists(int educationId)
        {
            return _context.Educations.Any(p => p.EducationId == educationId);
        }

        public void Save()
        {
            _context.SaveChanges();
        }


    }
}
