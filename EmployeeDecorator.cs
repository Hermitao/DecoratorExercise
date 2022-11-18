public class EmployeeDecorator: Employee {  
    Employee _employee = null;  
    public EmployeeDecorator(Employee employee) {  
        this._employee = employee;  
    }  
    public override string Display() {  
        return _employee.Display();  
    }  
}  
