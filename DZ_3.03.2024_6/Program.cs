using static System.Console;

// Создайте класс «Магазин». Необходимо хранить в полях класса: название магазина, адрес, описание
// профиля магазина, контактный телефон, контактный e-mail. Реализуйте методы класса для ввода
// данных, вывода данных, реализуйте доступ к отдельным полям через методы класса.

class Store
{
    private string name;
    private string address;
    private string description;
    private string phoneNumber;
    private string email;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }

    public string GetAddress()
    {
        return address;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetPhoneNumber(string phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

    public string GetPhoneNumber()
    {
        return phoneNumber;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

    public string GetEmail()
    {
        return email;
    }

    public void InputData()
    {
        WriteLine("Введите сведения о магазине:");
        Write("Название магазина: ");
        name = ReadLine();

        Write("Адрес магазина: ");
        address = ReadLine();

        Write("Описание профиля магазина: ");
        description = ReadLine();

        Write("Контактный телефон: ");
        phoneNumber = ReadLine();

        Write("Email: ");
        email = ReadLine();
    }

    public void Show()
    {
        WriteLine($"Название магазина: {name}");
        WriteLine($"Адрес магазина:    {address}");
       WriteLine($"Описание магазина:  {description}");
       WriteLine($"Номер телефона:     {phoneNumber}");
       WriteLine($"Email:              {email}");
    }
}

class Program
{
    static void Main()
    {
        Store store = new Store();
        store.InputData();
        WriteLine("\nО Магазине:");
        store.Show();
    }
}