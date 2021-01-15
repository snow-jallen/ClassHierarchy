namespace ClassHierarchy
{
    public class Car : MotorVehicle
    {
        public Car()
        {

        }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public Car(int liters, string make)
        {
            
        }
    }
}