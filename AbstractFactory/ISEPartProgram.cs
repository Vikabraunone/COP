namespace AbstractFactory
{
    public class ISEPartProgram : IProgram
    {
        public ICourse CreateCourse()
        {
            return new ISECourse();
        }

        public IForm CreateFormEducation()
        {
            return new PartForm();
        }
    }
}
