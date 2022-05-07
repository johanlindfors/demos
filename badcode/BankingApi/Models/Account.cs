public struct Account {
    public string Id { get; }
    public int Balance { get;set; }

    public Account(string id, int? balance)
    {
        Id = id;
        Balance = balance ?? 0;
    }
}