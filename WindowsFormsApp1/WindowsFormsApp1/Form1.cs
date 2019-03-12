﻿using DataManipulation;
using System;
using System.Windows.Forms;
using ClassForPanelUtility;
using Operations;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        //Exit button
        private void button5_Click(object sender, EventArgs e) 
        {
            ExcelOperations.Exit();
            System.Windows.Forms.Application.Exit();
        }

        //record Data&Time
        private void button2_Click(object sender, EventArgs e) 
        {

        }

        //Load Cfg
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //bar4
        private void progressBar4_Click(object sender, EventArgs e)
        {


            ModifyProgressBarColor.SetState(progressBar4, 2);
           // Note the second parameter in SetState, 1 = normal(green); 2 = error(red); 3 = warning(yellow).

            progressBar4.Maximum = ClassCfgData.IntWorkingMinutesDay;
            progressBar4.Step = 1;
            progressBar4.Value = Convert.ToInt32(ClassCfgData.IntOnlineTime);

            MessageBox.Show("Time Difference (minutes): " + ClassCfgData.IntOnlineTime);


        }
        
        //read
        private void button3_Click(object sender, EventArgs e)
        {
           string message = ClassForExcelFunction.ClassForExcelFunction.ReadExcelCell(6, 5, 2);
            MessageBox.Show(message);
        }

        //Write 
        private void button4_Click(object sender, EventArgs e)
        {
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(8, 5, 1, DateTime.Now.ToString("HH:mm"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(8, 6, 1, DateTime.Now.ToString("dd/M/yyyy"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(9, 5, 1, DateTime.Now.ToString("HH:mm"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(9, 6, 1, DateTime.Now.ToString("dd/M/yyyy"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(10, 5, 1, DateTime.Now.ToString("HH:mm"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(10, 6, 1, DateTime.Now.ToString("dd/M/yyyy"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(11, 5, 1, DateTime.Now.ToString("HH:mm"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(11, 6, 1, DateTime.Now.ToString("dd/M/yyyy"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(12, 5, 1, DateTime.Now.ToString("HH:mm"));
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(12, 6, 1, DateTime.Now.ToString("dd/M/yyyy"));

            MessageBox.Show("Your message was write successfuly");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_SystemColorsChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is developed by Adrian Naziru"); // provide information.
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void somethingElseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 5;
            MessageBox.Show(Operations.ClassLoadCfg.LoadCfg());
            //ClassForCfg.ClassLoadConfiguraiton.LoadCfg();
        }

        private void button4_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e) //button used for opening Excel file
        {
            System.Diagnostics.Process.Start(ClassForStorageContainers.ExcelDirectoryClass.ExcelPath);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 480;
            progressBar1.Step = 1;
            progressBar1.Value = 5; // final time - current time - pause;
        }

        private void button9_Click(object sender, EventArgs e)
        {
           // Operations.ClassLoadCfg.LoadCfg();
            MessageBox.Show(Operations.ExcelOperations.LoadExcelCfgFunction());
            MessageBox.Show(ClassCfgData.IntEntryNumber.ToString());
            MessageBox.Show(DateTime.Now.ToString("HH:mm"));
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Operations.ExcelOperations.RecordEntry());
                
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Operations.ExcelOperations.ResetData());
        }

        private void classforProgressBarBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show(" 45 Minutes pass since this app is open");

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar4.Value = Convert.ToInt32(ClassCfgData.IntOnlineTime);
            ClassCfgData.IntOnlineTime++;
            ClassForExcelFunction.ClassForExcelFunction.WriteExcelCell(18, 10, 2, ClassCfgData.IntOnlineTime.ToString());
            MessageBox.Show(ClassCfgData.IntOnlineTime.ToString()+@" minutes pass since this app is open", "Time since app was open");
        }
    }
}
