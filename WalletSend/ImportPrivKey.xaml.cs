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
using System.IO;
using NBitcoin;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Wallet
{
       /// <summary>
    /// Interaction logic for ImportPrivKey.xaml
    /// </summary>
    public partial class ImportPrivKey : Window
    {
        private string CurrentPath;
        private MainWallet lMw;
        public ImportPrivKey(MainWallet mw)
        {
            lMw = mw;
            InitializeComponent();
            this.Show();
        }
        private void Send_Money_Click(object sender, RoutedEventArgs e)
        {
            
            BitcoinSecret lPrivKey = new BitcoinSecret(privKey.Text, Network.TestNet);
            string lAddress = lPrivKey.GetAddress().ToString();
            address.Text = lAddress;
            lMw.address.Text = lAddress;
            Save(privKey.Text, lAddress);
            
        }

        private void Save(string lPrivate, string lAddresses)
        {
            string lines = lPrivate + "\r" + lAddresses ;
            CurrentPath = Directory.GetCurrentDirectory();
            // Write the string to a file.
            
            //System.IO.StreamWriter file = new System.IO.StreamWriter(CurrentPath);
            //file.WriteLine(lines);

            //file.Close();


        }
    }
}
