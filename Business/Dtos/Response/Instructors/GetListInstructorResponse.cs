using Business.Dtos.Response.Bootcamps;

namespace Business.Dtos.Response.Instructors
{
    public class GetListInstructorResponse
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }       // User Inherited
        public string LastName { get; set; }        // User Inherited
        public string Email { get; set; }           // User Inherited
        public string Password { get; set; }
        public string UserName { get; set; }        // User Inherited
        public List<BootcampDto>? Bootcamps { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

    }
}
