using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;
using System.IO;


namespace BashfulClock
{
    public partial class Form1 : Form
    {
        string spath = Directory.GetCurrentDirectory();
        int alarmTimer1, alarmTimer2;
        bool firstClick = true;
        bool alarm2 = true;
        bool alarm1 = true;

        SoundPlayer music = new SoundPlayer(Directory.GetCurrentDirectory() + @"\m1.wav");
        SoundPlayer music2 = new SoundPlayer(Directory.GetCurrentDirectory() + @"\z.wav");
        Clock c1 = new Clock();        
        Thread t1;
        
        public Form1()
        {
            InitializeComponent();
            SetVisualLayout();
        }

        //Hanterar layout/färger
        private void SetVisualLayout()
        {
            //Här ändras uteseendet på själva appen 
            buttonStartClock.FlatAppearance.BorderColor = Color.FromArgb(244, 131, 124);
            buttonStartClock.BackColor = Color.FromArgb(52, 93, 126);
            buttonSetAlarm.FlatAppearance.BorderColor = Color.FromArgb(244, 131, 124);
            buttonSetAlarm.BackColor = Color.FromArgb(52, 93, 126);
            buttonSetAlarm2.FlatAppearance.BorderColor = Color.FromArgb(244, 131, 124);
            buttonSetAlarm2.BackColor = Color.FromArgb(52, 93, 126);
            textBoxSetHour.BackColor = Color.FromArgb(244, 131, 124);
            textBoxSetMinute.BackColor = Color.FromArgb(244, 131, 124);
            textBoxAlarmHour.BackColor = Color.FromArgb(244, 131, 124);
            textBoxAlarmHoure2.BackColor = Color.FromArgb(244, 131, 124);
            textBoxAlarmMinute.BackColor = Color.FromArgb(244, 131, 124);
            textBoxAlarmMinute2.BackColor = Color.FromArgb(244, 131, 124);
            labelClock.BackColor = Color.FromArgb(244, 131, 122);
        }

        //Hanterar eventet för då klockan startas på knappen
        private void buttonStartClock_Click(object sender, EventArgs e)
        {
            //Om firstClick är true IE det är första klicket på knappen
            if (firstClick)
            {
                Clock.isRunning = true;
                //Gör en koll för att se om man har skrivit in rätt värde(enbart siffror) med extensions som returnerar bools
                if ((textBoxSetMinute.Text.CheckMinuteValue()) && (textBoxSetHour.Text.CheckHourValue()))
                {
                    c1.SetTime(int.Parse(textBoxSetHour.Text), int.Parse(textBoxSetMinute.Text));
                    textBoxSetHour.ReadOnly = true;
                    textBoxSetMinute.ReadOnly = true;
                    textBoxSetHour.ForeColor = Color.FromArgb(105, 105, 105);
                    textBoxSetMinute.ForeColor = Color.FromArgb(105, 105, 105);
                    buttonStartClock.Text = "Stop Clock";
                    t1 = new Thread(new ThreadStart(c1.StartClock));
                    t1.IsBackground = true;    //Viktig att sätta tråden till "isBackground"! Annars kommer den fortsätta köras om man stänger ner programmet(Main-thread).
                    c1.clockEventHandler += ClockStartEvent;
                    t1.Start();
                    firstClick = false;
                }
                else
                {
                    Exstensions.ErrorMessage();
                    return;
                }
            }
            //Om firstklick är False IE Andra klicket på knappen
            else
            {
                c1.StopClock();
                buttonStartClock.Text = "Start Clock";
                textBoxSetHour.ReadOnly = false;
                textBoxSetMinute.ReadOnly = false;
                textBoxSetHour.ForeColor = Color.White;
                textBoxSetMinute.ForeColor = Color.White;
                firstClick = true;
            }
        }

        //Ändra texten för att visa tiden
        public void ChangeTimeLabel()
        {            
            labelClock.Text = c1.GetHours().ToString("D2") + ":" + c1.GetMinutes().ToString("D2");
        }

        //Event för att starta klockan och plocka in alla labels med invokes
        private void ClockStartEvent(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
               Invoke(new MethodInvoker(ChangeTimeLabel));
               Invoke(new MethodInvoker(Alarm1Going));
               Invoke(new MethodInvoker(Alarm2Going));
            }
            else
            {
                ChangeTimeLabel();
                Alarm1Going();
                Alarm2Going();
            }
        }

