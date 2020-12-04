namespace AbstractFactory
{
    public class PIPartProgram : IProgram
    {
        public ICourse CreateCourse()
        {
            return new PICourse();
        }

        public IForm CreateFormEducation()
        {
            return new PartForm();
        }
    }
}
