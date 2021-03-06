using System;
using System.Collections.Generic;

namespace Assignment02
{
  
    public record ImmutableStudent
    {
       public int Id {get; init;}

       public string GivenName {get; init;}

       public string Surname {get; init;}

       public Status Status {get; init;}

       public DateTime StartDate  {get; init;}

       public DateTime  EndDate {get; init;}
       public DateTime GraduationDate  {get; init;}  
        }
       
       
}
