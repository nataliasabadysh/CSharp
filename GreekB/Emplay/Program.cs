/* CS2 Урок 2 Задание 1
1. Построить три класса (базовый и 2 потомка), описывающих работников с почасовой
оплатой (один из потомков) и фиксированной оплатой (второй потомок):
a. Описать в базовом классе абстрактный метод для расчета среднемесячной
заработной платы. Для «повременщиков» формула для расчета такова:
© geekbrains.ru 33
«среднемесячная заработная плата = 20.8 * 8 * почасовая ставка»; для работников с
фиксированной оплатой: «среднемесячная заработная плата = фиксированная
месячная оплата»;
b. Создать на базе абстрактного класса массив сотрудников и заполнить его;
c. * Реализовать интерфейсы для возможности сортировки массива, используя
Array.Sort() ;
d. * Создать класс, содержащий массив сотрудников, и реализовать возможность вывода
данных с использованием foreach .

Выполнил Тимофеев Дмитрий */

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new EmployeeWithHourlyPayment("Марс","Панин",550),
                new EmployeeWithHourlyPayment("Тарас","Бульба",1000),
                new EmployeeWithHourlyPayment("Иннокентий","Марков",350),
                new EmployeeWithHourlyPayment("Вениамин","Смехов",500),
                new EmployeeWithSalary("Степан","Максимов",50000),
                new EmployeeWithSalary("Фёдор","Кононов",150000),
                new EmployeeWithSalary("Артемий","Демидов",200000),
                new EmployeeWithSalary("Юлиан","Шпак",175000),
            };

            var myCompany = new Company("IT Abstract Group",employees);

            PrintEmployees(myCompany);

            Array.Sort(myCompany.Employees);
            Console.WriteLine("\nСорировка по фамилии");
            PrintEmployees(myCompany);

            Array.Sort(myCompany.Employees, (Employee x, Employee y) => x.AverageSalary.CompareTo(y.AverageSalary));
            Console.WriteLine("\nСорировка по размеру з/п");
            PrintEmployees(myCompany);

            Console.ReadKey();
        }
        /// <summary>
        /// Выводит на консоль массив сотрудников
        /// </summary>
        /// <param name="_myCompany">Компания</param>
        static void PrintEmployees(Company _myCompany)
        {
            Console.WriteLine($"Список сотрудников компании {_myCompany.CompanyName}");
            foreach (Employee item in _myCompany.Employees)
            {
                Console.WriteLine($"{item.firstName,15} {item.lastName,-15} среднемесячная зарплата: {item.AverageSalary} рублей в месяц");
            }
        }
    }
}
