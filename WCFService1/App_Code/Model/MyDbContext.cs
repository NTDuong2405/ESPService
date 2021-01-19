using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MyDbContext
/// </summary>
public class MyDbContext: DbContext
{
    public MyDbContext(): base("MyConectionEmployees")
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DbSet<Employee> Employees { get; set; }
}