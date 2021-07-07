namespace AbstractFactory
{
    public class PIFullAndPartProgram : IProgram
    {
        public ICourse CreateCourse()
        {
            return new PICourse();
        }

        public IForm CreateFormEducation()
        {
            return new FullAndPartForm();
        }
    }
}
