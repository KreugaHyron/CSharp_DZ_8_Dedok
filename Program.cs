namespace CSharp_DZ_8_Dedok
{
    //1
    public class Employee
    {
        private string fullName;
        private DateTime birthDate;
        private string contactPhone;
        private string workEmail;
        private string position;
        private string jobDescription;
        private decimal salary;
        public Employee(string fullName, DateTime birthDate, string contactPhone, string workEmail, string position, string jobDescription, decimal salary)
        {
            this.fullName = fullName;
            this.birthDate = birthDate;
            this.contactPhone = contactPhone;
            this.workEmail = workEmail;
            this.position = position;
            this.jobDescription = jobDescription;
            this.salary = salary;
        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        public string ContactPhone
        {
            get { return contactPhone; }
            set { contactPhone = value; }
        }
        public string WorkEmail
        {
            get { return workEmail; }
            set { workEmail = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public string JobDescription
        {
            get { return jobDescription; }
            set { jobDescription = value; }
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public void InputData()
        {
            Console.WriteLine("Введите ФИО:");
            FullName = Console.ReadLine();

            Console.WriteLine("Введите дату рождения (гггг-мм-дд):");
            BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите контактный телефон:");
            ContactPhone = Console.ReadLine();

            Console.WriteLine("Введите рабочий email:");
            WorkEmail = Console.ReadLine();

            Console.WriteLine("Введите должность:");
            Position = Console.ReadLine();

            Console.WriteLine("Введите описание служебных обязанностей:");
            JobDescription = Console.ReadLine();

            Console.WriteLine("Введите зарплату:");
            Salary = decimal.Parse(Console.ReadLine());
        }
        public void PrintData()
        {
            Console.WriteLine($"ФИО: {FullName}");
            Console.WriteLine($"Дата рождения: {BirthDate.ToShortDateString()}");
            Console.WriteLine($"Контактный телефон: {ContactPhone}");
            Console.WriteLine($"Рабочий email: {WorkEmail}");
            Console.WriteLine($"Должность: {Position}");
            Console.WriteLine($"Описание служебных обязанностей: {JobDescription}");
            Console.WriteLine($"Зарплата: {Salary}");
        }
        public static Employee operator +(Employee emp, decimal amount)
        {
            emp.Salary += amount;
            return emp;
        }
        public static Employee operator -(Employee emp, decimal amount)
        {
            emp.Salary -= amount;
            return emp;
        }
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.Salary == emp2.Salary;
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.Salary != emp2.Salary;
        }
        public static bool operator <(Employee emp1, Employee emp2)
        {
            return emp1.Salary < emp2.Salary;
        }
        public static bool operator >(Employee emp1, Employee emp2)
        {
            return emp1.Salary > emp2.Salary;
        }
        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                return this == (Employee)obj;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Salary.GetHashCode();
        }
        //2
        public class City
        {
            private string cityName;
            private string countryName;
            private int population;
            private string phoneCode;
            private string[] districts;

            // Конструктор
            public City(string cityName, string countryName, int population, string phoneCode, string[] districts)
            {
                this.cityName = cityName;
                this.countryName = countryName;
                this.population = population;
                this.phoneCode = phoneCode;
                this.districts = districts;
            }

            // Свойства
            public string CityName
            {
                get { return cityName; }
                set { cityName = value; }
            }

            public string CountryName
            {
                get { return countryName; }
                set { countryName = value; }
            }

            public int Population
            {
                get { return population; }
                set { population = value; }
            }

            public string PhoneCode
            {
                get { return phoneCode; }
                set { phoneCode = value; }
            }

            public string[] Districts
            {
                get { return districts; }
                set { districts = value; }
            }

            // Метод для ввода данных
            public void InputData()
            {
                Console.WriteLine("Введите название города:");
                CityName = Console.ReadLine();

                Console.WriteLine("Введите название страны:");
                CountryName = Console.ReadLine();

                Console.WriteLine("Введите количество жителей:");
                Population = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите телефонный код города:");
                PhoneCode = Console.ReadLine();

                Console.WriteLine("Введите количество районов города:");
                int districtCount = int.Parse(Console.ReadLine());
                Districts = new string[districtCount];

                for (int i = 0; i < districtCount; i++)
                {
                    Console.WriteLine($"Введите название района {i + 1}:");
                    Districts[i] = Console.ReadLine();
                }
            }

            // Метод для вывода данных
            public void PrintData()
            {
                Console.WriteLine($"Название города: {CityName}");
                Console.WriteLine($"Название страны: {CountryName}");
                Console.WriteLine($"Количество жителей: {Population}");
                Console.WriteLine($"Телефонный код города: {PhoneCode}");
                Console.WriteLine("Районы города:");
                foreach (var district in Districts)
                {
                    Console.WriteLine($"- {district}");
                }
            }

            // Перегрузка операторов
            public static City operator +(City city, int amount)
            {
                city.Population += amount;
                return city;
            }

            public static City operator -(City city, int amount)
            {
                city.Population -= amount;
                return city;
            }

            public static bool operator ==(City city1, City city2)
            {
                return city1.Population == city2.Population;
            }

            public static bool operator !=(City city1, City city2)
            {
                return city1.Population != city2.Population;
            }

            public static bool operator <(City city1, City city2)
            {
                return city1.Population < city2.Population;
            }

            public static bool operator >(City city1, City city2)
            {
                return city1.Population > city2.Population;
            }

            public override bool Equals(object obj)
            {
                if (obj is City)
                {
                    return this == (City)obj;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return Population.GetHashCode();
            }
            internal class Program
            {
                static void Main(string[] args)
                {
                    //Task_1 - класс «Сотрудник».
                    Employee employee1 = new Employee("Иван Иванов", new DateTime(1985, 5, 10), "123-456-7890", "ivanov@example.com", "Менеджер", "Управление проектами", 50000m);
                    Employee employee2 = new Employee("Мария Петрова", new DateTime(1990, 3, 25), "098-765-4321", "petrova@example.com", "Разработчик", "Разработка программного обеспечения", 70000m);
                    Console.WriteLine("Task_1:");
                    employee1.PrintData();
                    employee2.PrintData();

                    Console.WriteLine("Увеличиваем зарплату первого сотрудника на 5000...");
                    employee1 += 5000m;
                    employee1.PrintData();

                    Console.WriteLine("Уменьшаем зарплату второго сотрудника на 10000...");
                    employee2 -= 10000m;
                    employee2.PrintData();

                    Console.WriteLine($"Зарплаты сотрудников равны? {employee1 == employee2}");
                    Console.WriteLine($"Зарплата первого сотрудника больше? {employee1 > employee2}");
                    Console.WriteLine($"Зарплата первого сотрудника меньше? {employee1 < employee2}");
                    Console.WriteLine();
                    //Task_2 - класс "Город"
                    City city1 = new City("Киев", "Украина", 12635466, "495", new string[] { "Бучанский", "Белоцерковский", "Печерский" });
                    City city2 = new City("Одесса", "Украина", 5383968, "812", new string[] { "Киевский", "Черёмушки", "Приморский" });
                    Console.WriteLine("Task_2:");
                    city1.PrintData();
                    city2.PrintData();

                    Console.WriteLine("Увеличиваем количество жителей первого города на 100000...");
                    city1 += 100000;
                    city1.PrintData();

                    Console.WriteLine("Уменьшаем количество жителей второго города на 50000...");
                    city2 -= 50000;
                    city2.PrintData();

                    Console.WriteLine($"Количество жителей в городах равно? {city1 == city2}");
                    Console.WriteLine($"Количество жителей в первом городе больше? {city1 > city2}");
                    Console.WriteLine($"Количество жителей в первом городе меньше? {city1 < city2}");
                    Console.WriteLine();
                }
            }
        }
    }
}