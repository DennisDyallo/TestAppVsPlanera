using TestAppVsPlanera.TablaApi;
using UtbudApi;

Console.WriteLine("Hello, Olaf!");
var tablaClient = new TablaApiClient(new HttpClient { BaseAddress = new Uri("https://planera.yoda.sr.se/tabla-api") });
var utbudClient = new UtbudApiClient(new HttpClient { BaseAddress = new Uri("https://planera.yoda.sr.se/utbud-api") });