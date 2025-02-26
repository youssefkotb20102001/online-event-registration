namespace Nsoo7yWebApp.Client.Classes
{
    public class QuizContent
    {
        public string Question { get; set; }
        public int id { get; set; }
        public  List<string> choices{ get; set; }
        public string correctChoice { get; set; }
        public string? chosen { get; set; }
    }
}
