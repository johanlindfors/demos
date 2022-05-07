using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace BankingApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BankingController : ControllerBase
{
    private readonly ILogger<BankingController> _logger;
    private readonly IRepository<Account> _accountRepository;

    public BankingController(ILogger<BankingController> logger, IRepository<Account> accountRepository)
    {
        _logger = logger;
        _accountRepository = accountRepository;
    }

    //[Authorize]
    [HttpGet("transfer/{amount:int}/{from}/{to}")]
    public async Task<int> Transfer(int amount, string from, string to)
    {
            var fromAccount = await _accountRepository.FindByIdAsync(from);
            var toAccount = await _accountRepository.FindByIdAsync(to);

            if(fromAccount.Balance < amount) {
                throw new ArgumentException("Insufficient funds");
            }

            toAccount.Balance += amount;
            await _accountRepository.SaveAsync(toAccount);

            fromAccount.Balance -= amount;
            await _accountRepository.SaveAsync(fromAccount);

            return fromAccount.Balance;
    }
}
