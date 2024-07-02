public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> wordsToHide = _words.Where(word => !word.IsHidden()).OrderBy(x => random.Next()).Take(numberToHide).ToList();

        foreach (Word word in wordsToHide)
        {
            word.Hide();
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    // New method to reveal a random hidden word as a hint
    public void RevealRandomHiddenWord()
    {
        Random random = new Random();
        List<Word> hiddenWords = _words.Where(word => word.IsHidden()).ToList();

        if (hiddenWords.Count > 0)
        {
            Word wordToReveal = hiddenWords[random.Next(hiddenWords.Count)];
            wordToReveal.Show();
        }
    }
}