        //Click event för alarmen och tick event för timerarna
        private void buttonSetAlarm_Click(object sender, EventArgs e)
        {
            c1.alarm1 = new Alarm();
            AlarmUpdateHandler(labelAlarm1,  textBoxAlarmHour, textBoxAlarmMinute, buttonSetAlarm, c1.alarm1, ref alarm1);
        }
        private void buttonSetAlarm2_Click(object sender, EventArgs e)
        {           
            c1.alarm2 = new Alarm();
            AlarmUpdateHandler(labelAlarm2, textBoxAlarmHoure2, textBoxAlarmMinute2, buttonSetAlarm2, c1.alarm2, ref alarm2);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            AlarmWarning(timer1, buttonSetAlarm,textBoxAlarmHour,textBoxAlarmMinute, c1.alarm1, ref alarmTimer1, ref alarm1);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            AlarmWarning(timer2, buttonSetAlarm2, textBoxAlarmHoure2,textBoxAlarmMinute2 ,c1.alarm2, ref alarmTimer2, ref alarm2);
        }

        //Hanterar att starta alarm varningen för första alarmet
        public void Alarm1Going()
        {
            if (c1.alarm1 != null && c1.alarm1.GetRunningAlarm())
            {
                music.Play();
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        //Samma som ovan fast för Alarm2
        public void Alarm2Going()
        {
            if (c1.alarm2 != null && c1.alarm2.GetRunningAlarm())
            {
                music2.Play();
                timer2.Enabled = true;
                timer2.Start();
            }

        }

        //En metod som hanterar Alarmen
        private void AlarmUpdateHandler (Label alarmLabel,  TextBox tH, TextBox tM, Button b1, Alarm alarm, ref bool firstClickAlarm)
        {  
            //Om det är första klicket på knappen
            if (firstClickAlarm)
            {
                if ((tH.Text.CheckHourValue()) && (tM.Text.CheckMinuteValue()))
                {
                    c1.AlarmHandler(tH.Text.Parser(), tM.Text.Parser(), alarm);

                    alarmLabel.Text = tH.Text.Parser().ToString("D2") + ":" + tM.Text.Parser().ToString("D2");
                    
                    b1.BackColor = Color.FromArgb(121,174,138);
                    tH.ReadOnly = true;
                    tM.ReadOnly = true;
                    tH.ForeColor = Color.FromArgb(105, 105, 105);
                    tM.ForeColor = Color.FromArgb(105, 105, 105);

                    b1.Text = "Stop Alarm";
                    firstClickAlarm = false;
                }
                else
                {
                    Exstensions.ErrorMessage();
                    return;
                }
            }
            //Om firstclick är false IE andra klicket på knappen
            else
            {                
                tH.ReadOnly = false;
                tM.ReadOnly = false;
                tH.ForeColor = Color.White;
                tM.ForeColor = Color.White;
                b1.Text = "Start alarm";
                b1.BackColor = Color.FromArgb(52, 93, 126);
                b1.FlatAppearance.BorderColor = Color.FromArgb(244, 131, 124);
                c1.AlarmHandler(true, alarm);
                firstClickAlarm = true;
            }
        }

        //Metod som hanterar då alarmet börjar ringa
        private void AlarmWarning(System.Windows.Forms.Timer timer, Button alarmButton,TextBox t1,TextBox t2, Alarm alarm, ref int alarmTimer, ref bool alarmFirstClick)
        {
            if (alarmTimer % 5 == 0)
            {  
                alarmButton.BackColor = Color.FromArgb(255,53,93);
                alarmButton.FlatAppearance.BorderColor = Color.FromArgb(121, 174, 138);
                if (alarmFirstClick == true)
                {
                    alarmButton.BackColor = Color.FromArgb(52, 93, 126);
                    alarmButton.FlatAppearance.BorderColor = Color.FromArgb(244, 131, 124);
                    alarmTimer = 0;
                    alarmButton.Text = "Set Alarm";
                    //alarmFirstClick = true;
                    c1.AlarmHandler(true, alarm);
                    t1.ReadOnly = false;
                    t2.ReadOnly = false;
                    t1.Clear();
                    t2.Clear();
                    music.Stop();
                    music2.Stop();
                    timer.Stop();
                }
            }
            else
            {
                alarmButton.FlatAppearance.BorderColor = Color.FromArgb(255, 53, 93);
                alarmButton.BackColor = Color.FromArgb(121, 174, 138);
            }

            alarmTimer++;

            if (alarmTimer == 50)
            {
                alarmButton.FlatAppearance.BorderColor = Color.FromArgb(244, 131, 124);
                alarmButton.BackColor = Color.FromArgb(52, 93, 126);
                alarmTimer = 0;
                alarmButton.Text = "Set Alarm";
                alarmFirstClick = true;
                c1.AlarmHandler(true, alarm);
                t1.ReadOnly = false;
                t2.ReadOnly = false;
                t1.Clear();
                t2.Clear();
                music.Stop();
                music2.Stop();
                timer.Stop();
            }
        }

    }
}
