using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using NBitcoin;
using QBitNinja.Client;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Wallet 
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWallet : Window
    {
        private SendWindow sw;
        private ImportPrivKey importkey;
        public MainWallet()
        {
            InitializeComponent();
            
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            sw = new SendWindow();
            
        }

        private void Import_priv_Click(object sender, RoutedEventArgs e)
        {
            importkey = new ImportPrivKey(this);

        }
    }

    public class Transactions : INotifyPropertyChanged
    {
        private static QBitNinjaClient client = new QBitNinjaClient(Network.TestNet);

        private string tx;
        private string block;
        private decimal amount;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public string TRANSACTIONS { get { return tx; } set { if (value != this.tx) { this.tx = value; NotifyPropertyChanged(); } } }
        public string BLOCKID { get { return this.block; } set { if (value != this.block) { this.block = value; NotifyPropertyChanged(); } } }
        public decimal AMOUNT { get { return this.amount; } set { if (value != this.amount) { this.amount = value; NotifyPropertyChanged(); } } }

        public Transactions(string _tx, string _block, decimal _amount)
        {
            this.TRANSACTIONS = _tx;
            this.BLOCKID = _block;
            this.AMOUNT = _amount;
        }

    }
    
    //List<ICoin> GetCoins(BitcoinAddress myaddress, decimal sendAmount)
    //{
    //    var txInAmount = Money.Zero;
    //    var AMOUNT = new List<ICoin>();
    //    foreach (var transactions in client.GetBalance(myaddress).Result.Operations)
    //    {
    //        var TRANSACTIONS = transactions.TransactionId;
    //        var BLOCKID = transactions.BlockId;
    //        var transactionResponse = client.GetTransaction(TRANSACTIONS).Result;
    //        var receivedCoins = transactionResponse.ReceivedCoins;
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
