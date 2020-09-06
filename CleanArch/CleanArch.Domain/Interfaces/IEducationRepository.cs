using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Interfaces
{
   public interface IEducationRepository
    {

        IEnumerable<Education> GetAllEducation();
        Education GetEducationById(int educationId);
        void InsertEducation(Education educatio);
        void UpdateEducation(Education education);
        void DeleteEducation(Education education);
        void DeleteEducation(int educationId);
        bool EducationExists(int educationId);
        void Save();


    }
}
