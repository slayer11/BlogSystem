﻿namespace BlogSystem.ConsoleClient
{
	using System;
	using BlogSystem.Data;
	using BlogSystem.Models;

	public class Program
	{
		public static void Main(string[] args)
		{
			using (var db = new BlogSystemDbContext())
			{
				db.Users.Add(new User
				{
					Username = "csyntax",
					Gender = Gender.Male,
					RegistrationDate = DateTime.Now,
					FullName = "Ivan Ivanov",
					Birthday = new DateTime(1998, 12, 10),
					ContactInfo = new UserContactInfo
					{
						Twitter = "@csyntax",
						Facebook = "IvanIvanov",
						PhoneNumber = "0888888888",
						Skype = "ivanivanov982"
					}
				});

				db.SaveChanges();
			}
		}
	}
}