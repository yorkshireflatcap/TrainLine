namespace ohce.Language
{
    public interface ISpeakSpanish
    {
        bool IsMorning();
        bool IsNightTime();
        bool IsAfterNoon();
        string Message { get; }
        string IsPalindrome { get; }

        string SayGoodbye { get; }
        string Name { get; set; }
    }
}