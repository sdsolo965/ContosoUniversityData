using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoSite.Models
{
    public class PartialClasses
    {
        [MetadataType(typeof(Metadata.StudentMetadata))]
        public partial class Student
        {
        }

        [MetadataType(typeof(Metadata.EnrollmentMetadata))]
        public partial class Enrollment
        {
        }
    }
}