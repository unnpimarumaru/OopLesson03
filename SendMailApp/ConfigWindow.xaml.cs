using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace SendMailApp
{
    /// <summary>
    /// ConfigWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ConfigWindow : Window
    {
        public ConfigWindow()
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, RoutedEventArgs e)
        {
            Config cf = (Config.GetInstance()).getDefaultStatus();
           // Config defaultData = cf.getDefaultStatus();
            tbSmtp.Text = cf.Smtp;
            tbPort.Text = cf.Port.ToString();
            tbUserName.Text = tbSender.Text = cf.MailAddress;
            tbPassWord.Password = cf.PassWord;
            cbSsl.IsChecked = cf.Ssl;
        }
        private  bool tbCheck()
        {
            if (tbUserName.Text == "" || tbPassWord.Password == "" || tbSmtp.Text == ""  
               || tbSender.Text == ""|| tbPort.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //適用（更新）
        private void btAppiy_Click(object sender, RoutedEventArgs e)
        {
            tbCheck();
            {
                MessageBox.Show("項目に空欄があります");
            }
            {
                (Config.GetInstance()).UpdateStatus(tbSmtp.Text, tbUserName.Text, tbPassWord.Password,
                int.Parse(tbPort.Text), cbSsl.IsChecked ?? false);//更新処理を呼び出す
            }
            
            
           

        }
           //OKボタン
        private void btOK_Click(object sender, RoutedEventArgs e)
        {
            btAppiy_Click(sender,e);
            this.Close();
        }
        //キャンセルボタン
        private void btcancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
       　//ロード時に一度だけ呼び出される
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Config cf = Config.GetInstance();
            // Config defaultData = cf.getDefaultStatus();
            tbSmtp.Text = cf.Smtp;
            tbPort.Text = cf.Port.ToString();
            tbUserName.Text = tbSender.Text = cf.MailAddress;
            tbPassWord.Password = cf.PassWord;
            cbSsl.IsChecked = cf.Ssl;


        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }
    }
}
