using System;
using System.IO;
using System.Windows.Forms;

namespace Reminder
{
    public partial class Form_Main : Form
    {

        public Form_Main()
        {
            InitializeComponent();  //start comparing actual time and notifi time (timer tick)

            readData();     //start reading data
        }


        /// <summary>
        /// Hide window.
        /// </summary>
        private void btn_minimalize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Show notification window.
        /// </summary>
        private void notifiIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        /// <summary>
        /// Close program.
        /// </summary>
        private void btn_shutDown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Get date, time and info from formular.
        /// <seealso cref="saveNotifi(DateTime, int, string)"/>
        /// <seealso cref="readData"/>
        /// </summary>
        private void btn_saveNotifi_Click(object sender, EventArgs e)
        {
            DateTime dateTimeNotifi = DateTime.Parse(dateTimePicker.Value.ToString("dd.MM.yyyy HH:mm"));      //datetime to string
            int interval = int.Parse(num_interval.Value.ToString());                                          //interval to string
            string notifiInfo = tb_infoNotifi.Text.Replace("\n", String.Empty);                               //info about notifi. to string

            saveNotifi(dateTimeNotifi, interval, notifiInfo);       //import notification
            readData();     //update list of notification
        }

        /// <summary>
        /// Save notification to text file.
        /// </summary>
        /// <param name="dateTime">Actual date and time.</param>
        /// <param name="interval">Repeating interval.</param>
        /// <param name="info">Information about each separately.</param>
        private void saveNotifi(DateTime dateTime, int interval, string info)
        {
            string notification = dateTime.ToString() + ";" + interval.ToString() + ";" + info + ";" + Environment.NewLine;       //concate one all notifi
            try
            {
                File.AppendAllText("./notification.txt", notification);         //save data to .txt file
            }
            catch (Exception ex)
            {
                if (ex is PathTooLongException || ex is DirectoryNotFoundException)
                    MessageBox.Show("Problém se souborem s daty.");
                throw;
            }
        }

        /// <summary>
        /// Read all notification from *.txt file where are all notifications saved.
        /// </summary>
        private void readData()
        {
            deleteList();

            try
            {
                string[] dataLines = File.ReadAllLines("./notification.txt");   //save all data to arr. string

                foreach (string txt in dataLines)
                {
                    list_notifications.Items.Add(txt);      //get every single data to list of notifi.
                }
            }
            catch (Exception ex)
            {
                if(ex is FileNotFoundException || ex is FileLoadException)
                    MessageBox.Show("Problém se souborem s daty.");
            }
        }

        /// <summary>
        /// Delete choosen notification by user.
        /// </summary>
        /// <seealso cref="removeLine(int)"/>
        /// <seealso cref="readData"/>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delteNotifi_Click(object sender, EventArgs e)
        {
            int index = list_notifications.Items.IndexOf(list_notifications.SelectedItems[0]);  //get index of deleting notifi.

            removeLine(index);

            readData();
        }

        /// <summary>
        /// Delete specific line from notification list.
        /// </summary>
        /// <param name="index">Index of deleting notification.</param>
        private void removeLine(int index)
        {
            int actualLine = 0;
            string line = null;
            try
            {
                using (StreamReader reader = new StreamReader("./notification.txt"))        //new stream reader
                {
                    using (StreamWriter writer = new StreamWriter("./tmp.txt"))             //new stream writer
                    {
                        while ((line = reader.ReadLine()) != null)       //while has lines to read
                        {
                            if (actualLine == index)                //if is it deleting line, don't write it
                            {
                                actualLine++;
                                continue;
                            }

                            actualLine++;
                            writer.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is FileNotFoundException || ex is DirectoryNotFoundException || ex is PathTooLongException)
                    MessageBox.Show("Problém se souborem s daty nebo adresářem.");
                throw;
            }
            finally
            { 
                File.Delete("./notification.txt");                  //remake file
                File.Move("./tmp.txt", "./notification.txt");
            }
        }

        /// <summary>
        /// Clear list box.
        /// </summary>
        private void deleteList()
        {
            list_notifications.Items.Clear();
        }

        /// <summary>
        /// When the Reminder is start, start timer.
        /// </summary>
        private void Form_Main_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        /// <summary>
        /// Every timer tick compare date and time.
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;       //get actual time
            compareTime(time);   
        }

        /// <summary>
        /// Compare actual time and notifi time.
        /// </summary>
        /// <param name="now">Actuall time.</param>
        private void compareTime(DateTime now)
        {
            string[] allLines = File.ReadAllLines("./notification.txt");
            string[] separator = new string[] { ";" };  //specifi separator char
            string[] splitText = null;
            int actualLine = 0;
            
            foreach (string line in allLines)
            {
                splitText = line.Split(separator, StringSplitOptions.None);     //split line of text
                DateTime notifiTime = new DateTime();
                notifiTime = Convert.ToDateTime(splitText[0]);

                string actualTime = now.ToString("dd.MM.yyyy HH:mm");
                string strNotifiTime = notifiTime.ToString("dd.MM.yyyy HH:mm");

                if (string.Equals(actualTime, strNotifiTime))       //compare date and time 
                {
                    notifiUser(splitText[2]);       //notifi user in notification area
                    int interval = Convert.ToInt32(splitText[1]);

                    if(interval != 0)
                        newNotification(interval, now, splitText[2]);   //make new notification because have interval

                    removeLine(actualLine);
                }
                actualLine++;
            }
        }

        /// <summary>
        /// Set new notification from date, time and interval.
        /// </summary>
        /// <param name="interval">Repeat notification interval.</param>
        /// <param name="now">Actual time.</param>
        /// <param name="info">Information about separate notification.</param>
        private void newNotification(int interval, DateTime now, string info)
        {
            now = now.AddMinutes(interval);     //add interval in minutes
            saveNotifi(now, interval, info);    //save new notification

            deleteList();
            readData();
        }

        /// <summary>
        /// Alert user.
        /// </summary>
        /// <param name="info">Notification information.</param>
        private void notifiUser(string info)
        {
            notifiIcon.ShowBalloonTip(1500, "Upozornění", info, ToolTipIcon.Info);
        }
    }
}
