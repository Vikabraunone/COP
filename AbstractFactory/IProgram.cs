namespace AbstractFactory
{
    /// <summary>
    /// Образовательная программа
    /// </summary>
    public interface IProgram
    {
        ICourse CreateCourse();

        IForm CreateFormEducation();
    }
}
