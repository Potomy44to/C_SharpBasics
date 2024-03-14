class User
{
    private int age;
    private string login, email;

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value < 18)
            {
                Console.WriteLine("Возраст должен быть не меньше 18");
            }
            else
            {
                age = value;
            }
        }
    }

    public string Login
    {
        get
        {
            return login;
        }

        set
        {
            if (value.Length < 3)
            {
                Console.WriteLine("Логин должен быть не меньше 3 символов");
            }
            else
            {
                login = value;
            }
        }
    }

    public string Email
    {
        get
        {
            return email;
        }

        set
        {
            if (!value.Contains('@'))
            {
                Console.WriteLine("Email некорректного формата");
            }
            else
            {
                email = value;
            }
        }
    }
}