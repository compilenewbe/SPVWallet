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
using System.Windows.Navigation;
using System.Windows.Shapes;
using NBitcoin;
using QBitNinja.Client;

namespace Wallet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SendWindow : Window
    {
        public SendWindow()
        {
            InitializeComponent();
            this.Show();
        }

        private static QBitNinjaClient client = new QBitNinjaClient(Network.TestNet);
        private void Send_Money_Click(object sender, RoutedEventArgs e)
        {
            if (CheckValues.CheckIfNull(this))
            {
                return;
            }


            if (!decimal.TryParse(money.Text, out decimal lMoney) || !decimal.TryParse(fee.Text, out decimal fi))
            {
                MessageBox.Show("This can only be numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            BitcoinPubKeyAddress lDestination = new BitcoinPubKeyAddress(destination.Text, Network.TestNet); //"n1WkSm1uQB8ELxRDzQNKbstMJSHh5U3ixX", Network.TestNet);
            //BitcoinPubKeyAddress lMyAddress = new BitcoinPubKeyAddress(address.Text, Network.TestNet); //"msJr3Gxdm9SBQ38ECDrgMBnFqTLoNqWLfa", Network.TestNet);
            //BitcoinSecret lPrivKey = new BitcoinSecret(privkey.Text, Network.TestNet); //"cTNf7qB8cnQA5JuuV4ejKi739sGZkcHpdLX3XzRPqkGfxZsfMGxU", Network.TestNet);
            string lFee = fee.Text;

            //List<ICoin> coins = GetCoins(lPrivKey.GetAddress(), lMoney);
            //decimal total = coins.Sum(x => Convert.ToDecimal(x.Amount.ToString()));
            //if(total < Convert.ToDecimal(lMoney))
            //{
            //    MessageBox.Show("Does not have enough funds\nFunds: " + total + "\nValue to Send: " + lMoney, "Error",MessageBoxButton.OK,MessageBoxImage.Error);
            //    return;
            //}



            //TransactionBuilder txBuilder = new TransactionBuilder();
            //Transaction lTx = txBuilder
            //    .AddCoins(coins)
            //    .AddKeys(lPrivKey)
            //    .Send(lDestination, new Money(lMoney, MoneyUnit.BTC))
            //    .SendFees(lFee)
            //    .SetChange(lMyAddress)
            //    .BuildTransaction(true);

            //var txresult = lTx.ToHex();

            //if (!txBuilder.Verify(lTx))
            //    MessageBox.Show("Bad Transaction", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            //broad(lTx);

        }

        public async static void broad(Transaction tx)
        {

            var response = await client.Broadcast(tx);

            if (response.Success)
                MessageBox.Show("Transaction Success", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show("Transaction Failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);


        }

        private static List<ICoin> GetCoins(BitcoinAddress myaddress, decimal sendAmount)
        {
            //var amountMoney = new Money(sendAmount, MoneyUnit.BTC);
            var txInAmount = Money.Zero;
            var coins1 = new List<ICoin>();
            foreach (var balance in client.GetBalance(myaddress, true).Result.Operations)
            {
                var transactionId = balance.TransactionId;
                var transactionResponse = client.GetTransaction(transactionId).Result;
                var receivedCoins = transactionResponse.ReceivedCoins;
                foreach (Coin coin in receivedCoins)
                {
                    if (coin.TxOut.ScriptPubKey == myaddress.ScriptPubKey)
                    {
                        coins1.Add(coin);
                        txInAmount += (coin.Amount as Money);
                    }
                }
            }
            return coins1;
        }
    }

    public class  CheckValues
    {
        public static bool CheckIfNull(SendWindow mw)
        {
            if (String.IsNullOrEmpty(mw.destination.Text) || String.IsNullOrEmpty(mw.fee.Text) || String.IsNullOrEmpty(mw.money.Text))
            {
                MessageBox.Show("Can not be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return true;
            }
            else
            {
                return false;
            }

        }
    }


}
