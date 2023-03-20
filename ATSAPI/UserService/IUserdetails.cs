using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiCoreWithEF.Context;
using WebApiCoreWithEF.Models;

namespace ATSAPI.Interface
{
    public interface IUserdetails
    {
        // private readonly AngularContext _context;
        public string SendCommand()
        {
            return "Command Sent via Interface";
        }
        //IEnumerable<UserDetails> GetUsers();
    }

    public class Userdetails : IUserdetails
    {
        private readonly AngularContext _context;
        public void GetMileage()
        {
            Console.WriteLine("10 KM Per Liter");
        }

        public void GetSpeed()
        {
            Console.WriteLine("200 KMPH");
        }
        public void SendCommand()
        {
            Console.WriteLine("Command Sent via Morris Garage Class");
        }

        //IEnumerable<UserDetails> IUserdetails.GetUsers()
        //{
        //    return _context.Users;
        //}
    }
}
