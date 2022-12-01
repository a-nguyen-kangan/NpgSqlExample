namespace NpgSqlExample.models
{
    public class Car
    {
        public string Rego { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public Car() {}
        
        public Car(string rego, string make, string model)
        {
            Rego = rego;
            Make = make;
            Model = model;
        }
    }
}