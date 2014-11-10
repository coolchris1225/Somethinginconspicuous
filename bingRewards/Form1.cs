using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Collections;
using System.Globalization;
using System.Web;
using System.Diagnostics;

namespace bingRewards
{
    public partial class Form1 : Form
    {
        private static System.Windows.Forms.Timer timeChecker = new System.Windows.Forms.Timer();
        private string randomTimeStringVariable;

        private bool shutThisShitDown = false;
        private string username;
        private string password;
        private int countDown = 0;
        private int accountNum = 0;
        private List<int> numAccountsList = new List<int>();
        private bool mobile = false; //start with desktop
        string wordsFile = Application.StartupPath + Path.DirectorySeparatorChar + "words.txt";
        string accountsFile = Application.StartupPath + Path.DirectorySeparatorChar + "accounts.txt";


        //[DllImport("wininet.dll", SetLastError = true)]
        //private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int lpdwBufferLength);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.startMinimized == true)
            {
                this.WindowState = FormWindowState.Minimized;
                startMinimized.Checked = true;
            }
            timeChecker.Interval = 500;
            timeStartEnable.Checked = Properties.Settings.Default.timeStartEnable;
            timeChecker.Enabled = timeStartEnable.Checked;
            timeChecker.Tick += new EventHandler(timeChecker_Tick);
            randomTimeStringVariable = randomTimeString(Properties.Settings.Default.timeStartHours, Properties.Settings.Default.timeStartMinutes, Properties.Settings.Default.timeVariance);

            searchTimer.Enabled = false;
            startTimer.Enabled = false;
            webBrowser1.ScriptErrorsSuppressed = true;
            fileCheck();
            if (Properties.Settings.Default.startSpeed > 60000)
                stuckTimer.Interval = Properties.Settings.Default.startSpeed;
            if (Properties.Settings.Default.startSpeed > 100)
                startTimer.Interval = Properties.Settings.Default.startSpeed;
            else
                startTimer.Interval = 100;

            if (Properties.Settings.Default.searchSpeedMin > 100 && Properties.Settings.Default.searchSpeedMin > 100)
            {
                searchTimer.Interval = randomNumber(Properties.Settings.Default.searchSpeedMin, Properties.Settings.Default.searchSpeedMax);
                searchSpeedMin.Text = Convert.ToString(Properties.Settings.Default.searchSpeedMin);
                searchSpeedMax.Text = Convert.ToString(Properties.Settings.Default.searchSpeedMax);
            }
            else
                searchTimer.Interval = 100;

            autoClose.Checked = Properties.Settings.Default.autoClose;
            autoStart.Checked = Properties.Settings.Default.autoStart;
            mobileSearchesMin.Text = Convert.ToString(Properties.Settings.Default.mobileSearchesMin);
            mobileSearchesMax.Text = Convert.ToString(Properties.Settings.Default.mobileSearchesMax);
            desktopSearchesMin.Text = Convert.ToString(Properties.Settings.Default.desktopSearchesMin);
            desktopSearchesMax.Text = Convert.ToString(Properties.Settings.Default.desktopSearchesMax);
            startSpeed.Text = Convert.ToString(Properties.Settings.Default.startSpeed);
            searchType.Text = Properties.Settings.Default.searchType;
            timeStartHours.Value = Properties.Settings.Default.timeStartHours;
            timeStartMinutes.Value = Properties.Settings.Default.timeStartMinutes;
            timeVariance.Text = Convert.ToString(Properties.Settings.Default.timeVariance);
            if (autoStart.Checked == true)
                startBtn.PerformClick();
            randomizeAccountOrder.Checked = Properties.Settings.Default.randomizeAccountOrder;

            

            if (Properties.Settings.Default.hideBrowser == true)
            {
                webBrowser1.Visible = false;
                hideBrowser.Checked = true;
            }
            else
            {
                webBrowser1.Visible = true;
                hideBrowser.Checked = false;

            }


            //MessageBox.Show("DEBUG: searchspeed=" + searchTimer.Interval.ToString() + " startspeed=" + startTimer.Interval.ToString());
        }

        public bool fileExists(string fileName)
        {
            if (!File.Exists(fileName))
                return false;
            else
                return true;
        }

