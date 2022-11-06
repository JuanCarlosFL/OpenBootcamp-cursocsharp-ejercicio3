var client = new Client()
{
    FullName = "Juan Carlos Fuentes",
    Phone = "666223311",
    Address = "Mijas",
    Email = "jcarlos@fuentesdev.es",
    isNewClient = true,
};

Console.WriteLine(client);

public struct Client
{
    public string FullName;
    public string Phone;
    public string Address;
    public string Email;
    public bool isNewClient;

    public override string ToString()
    {
        return $"{FullName} with phone: {Phone} and email: {Email}, live in {Address}.  New Client: {isNewClient}";
    }
}
