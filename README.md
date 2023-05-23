# Min Portfolio
![alt text](https://github.com/fredthom91/Portfolio/blob/master/portf%C3%B6lj.jpg)

## Detta är min web-baserade portfolio:
1. Det finns en beskrivning om mig själv.
2. Det finns en redovisning av mina kunskaper.
3. Det finns en sektion som hämtar information från ett rest-API där mina skolprojekt finns.
4. Det finns en sektion som visar mina referenser.
5. Det finns ett kontakt formulär.
6. Länk till Portfolion: [KLICKA HÄR](https://fredrikthomassonportfolio.azurewebsites.net/).

  Denna portfolio är skapad i .NET AspCore Razor Pages.
  API:n är ett .NET Rest-API som är skapat i samma solution.



## Metoder och Principer.

1. Metoder

 _*Metoder*_        | _*Kort beskrivning*_           |
| ------------- |:-------------:|
| GenerateWeatherData()| Genererar väder data från ett API. |
| ShowProjects()| Hämtar data från ett API med project. |
| GetProject(int id)| Tar data från från API med ett specifikt ID. |
| GetWeatherApiKey()| Hämtar API-nyckeln. |
| GetWeatherData()| Hämtar väder data från ett API. |
| ExtractWeatherInfo()| Extraherar väder info från ett API. |
| OnGet()| Körs när sidan laddas. |
| WeatherOnGet()| Körs via OnGet() när sidan laddas. |


2. Design Patterns
  
  _*Typ*_        | _*Beskrivning*_           |
| ------------- |:-------------:|
| Dependency Injection| Dependency Injection hjälper till att förbättra modularitet, testbarhet och underhållbarhet hos mjukvarusystem genom att främja lösa kopplingar och möjliggöra flexibel hantering av beroenden. Det används brett inom många ramverk och bibliotek, inklusive beroendeinjektionsbehållare, för att förenkla hanteringen av objektberoenden i komplexa applikationer. |
| Repository Pattern| Repository Pattern är en design pattern som används för att abstrahera och separera datalagringen från resten av applikationslogiken. Det erbjuder en enhetlig och standardiserad gränssnitt för att interagera med datakällor, oavsett om det är en databas, filsystem eller externa tjänster. |

3. Principer

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
