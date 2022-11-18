
    using System.Text;
    
    public class EmployeeConcrete: Employee {  
        public string FirstName {  
            set;  
            get;  
        }  
        public string LastName {  
            set;  
            get;  
        }  
        public string Address {  
            set;  
            get;  
        }  
        public override string Display() {  
            StringBuilder data = new StringBuilder();  
            data.Append("First name: " + FirstName);  
            data.Append("\nLast name: " + LastName);  
            data.Append("\nAddress: " + Address);  
            return data.ToString();  
        }  
    }  
