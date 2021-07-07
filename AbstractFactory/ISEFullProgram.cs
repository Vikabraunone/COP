namespace AbstractFactory
{
    public class ISEFullProgram : IProgram
    {
        public ICourse CreateCourse()
        {
            return new ISECourse();
        }

        public IForm CreateFormEducation()
        {
            return new FullForm();
        }
    }
}
