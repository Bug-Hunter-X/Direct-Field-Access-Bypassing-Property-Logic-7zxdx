public class ExampleClass{
    private int _myField;

    public int MyProperty {
        get { return _myField; }
        set {
            // Add validation or logic here
            if (value >= 0) { 
                _myField = value; 
            }
            else{
                Console.WriteLine("Invalid Value");
            }
        }
    }

    public void MyMethod() {
        // Always access the field through the property to enforce validation
        MyProperty = 10; 
    }
}