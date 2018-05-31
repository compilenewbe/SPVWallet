using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QBitNinja.Client;
using NBitcoin;


namespace Wallet
{
    class TransactionsWorks
    {

    }

    class GetTransactions
    {
        private System.Collections.ObjectModel.ObservableCollection<Transactions> transacciones;
        private string transactionID { get; set; }
        private string blockID { get; set; }
        private decimal amount { get; set; }


        private static QBitNinjaClient client = new QBitNinjaClient(Network.TestNet);

        //List<ICoin> GetCoins(BitcoinAddress myaddress, decimal sendAmount)
        //{
        //    Transactions hola = new Transactions("","",0);
            
        //    var txInAmount = Money.Zero;
        //    var AMOUNT = new List<ICoin>();
        //    foreach (var transactions in client.GetBalance(myaddress).Result.Operations)
        //    {
        //        uint256 TRANSACTIONS = transactions.TransactionId;
        //        uint256 BLOCKID = transactions.BlockId;
        //        hola.TRANSACTIONS = transactions.TransactionId.ToString();
        //        var transactionResponse = client.GetTransaction(TRANSACTIONS).Result;
        //        var receivedCoins = transactionResponse.ReceivedCoins;
        //        transacciones.Add(hola.TRANSACTIONS)
        //        foreach (Coin coin in receivedCoins)
        //        {
        //            if (coin.TxOut.ScriptPubKey == myaddress.ScriptPubKey)
        //            {
        //                AMOUNT.Add(coin);
        //                txInAmount += (coin.Amount as Money);
        //            }
        //        }
        //    }
        //    return AMOUNT;
        //}
    }
}
