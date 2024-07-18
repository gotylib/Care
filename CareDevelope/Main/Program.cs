
using CryptoCactus.Domail.Markets.OkxExchange;
using CryptoCactus.Domain.CryptoAbstractFactory;
using CryptoCactus.Domain.Markets.BingX;
using CryptoCactus.Domain.Markets.BitGetExchanges;
using CryptoCactus.Domain.Markets.KucoinExchanges;


KucoinExchange cryptoAbstractFactory = new KucoinExchange();
while (true)
{
    await cryptoAbstractFactory.GetOnlyOneCurrencByAPIAsync("BTC");
    
}




