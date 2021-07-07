namespace AbstractFactory
{
    public class PIFullProgram : IProgram
    {
        public ICourse CreateCourse()
        {
            return new PICourse();
        }

        public IForm CreateFormEducation()
        {
            return new FullForm();
        }
    }
}
