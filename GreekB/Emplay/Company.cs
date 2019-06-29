using System.Collections;

namespace Task_1
{
    /// <summary>
    /// Компания
    /// </summary>
    class Company : IEnumerable
    {
        /// <summary>
        /// Название компании
        /// </summary>
        public string CompanyName { get; protected set; }
        /// <summary>
        /// Сотрудники компании
        /// </summary>
        public Employee[] Employees { get; protected set; }

        public Employee this[int index]
        {
            get => Employees[index];
            set => Employees[index] = value;
        }

        public Company(string _companyName, Employee[] _employees)
        {
            this.CompanyName = _companyName;
            this.Employees = new Employee[_employees.Length];
            this.Employees = (Employee[])_employees.Clone();
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.Employees.Length; i++)
            {
                yield return this.Employees[i];
            }
        }
    }
}
