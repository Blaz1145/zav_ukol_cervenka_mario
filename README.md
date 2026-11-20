# Záverečný úkol – UTB Airlines

**Autor:** Mario Červenka
**GitHub repozitár (celá história commitov):** https://github.com/Blaz1145/zav_ukol_cervenka_mario

## Technológie
ASP.NET Core MVC (.NET 10), Entity Framework Core 10, MySQL

## Štruktúra (DDD vrstvy)
- **UTBAirlines.Domain** – entita `Letenka`, rozhrania `IRepository`, `ILetenkaRepository`
- **UTBAirlines.Infrastructure** – `LetenkaDbContext`, seeding, migrácie, `Repository`, `LetenkaRepository`
- **UTBAirlines.Application** – `ILetenkaAppService`, `LetenkaAppService`
- **UTBAirlines.Web** – `HomeController` (akcia `UTBAirlines`), views, vlastný CSS (`wwwroot/css/home.css`)

## Spustenie
1. Skontrolovať connection string v `UTBAirlines.Web/appsettings.json`.
2. Vytvoriť databázu:
   ```
   dotnet ef database update --project UTBAirlines.Infrastructure --startup-project UTBAirlines.Web
   ```
3. Spustiť projekt `UTBAirlines.Web`.
