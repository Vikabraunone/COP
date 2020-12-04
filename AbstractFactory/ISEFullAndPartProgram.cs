namespace AbstractFactory
{
    public class ISEFullAndPartProgram : IProgram
    {
        public ICourse CreateCourse()
        {
            return new ISECourse();
        }

        public IForm CreateFormEducation()
        {
            return new FullAndPartForm();
        }
    }
}
