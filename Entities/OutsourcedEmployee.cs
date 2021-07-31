namespace ExercicioHeranca.Entities
{
    class OutsourcedEmployee : Employee    {

        public double AdditonalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditonalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + AdditonalCharge * 1.1;

        }
    }

}
