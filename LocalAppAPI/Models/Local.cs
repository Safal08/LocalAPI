using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocalAppAPI.Models
{ 
    /*public class Local
    {
        public Int64 UserID { get; set; }
        public Int64 OrganizationID { get; set; }
        public Int64 UserTypeID { get; set; }
        [Required(ErrorMessage = "Please select appropriate title")]
        public String Title { get; set; }
        [Required(ErrorMessage = "Please enter your first name")]
        [Display(Name = "First_Name")]
        public String First_Name { get; set; }
        public String Middle_Name { get; set; }
        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name")]
        public String Last_Name { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public String Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public String Phone { get; set; }
        public String DisplayName { get; set; } //timezone display name
        public Int64 Timezone { get; set; }
        public Int64 ThirdPartyID { get; set; }
        public String Description { get; set; }
        public String Notes { get; set; }
        public Nullable<DateTime> CreationDate { get; set; }
        public Nullable<DateTime> ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public Nullable<Boolean> IsDeleted { get; set; }
        public string UserObjectID { get; set; }
        public string Name { get; set; }
    }*/



    public class Local
        {
            public string name { get; set; }
            public int OrganizationID { get; set; }
            public int UserID { get; set; }

            public int UserTypeID { get; set; }
            public string Title { get; set; }
            public string First_Name { get; set; }
            public string Middle_Name { get; set; }
            public string Last_Name { get; set; }
            public string Email { get; set; }

            public int phone { get; set; }
            public int TimeZone { get; set; }

            public int ThirdPartyID { get; set; }

            public string Description { get; set; }
            public bool IsActive { get; set; }
            public bool IsDeleted { get; set; }

            public DateTime CreationDate { get; set; }
            public DateTime ModifiedDate { get; set; }
            public string userObjectID { get; set; }
        }
    
}
