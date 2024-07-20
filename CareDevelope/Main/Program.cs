
using CryptoCactus.Domail.Markets.OkxExchange;
using CryptoCactus.Domain.CryptoAbstractFactory;
using CryptoCactus.Domain.Markets.Abstract;
using CryptoCactus.Domain.Markets.BingX;
using CryptoCactus.Domain.Markets.BitGetExchanges;
using CryptoCactus.Domain.Markets.KucoinExchanges;
using System.Diagnostics;


/*KucoinExchange cryptoAbstractFactory = new KucoinExchange();
while (true)
{
await cryptoAbstractFactory.GetOnlyOneCurrencByAPIAsync("BTC");
Console.WriteLine(cryptoAbstractFactory.Currencies["BTC"]);

}*/

HttpConnector httpConnector = new HttpConnector();

string url = "https://api.coingecko.com/api/v3/coins/bitcoin/market_chart/range?vs_currency=usd&from=1640995200&to=1672531200";
string response = await httpConnector.HttpConnect(url);
Console.WriteLine(response);
