using System;
using System.Collections.Generic;
using System.Linq;

namespace yusifmuasirsdf
{
    // Sənəddə tələb olunan abstrakt sinif
    public abstract class EmployeeServiceBase
    {
        public abstract bool AddEmployee(Employee employee);
        public abstract Employee FindEmployee(string code);
        public abstract bool AddPayment(string employeeCode, string title, double amount);
        public abstract List<Payment> GetEmployeePayments(string employeeCode);
        public abstract List<Employee> GetAllEmployees();
    }

    // Abstract sinifdən miras alan və RAM-da (Static List) saxlayan servis
    public class EmployeeService : EmployeeServiceBase
    {
        // Bütün işçilər static List-də saxlanılır (RAM-da)
        public static List<Employee> Employees = new List<Employee>();

        public override bool AddEmployee(Employee employee)
        {
            if (employee == null || string.IsNullOrEmpty(employee.Code))
            {
                return false;
            }

            // Eyni koda malik işçinin olub-olmadığını yoxlayırıq
            foreach (var emp in Employees)
            {
                if (emp.Code.Equals(employee.Code, StringComparison.OrdinalIgnoreCase))
                {
                    return false; // Eyni kod artıq var
                }
            }

            Employees.Add(employee);
            return true;
        }

        public override Employee FindEmployee(string code)
        {
            if (string.IsNullOrEmpty(code)) return null;

            foreach (var emp in Employees)
            {
                if (emp.Code.Equals(code, StringComparison.OrdinalIgnoreCase))
                {
                    return emp;
                }
            }
            return null;
        }

        public override bool AddPayment(string employeeCode, string title, double amount)
        {
            Employee emp = FindEmployee(employeeCode);
            if (emp == null || amount <= 0 || string.IsNullOrEmpty(title))
            {
                return false;
            }

            emp.Payments.Add(new Payment(title, amount));
            return true;
        }

        public override List<Payment> GetEmployeePayments(string employeeCode)
        {
            Employee emp = FindEmployee(employeeCode);
            if (emp == null)
            {
                return null;
            }
            return emp.Payments;
        }

        public override List<Employee> GetAllEmployees()
        {
            return Employees;
        }
    }
}