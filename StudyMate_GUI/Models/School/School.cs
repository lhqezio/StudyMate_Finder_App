using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyMate.Models
{
    public class School{
        [Key]
        public int SchoolId{get;set;}
        public string SchoolName{get;set;} = null!;

        [InverseProperty("School")]
        public List<Event>? EventsForSchool {get; set;}

        [InverseProperty("School")]
        public List<Profile>? ProfilsForSchool {get; set;}

        public School(){}
        public School(string schoolName){
            this.SchoolName=schoolName;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not School other)
                return false;
            return SchoolName == other.SchoolName;
        }

        public override int GetHashCode()
        {
            return SchoolName.GetHashCode();
        }
    }
}