Employee.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication3
{
class Employee
{
public int default_hours = 40;
public double half_rate = 1.5;
public double a1;
public double b1;
public String FirstName;
public String LastName;
public int Age;
public int rate;
public int Hours_worked;

public void insert(String firstName, String lastName, int age, int regRate, int Hours)
{
FirstName = firstName;
LastName = lastName;
Age = age;
rate = regRate;
Hours_worked=Hours;

}
public double calc()
{
a1 = (Hours_worked - default_hours) * (rate * half_rate);

b1 = default_hours * rate;

return a1 + b1;

}
  

}
}
