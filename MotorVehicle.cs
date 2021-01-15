namespace ClassHierarchy
{
    public class MotorVehicle : Vehicle
    {
        private string make;
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }
        
        private string model;
        public string Model 
        {
            get => model;
            set => model = value;
        }
    }
}