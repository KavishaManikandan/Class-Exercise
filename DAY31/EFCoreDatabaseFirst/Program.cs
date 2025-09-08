using System;
using System.Linq;
using EFCoreDatabaseFirst.Models;

namespace EFCoreDatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new EFCoreDBFirstDBContext();

            // READ
            var users = context.Users.ToList();
            Console.WriteLine("Users List:");
            users.ForEach(u => Console.WriteLine($"{u.Id} - {u.Username} - {u.Email}"));

            // CREATE
            var newUser = new User { Username = "Alice", Email = "alice@example.com" };
            context.Users.Add(newUser);
            context.SaveChanges();
            Console.WriteLine($"Added User: {newUser.Username}");

            // UPDATE
            var userToUpdate = context.Users.First();
            userToUpdate.Email = "newemail@example.com";
            context.SaveChanges();
            Console.WriteLine($"Updated User: {userToUpdate.Username} - {userToUpdate.Email}");

            // DELETE
            var userToDelete = context.Users.Last();
            context.Users.Remove(userToDelete);
            context.SaveChanges();
            Console.WriteLine($"Deleted User: {userToDelete.Username}");
        }
    }
}
