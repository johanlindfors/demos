using System.Collections.Generic;

public interface IRepository<T> {
    Task<T> FindByIdAsync(string id);
    Task SaveAsync(T account);
}

public class AccountRepository : IRepository<Account> {
    Dictionary<string, Account> _accounts = new Dictionary<string, Account>();

    public AccountRepository()
    {
        _accounts.Add("1", new Account("1",1000));
        _accounts.Add("2", new Account("2",1000));
    }

    public Task<Account> FindByIdAsync(string accountId) {
        return Task.FromResult(_accounts[accountId]);
    }

    public Task SaveAsync(Account account) {
        _accounts[account.Id] = account;
        return Task.CompletedTask;
    }
}