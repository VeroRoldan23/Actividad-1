namespace MyApi.Models;

public class User {
    public int Id { get; private set; }
    private string _name = string.Empty;
    private string _email = string.Empty;

    public string Name {
        get => _name;
        set {
            if (!string.IsNullOrWhiteSpace(value))
                _name = value;
        }
    }

    public string Email {
        get => _email;
        set {
            if (!string.IsNullOrWhiteSpace(value) && value.Contains("@"))
                _email = value;
        }
    }
}
