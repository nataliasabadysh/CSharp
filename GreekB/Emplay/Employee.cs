using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Сотрудник компании
    /// </summary>
    abstract class Employee : ICloneable, IComparable<Employee>
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string firstName;
        /// <summary>
        /// Фамилия
        /// </summary>
        public string lastName; 
        /// <summary>
        /// Средняя зарплата
        /// </summary>
        public abstract decimal AverageSalary { get; }

        public Employee(string _firstName, string _lastName)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Employee obj)
        {
            return this.lastName.CompareTo(obj.lastName);
        }
    }
    /// <summary>
    /// Сотрудник компании на окладе
    /// </summary>
    class EmployeeWithSalary : Employee
    {
        /// <summary>
        /// Размер оклада
        /// </summary>
        public decimal Salary { get; private set; }
        /// <summary>
        /// Средняя зарплата
        /// </summary>
        public override decimal AverageSalary => Salary;

        public EmployeeWithSalary(string _firstName, string _lastName, decimal _salary)
            : base (_firstName, _lastName)
        {
            this.Salary = _salary;
        }

    
    }
    /// <summary>
    /// Сотрудник компании с почасовой оплатой
    /// </summary>
    class EmployeeWithHourlyPayment : Employee
    {
        /// <summary>
        /// Размер оплаты за час работы
        /// </summary>
        public decimal HourlyPayment { get; private set; }

        private readonly decimal WorkingHoursInMoth = Convert.ToDecimal(20.8 * 8);
        /// <summary>
        /// Средняя зарплата
        /// </summary>
        public override decimal AverageSalary => HourlyPayment * WorkingHoursInMoth;

        public EmployeeWithHourlyPayment(string _firstName, string _lastName, decimal _hourlyPayment)
            : base(_firstName, _lastName)
        {
            this.HourlyPayment = _hourlyPayment;
        }
    }
}
