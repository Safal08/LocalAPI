using System;

namespace LocalAppAPI.Doman
{
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
        public int TimeZone{ get; set; }

        public int ThirdPartyID { get; set; }

        public string Description { get; set; }
        public bool IsActive{ get; set; }
        public bool IsDeleted { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate{ get; set; }
        public string userObjectID { get; set; }
    }
}
