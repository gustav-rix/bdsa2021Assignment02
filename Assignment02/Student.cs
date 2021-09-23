using System;
using System.Collections.Generic;

namespace Assignment02
{
    public class Student
    {
       public int Id {get; init;}

       public string GivenName {get; set;}

       public string Surname  {get; set;}

       public Status Status {get; init;}
/* cant get it to work somehow with datetime.
       private Status _status;

       public Status Status {
           get{
               return _status;
           }
       set{
            if(GraduationDate == DateTime.MinValue){
               _status = Status.Dropout;
           }else if(DateTime.Now>StartDate && DateTime.Now<EndDate){
               _status = Status.Active;
           }else if(DateTime.Now<GraduationDate){
                _status = Status.Graduated;
           }
       }
       }
*/
       public DateTime StartDate   {get; set;}

       public DateTime  EndDate  {get; set;}

       public DateTime GraduationDate   {get; set;}     

       public override string ToString(){
           return $"Id: {Id} , GivenName: {GivenName} , Surname: {Surname} , Status: {Status} , StartDate: {StartDate} , EndDate: {EndDate} , GraduationDate: {GraduationDate}";  
       }  
    }
       
}
