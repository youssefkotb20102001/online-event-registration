namespace Nsoo7yWebApp.Client.Classes
{
    public class QuestionsDataSet:IQuestionsDataSet
    {
        private List<QuizContent> AllQuestions;
        public QuestionsDataSet()
        {
            AllQuestions = new List<QuizContent>()
            {
                new QuizContent()
                {
                    id = 0,
                    Question="Who won world Cup 2022?",
                    choices=new List<string>
                    {
                        
                        "Brazil",
                        "Argentina",
                        "France",
                        "Belgium"
                    },
                    correctChoice="Argentina",

                },

                new QuizContent()
                {
                    id = 1,
                    Question="Who won world Cup 2018?",
                    choices=new List<string>
                    {
                        "Brazil",
                        "Argentina",
                        "France",
                        "Belgium"
                    },
                    correctChoice="France",

                }
            };

        }

        public async Task<List<QuizContent>> GetQuestions()
        {
            return await Task.FromResult(AllQuestions);
        }
    }
}