        public void fileCheck()
        {
            if (!fileExists(accountsFile))
                MessageBox.Show("File " + accountsFile + " is missing!");
            if (!fileExists(wordsFile))
                MessageBox.Show("File " + wordsFile + " is missing!");
        }



        private int randomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public string GetRandomSentence(int wordCount)
        {
            Random rnd = new Random();
            string[] words = System.IO.File.ReadAllLines(wordsFile);

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < wordCount; i++)
            {
                // Select a random word from the array
                builder.Append(words[rnd.Next(words.Length)]).Append(" ");
            }

            string sentence = builder.ToString().Trim();

            // Set the first letter of the first word in the sentenece to uppercase
            if (wordCount >= 4)
                sentence = char.ToUpper(sentence[0]) + sentence.Substring(1) ;

            builder = new StringBuilder();
            builder.Append(sentence);

            return builder.ToString();
        }

        private void ReadAccounts(int line)
        {
            try
            {
                string content = "";
                using (StreamReader r = new StreamReader(accountsFile))
                {
                    int i = 0;
                    string rLine;
                    string[] uName;
                    listBox1.Items.Clear();
                    while ((rLine = r.ReadLine()) != null)
                    {
                        uName = rLine.Split('/');
                        listBox1.Items.Add(uName[0]);
                        if (i == line)
                            content = rLine;
                        i++;
                    }
                }
                //string content = File.ReadLines(accountsFile).ElementAt(line); //old way
                string[] words = content.Split('/');
                startBtn.Enabled = false;
                username = words[0];
                password = words[1];

                //InternetSetOption(IntPtr.Zero, 3, IntPtr.Zero, 0);
                webBrowser1.Navigate(new Uri("https://login.live.com/logout.srf"));
            }
            catch
            {
                startTimer.Enabled = false;
                startBtn.Enabled = true;
                randomTimeStringVariable = randomTimeString(Properties.Settings.Default.timeStartHours, Properties.Settings.Default.timeStartMinutes, Properties.Settings.Default.timeVariance);
                timeChecker.Enabled = true;
                webBrowser1.Navigate(new Uri("https://login.live.com/logout.srf")); //done, log out
                if (autoClose.Checked == true)
                    closeTimer.Enabled = true;
            }
        }

        private void search(Boolean skip = false)
        {
            string query = GetRandomSentence(randomNumber(3,6));
            string searchURL = "http://bing.com/search?q=";

            if (webBrowser1.Url.ToString().Contains(@"newagesoldier.com"))
                return;

            if (webBrowser1.Url.ToString().Contains(@"bing.com/rewards/dashboard"))
            {
                if (!skip)
                {
                    startTimer.Enabled = true;
                    return;
                }
            }

            if (!mobile)
            {
                if (countDown == 1) //Change to mobile when done with desktop searching.
                {
                    mobile = true;

                    countDown = randomNumber(Properties.Settings.Default.mobileSearchesMin, Properties.Settings.Default.mobileSearchesMax);
                }
            }

            if (Properties.Settings.Default.searchType.Contains("image"))
                searchURL = "http://www.bing.com/images/search?q=";
            else if (Properties.Settings.Default.searchType.Contains("video"))
                searchURL = "http://www.bing.com/videos/search?q=";
            else if (Properties.Settings.Default.searchType.Contains("map"))
                searchURL = "http://www.bing.com/maps/default.aspx?q=";
            else if (Properties.Settings.Default.searchType.Contains("news"))
                searchURL = "http://www.bing.com/news/search?q=";
            else if (Properties.Settings.Default.searchType.Contains("explore") || Properties.Settings.Default.searchType.Contains("more"))
                searchURL = "http://www.bing.com/explore?q=";

            if (mobile)
            {
                webBrowser1.Navigate(searchURL + query, null, null, "User-Agent: Mozilla/5.0 (Linux; U; Android 2.2; en-gb; LG-P500 Build/FRF91) AppleWebKit/533.0 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1");

                

                if (countDown == 1) //We're on our last search. Reset to desktop.
                    mobile = false;
            } 
            else {
                webBrowser1.Navigate(searchURL + query, null, null, "User-Agent: Mozilla/5.0 (compatible; MSIE 6.0; Windows NT 5.1)");
                
            }

            if (webBrowser1.Url.ToString().Contains(@"?q="))
                countDown = countDown - 1;
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            stuckTimer.Enabled = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            stuckTimer.Enabled = false;
            if (webBrowser1.Url.ToString() == "about:blank" || webBrowser1.Url.ToString() == "" || webBrowser1.Url == null || webBrowser1.Url.ToString().Contains(@"newagesoldier.com"))
                return;

            if (webBrowser1.Url.ToString().Contains(@"msn.com"))
                webBrowser1.Navigate(new Uri("https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=12&ct=1406628123&rver=6.0.5286.0&wp=MBI&wreply=https:%2F%2Fwww.bing.com%2Fsecure%2FPassport.aspx%3Frequrl%3Dhttp%253a%252f%252fwww.bing.com%252frewards%252fdashboard"));

            if (mobile)
                searchModeBox.Text = "mobile";
            else
                searchModeBox.Text = "desktop";

            searchesLeftBox.Text = countDown.ToString();
            accountBox.Text = username;

            notesBox.Text = webBrowser1.Url.ToString();
            if (webBrowser1.Url.ToString().Contains(@"login.live.com/login"))
            {
                foreach (HtmlElement HtmlElement1 in webBrowser1.Document.Body.All) //Force post (login).
                {
                    if (HtmlElement1.GetAttribute("name") == "login")
                        HtmlElement1.SetAttribute("value", username);
                    if (HtmlElement1.GetAttribute("name") == "passwd")
                        HtmlElement1.SetAttribute("value", password);
                    if (HtmlElement1.GetAttribute("value") == "Sign in")
                        HtmlElement1.InvokeMember("click");
                }
                return;
            }

            if (webBrowser1.Url.ToString().Contains(@"bing.com/rewards/dashboard"))
                startTimer.Enabled = true;

            if (webBrowser1.Url.ToString().Contains(@"bing.com/Passport") || webBrowser1.Url.ToString().Contains(@"login.live.com/gls") || webBrowser1.Url.ToString().Contains(@"login.live.com/logout") || webBrowser1.Url.ToString().Contains(@"bing.com/secure") || webBrowser1.Url.ToString().Contains(@"bing.com/rewards/dashboard") || webBrowser1.Url.ToString().Contains(@"msn.com"))
                return; //let timer finish the login process before reading another account OR going to the next search.

            if (!webBrowser1.Url.ToString().Contains(@"?q="))
                return;

            if (countDown >= 1)
                searchTimer.Enabled = true;
            else
                if(shutThisShitDown == false)
                    ReadAccounts(accountNum);
        }

        private void startTimer_Tick(object sender, EventArgs e)
        { //this is just so we can debug and watch to make sure we are really logged in.
            if (!webBrowser1.Url.ToString().Contains(@"bing.com/rewards/dashboard"))
                return;
            countDown = randomNumber(Properties.Settings.Default.desktopSearchesMin, Properties.Settings.Default.desktopSearchesMax);
            search(true);
            if (numAccountsList.Count != 0)
            {
                int r = randomNumber(0, numAccountsList.Count - 1);
                accountNum = numAccountsList[r];
                numAccountsList.Remove(accountNum);
            }
            else if (randomizeAccountOrder.Checked == true)
            {
                if (autoClose.Checked == true)
                {
                    Application.Exit();
                }
                else
                    accountNum = 9001;
                    
            }
            accountNum = accountNum + 1; //next account
        }

        private void searchTimer_Tick(object sender, EventArgs e)
        {
            if (!webBrowser1.Url.ToString().Contains(@"?q="))
                return;
            search();
            if (pursueSearchOrder.Checked == true)
            {
                if (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                {
                    
                    clickshit();
                }
                    
  
            }
            searchTimer.Enabled = false;
            searchTimer.Interval = randomNumber(Properties.Settings.Default.searchSpeedMax, Properties.Settings.Default.searchSpeedMax);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (randomizeAccountOrder.Checked == true)
            { 
                createListOfAccountNumbers();
                int r = randomNumber(0, numAccountsList.Count - 1);
                accountNum = numAccountsList[r];
                numAccountsList.Remove(accountNum); 
            }
            ReadAccounts(accountNum);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.bing.com");
        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stuckTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Enabled = true;
        }
        private void timeChecker_Tick(object sender, EventArgs e)
        {
            testLBL.Text = randomTimeStringVariable;
            if (DateTime.Now.ToString("HHmm") == randomTimeStringVariable)
            {
                startBtn.PerformClick();
                timeChecker.Enabled = false;
                
            }
        }
        private void createListOfAccountNumbers()
        {
            using (StreamReader r = new StreamReader(accountsFile))
            {
                int i = 0;
                string rLine;
                while ((rLine = r.ReadLine()) != null)
                {
                    numAccountsList.Add(i);
                    i++;
                }
            }           
        }
        private void clickshit() {
            MessageBox.Show("it Twerked!");
            var bodyOfLinks = webBrowser1.Document.GetElementById("b_results").GetElementsByTagName("a");
            bodyOfLinks[randomNumber(1,4)].InvokeMember("click");
            
        }
        private void PauseBtn_Click(object sender, EventArgs e)
        {
            if (shutThisShitDown == false)
            {
                PauseBtn.Text = "Continue";
                PauseBtn.ForeColor = System.Drawing.Color.Green;
                shutThisShitDown = true;
            }
            else
            {
                PauseBtn.Text = "Pause";
                PauseBtn.ForeColor = System.Drawing.Color.Red;
                shutThisShitDown = false;
                ReadAccounts(accountNum);
            }
        }
        public string randomTimeString(int hours, int minuets, int varience)
        {
            int sign = randomNumber(0, 2);
            int realVarience = randomNumber(0, varience +1);
            if (sign == 0)
                minuets += (realVarience * -1);
            else
                minuets += realVarience;
            while (minuets > 60)
            {
                hours ++;
                minuets -= 60;
            }
            while (minuets < 0)
            {
                hours--;
                minuets += 60;
            }
            while (hours > 24)
            {
                hours--;
            }
            while (hours < 0)
            {
                hours+=24;
            }
            return (Convert.ToString(hours) + Convert.ToString(minuets));
        }
        private void saveSettings_Click(object sender, EventArgs e)
        {
            randomTimeStringVariable = randomTimeString(Properties.Settings.Default.timeStartHours, Properties.Settings.Default.timeStartMinutes, Properties.Settings.Default.timeVariance);
            Properties.Settings.Default.autoStart = autoStart.Checked;
            Properties.Settings.Default.autoClose = autoClose.Checked;
            Properties.Settings.Default.hideBrowser = hideBrowser.Checked;
            Properties.Settings.Default.randomizeAccountOrder = randomizeAccountOrder.Checked;
            Properties.Settings.Default.startMinimized = startMinimized.Checked;
            Properties.Settings.Default.timeStartEnable = timeStartEnable.Checked;
            Properties.Settings.Default.startSpeed = Convert.ToInt32(startSpeed.Text);
            Properties.Settings.Default.searchSpeedMin = Convert.ToInt32(searchSpeedMin.Text);
            Properties.Settings.Default.searchSpeedMax = Convert.ToInt32(searchSpeedMax.Text);
            Properties.Settings.Default.mobileSearchesMin = Convert.ToInt32(mobileSearchesMin.Text);
            Properties.Settings.Default.mobileSearchesMax = Convert.ToInt32(mobileSearchesMax.Text);
            Properties.Settings.Default.desktopSearchesMin = Convert.ToInt32(desktopSearchesMin.Text);
            Properties.Settings.Default.desktopSearchesMax = Convert.ToInt32(desktopSearchesMax.Text);
            Properties.Settings.Default.timeStartHours = Convert.ToInt32(timeStartHours.Value);
            Properties.Settings.Default.timeStartMinutes = Convert.ToInt32(timeStartMinutes.Value);
            Properties.Settings.Default.timeVariance = Convert.ToInt32(timeVariance.Text);
            Properties.Settings.Default.searchType = searchType.Text;
            Properties.Settings.Default.Save();
            
        }

        private void timeStartEnable_CheckedChanged(object sender, EventArgs e)
        {
            timeChecker.Enabled = timeStartEnable.Checked;
        }
    }
}
