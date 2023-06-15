namespace AdoptionManager.Domain.Entities.Surveys
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public int UserResponseId { get; set; }
        public UserResponse UserResponse { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public string Text { get; set; }
    }
}
