using System;
using System.ComponentModel.DataAnnotations;


namespace sampleCRUD.Model
{
    public class Employee
    {

            [Key]
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string City { get; set; }
            public int Salary { get; set; }

      
    }
}
    

