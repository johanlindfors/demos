public interface IRepository<T> {
    Task<T> FindByIdAsync(string id);
    Task SaveAsync(T account);
}

public class AccountRepository : IRepository<Account> {
    List<Account> _accounts;

    public AccountRepository()
    {
        _accounts = new List<Account>();
        _accounts.Add(new Account("1",1000));
        _accounts.Add(new Account("2",1000));
    }

    public Task<Account> FindByIdAsync(string accountId) {
        return Task.FromResult(_accounts.SingleOrDefault(a => a.Id == accountId));
    }

    public Task SaveAsync(Account account) {
        var accountToUpdate = _accounts.SingleOrDefault(a => a.Id == account.Id);
        accountToUpdate.Balance = account.Balance;
        return Task.CompletedTask;
    }
}