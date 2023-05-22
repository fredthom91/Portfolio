# Min Portfolio ![alt text](http://url/to/img.png)

## Detta är min web-baserad portfolio:
1. Det finns en beskrivning om mig själv.
2. Det finns en redovisning av mina kunskaper.
3. Det finns en sektion som hämtar information från ett rest-API där mina skolprojekt finns.
4. Det finns en sektion som visar mina referenser.
5. Det finns ett kontakt formulär.
6. Länk till Portfolion: [Gå till Portfolion](https://fredrikthomassonportfolio.azurewebsites.net/).

  Denna portfolio är skapad i .NET AspCore Razor Pages.
  API:n är ett .NET Rest-API som är skapat i samma solution.



## Metoder och Principer.

1. Metoder:

 _*Metoder*_        | _*Kort beskrivning*_           |
| ------------- |:-------------:|
| GenerateAllAccounts()| Genererar alla konton från databasen. |
| GetAllAccountsFromSpecificCustomer(int custId)| Genererar alla konton från en specifik kund. |
| GetTotalBalanceFromSpecificCustomer(int accId)| Hämtar det totala kapitalet från en specifik kunds konton. |
| GetWhenAccountWasCreated(int accId)| Hämtar info om när ett specifikt konto vart skapat. |
| GetAccountFrequency(int accId)| Hämta ett specifikt kontos frekvens/användning. |
| GenerateTotalBalance()| Genererar det totala kapitalet. |
| GenerateLoanID(int accId)| Genererar ett låne-id för ett specifikt konto. |
| GetWhenLoanCreated(int loanId)| När lånet skapades. |
| GetLoanAmount(int loanId)| Lånesumman. |
| GetLoanDuration(int loanId)| Avbetalningsplan. |
| GetLoanPayments(int loanId)| Samtliga Betalningar gjorda. |
| GetLoanStatus(int loanId)| Lånets status. |
| ShowMoreTransactions(int accId, int pageNo)| Visar mer transaktioner(+20st varje klick) |
| NewDeposit(Account account, decimal newAmount)| Här körs en ny insättning. |
| NewWithdraw(Account account, decimal newAmount)| Här körs ett nytt uttag. |
| GetAccount(int accountId)| Hämta ett specifikt konto. |
| GenerateCustomerProfile(int id, int acc, decimal bal, DateTime loanCreated, decimal loanAmount, int loanDuration, decimal loanPayments, string loanStatus, int loanID)||
| GetCustomerDispositionsId(int custId)| Hämtar ett specifikt dispositions id från en specific kund. |
| GetCustomerCardInfo(int dispoId)| Hämtar kortinformation från en specifik kund. |
| GenerateCountryDetails(string input)| Genererar Landsinformation med dess kunder. |
| ShowTopTenCustomersByCountry(string countryCode)| Visa 10 kunder med högst saldo per land. |
| GetAllCustomers()| Hämtar alla kunder från databasen. |
| ConvertedCustomerList(List<Customer> customer)| Konverterar en lista. |
| CustomerList(string q, int pageNo)| En lista på kunder. |
| SortListByChoice()| Sorterar information baserat på val. |
| GenerateAllCustomers()| Genererar alla kunder. |
| GetCustomerName(int id)| Hämta kundens namn baserat på id. |
| ErrorCodes(Customer checkCustomer)| kollar så att informationen som lämnats är korrekt. |
| UpdateErrorCodes()| == |
| DeleteErrorCodes()| == |
| GetCurrentCustomer()| Tar information vidare från kundprofilen. |
| GenerateUserInfoAndRoles()| Genererar en lista med användar information. |
| CheckTransactions()| Går igenom alla transaktioner för respektive land. |
| CheckCountry()| Går igenom per land och varje transaktion samt sparar ner misstänksamma transaktioner till en textfil. |



2. Principer

 _*Typ*_        | _*Beskrivning*_            
| ------------- |:-------------:|
| Single Responsibility Principle| Ett objekt bör bara ha en anledning till att ändras | 
| Open Closed Principle| öppen för förlängning, stängd för modifiering. | 
| Interface Segregation Principle| Användare ska inte tvingas vara beroende av metoder de inte använder. | 
| Dependency Inversion Principle| En klass bör inte vara beroende av en annan klass, båda bör vara beroende av abstraktion | 
| Do Not Repeat Yourself Principle| Repetera dig inte, använd en metod som implementeras. (Single source of truth!) | 
| Abstraction (OOP Principle)| Relevanta namn på: Attribut, Properties , Klasser och Entiteter som är relaterade.  | 
| Encapsulation (OOP Principle)| Dölja ett objekts interna tillstånd och funktionalitet och endast tillåta åtkomst via en offentlig uppsättning funktioner. |
| Inheritance (OOP Principle)| Möjlighet att skapa nya abstraktioner baserade på befintliga abstraktioner. (T.ex Interface) |


## Credits

1. Richard Chalk - Mentor - Länk till github [Richards Github](https://github.com/RichardChalk)
2. Bootstrap - Inspiration/CSS - Tagit inspiration av Bootstraps css.
3. W3Schools - Inspiration - Tagit hjälp av W3Schools av diverse funktioner.


## Licens

Ingen tillämpad.
