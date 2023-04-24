// See https://aka.ms/new-console-template for more information

using Data;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

var context = new TestContext(); 

context.Database.Migrate();