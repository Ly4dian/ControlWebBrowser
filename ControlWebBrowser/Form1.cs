using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ControlWebBrowser
{
    public partial class ControlWebBrowser : Form
    {
        private const string LOGINURL = "https://wear.jp/member/login.html";
        private string cordinateUrl = "";
        private List<string> userPass = new List<string>();
        private string currentUrl;
        private bool buttonClickedFlg = false;
        private bool waitFlg = false;
        [DllImport("USER32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void SetCursorPos(int X, int Y);
        private int loopCnt = 0;
        private int loopF5 = 15;
        private double modSpeed = 1.0;
        [DllImport("USER32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_WHEEL = 0x0800;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;


        public ControlWebBrowser()
        {
            InitializeComponent();
            InitializeForm();
        }
        //private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        //{
        //    currentUrl = webBrowser1.Url.ToString();
        //    txtCurrentUrl.Text = currentUrl;
        //}
        private void InitializeForm()
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            rdoStandard.Checked = true;
            webBrowser1.Navigate(LOGINURL);
            // ログインユーザリストを読み込み
            ReadCsv();
            

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Point point = btnLogin.Parent.PointToScreen(btnLogin.Location);
            buttonClickedFlg = true;
            if (rdoSlow.Checked == true)
            {
                modSpeed = 1.5;
            }
            else if (rdoFast.Checked == true)
            {
                modSpeed = 0.5;
            }
            login();
            loopCnt++;
        }
        private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void ControlWebBrowser_MouseDown(object sender, MouseEventArgs e)
        {
            //フォーム上の座標でマウスポインタの位置を取得する
            //画面座標でマウスポインタの位置を取得する
            System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
            //画面座標をクライアント座標に変換する
            System.Drawing.Point cp = this.PointToClient(sp);
            //X座標を取得する
            int x = cp.X;
            //Y座標を取得する
            int y = cp.Y;

        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            currentUrl = e.Url.ToString();
            txtCurrentUrl.Text = currentUrl;

            // ターゲットのコーディネイトページの場合
            if (e.Url.ToString() == txtCordinateUrl.Text)
            {
                ////SendKeys.Send("{F5}");
                //webBrowser1.Refresh();
                // いいね・ファボクリック
                favGood();
            }
            else if (e.Url.ToString() == LOGINURL)
            {
                if (buttonClickedFlg == true)
                {
                    login();
                }
            }
            else
            {
                // ターゲットのコーデページへ遷移
                if (!string.IsNullOrEmpty(txtCordinateUrl.Text))
                {
                    if (waitFlg == false)
                    {
                        webBrowser1.Navigate(txtCordinateUrl.Text);
                        waitFlg = true;
                        double waitTime = 5000 * modSpeed;
                        System.Threading.Thread.Sleep((int)waitTime);
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            txtLoginUser.Text = userPass[loopCnt];
            if (txtCurrentUrl.Text == LOGINURL)
            {
                currentUrl = webBrowser1.Url.ToString();
                // ユーザID
                webBrowser1.Document.GetElementById("input_wearid").Focus();
                webBrowser1.Document.GetElementById("input_wearid").InnerText = txtLoginUser.Text;
                // パスワード
                HtmlElementCollection all = webBrowser1.Document.All;
                HtmlElementCollection forms = all.GetElementsByName("Password");
                forms[0].Focus();
                forms[0].Enabled = true;
                forms[0].InnerText = txtLoginUser.Text;
                SendKeys.Send("{ENTER}");
                loopCnt++;
                waitFlg = false;
            }
        }

        private void btnFavGood_Click(object sender, EventArgs e)
        {
            favGood();
        }
        private void favGood()
        {
            Point point = btnFavGood.Parent.PointToScreen(btnLogin.Location);
            // WebBrowserにフォーカスオン
            SetCursorPos(point.X + 200, point.Y + 200);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 100, -300, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 100, -300, 0, 0);
            ////一秒間（1000ミリ秒）停止する
            //System.Threading.Thread.Sleep(modSpeed);
            // いいね・ファボまでスクロール
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, -600, 0);
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, -600, 0);
            double waitTime = 2000 * modSpeed;
            System.Threading.Thread.Sleep((int)waitTime);
            // いいねクリック
            SetCursorPos(point.X + 450, point.Y + 350);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            // お気に入りクリック
            SetCursorPos(point.X + 100, point.Y + 350);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            waitTime = 10000 * modSpeed;
            System.Threading.Thread.Sleep((int)waitTime); ;
            // ログイン画面へ戻る
            webBrowser1.Navigate(LOGINURL);
        }
        private void ReadCsv()
        {
            try
            {
                // csvファイルを開く
                string csvPath = System.AppDomain.CurrentDomain.BaseDirectory;
                string csvFileName = "UserID.csv";
                using (var sr = new System.IO.StreamReader(csvPath + csvFileName))
                {
                    // ストリームの末尾まで繰り返す
                    while (!sr.EndOfStream)
                    {
                        // ファイルから一行読み込む
                        string line = sr.ReadLine();
                        // 読み込んだ一行をカンマ毎に分けて配列に格納する
                        string[] values = line.Split(',');
                        System.Console.WriteLine();
                        userPass.AddRange(values);
                    }
                }
            }
            catch (System.Exception e)
            {
                // ファイルを開くのに失敗したとき
                System.Console.WriteLine(e.Message);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtCurrentUrl.Text);
        }
    }
}
