using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UserManagement.Context;
using UserManagement.Models;

namespace UserManagement.Controllers
{
    public class UserController
    {
        public void AddUser(string email, string pword)
        {
            var result = 0;
            User user = new User();
            MyContext _context = new MyContext();

            user.Email = email;
            user.Password = pword;
            _context.Users.Add(user);
            result = _context.SaveChanges();

            if (result > 0)
            {
                MessageBox.Show("Register Successful!");
            }
            else
            {
                MessageBox.Show("Register Failed!");
            }
        }

        public void UserLogin(string email, string pword)
        {

            User user = new Models.User();
            MyContext _context = new MyContext();

            var get = _context.Users.Where(u => u.Email == email).FirstOrDefault<User>();

            if (get == null)
            {
                MessageBox.Show("You are not Registered yet!");
            }
            else
            {
                if (get.Password != pword)
                {
                    MessageBox.Show("Your Password is Incorrect!");
                }
                else
                {
                    MessageBox.Show("Login Successful!");
                }
            }
        }

        public void ChangePass(string email, string pword)
        {
            var result = 0;

            User user = new User();
            MyContext _context = new MyContext();

            var get = _context.Users.Where(u => u.Email == email).FirstOrDefault<User>();

            if (get == null)
            {
                MessageBox.Show("Your Username is Incorrect!");
            }
            else
            {
                if (get.Password != pword)
                {
                    get.Password = pword;
                    result = _context.SaveChanges();

                    if (result > 0)
                    {
                        MessageBox.Show("Update Success!");
                    }
                    else
                    {
                        MessageBox.Show("Update Failed!");
                    }
                }
                else
                {
                    MessageBox.Show("Your Password can't be the same!");
                }
            }
        }
    }
}
