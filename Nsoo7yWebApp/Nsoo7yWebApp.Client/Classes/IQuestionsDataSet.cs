namespace Nsoo7yWebApp.Client.Classes
{
    public interface IQuestionsDataSet
    {
        public  Task<List<QuizContent>> GetQuestions();
    }
}