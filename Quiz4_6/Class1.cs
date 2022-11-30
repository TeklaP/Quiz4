namespace Quiz4_6;

public class Employee
{
    private string _firstName;
    private string _lastName;
    private string _personalID;
    private int _salary;
    private Department _department;

    public Employee(string firstName, string lastName, string personalId, int salary, Department department)
    {
        _firstName = firstName;
        _lastName = lastName;
        _personalID = personalId;
        _salary = salary;
        _department = department;
    }

    public Employee()
    {
    }
}

public class Department
{
    private string _departmentName;
    private int _maxNumberOfEmployees;
    private List<Employee> _employees;
    

    public Department(string departmentName, int maxNumberOfEmployees, List<Employee> employees)
    {
        _departmentName = departmentName;
        _maxNumberOfEmployees = maxNumberOfEmployees;
        _employees = employees;
    }

    public void AddEmployee()
    {
        if (_employees.Count < _maxNumberOfEmployees)
        {
            _employees.Add(Employee);
        }
        else
        {
            Console.WriteLine("This department has the maximum number of employees");
        }
    }

    public void RemoveEmployee()
    {
        _employees.Remove(Employee);
    }

    public Employee Employee { get; set; }
    
}


