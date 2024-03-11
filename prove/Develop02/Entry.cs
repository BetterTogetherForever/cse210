class Entry
{
    private string _prompt;
    private string _response;
    private DateTime _date;

    // Constructor to initialize an entry with a prompt, response, and current date
    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now;
    }

    // Override ToString to provide a string representation of the entry
    public override string ToString()
    {
        return $"Date: {_date}, Prompt: {_prompt}, Response: {_response}";
    }
}