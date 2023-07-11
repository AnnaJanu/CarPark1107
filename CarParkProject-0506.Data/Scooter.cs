namespace CarParkProject_0506.Data
{
    [Serializable]
    public class Scooter : Vehicle
    {
        public Scooter()
        {
            
        }

        public Scooter(ushort id, Engine engine, Transmission transmission, Chassis chassis)
            : base(id, engine, transmission, chassis)
        {
            
        }

        public override string GetDetails()
        {
            return base.GetDetails();
        }

        
    }
}
