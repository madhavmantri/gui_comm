using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ZedGraph;

namespace gui
{
 
    public partial class Form1 : Form
    {
        SerialPort port;
        double time = 3.2;
        GraphPane myPane = new GraphPane();
        PointPairList listPointsOne = new PointPairList();
        LineItem myCurveOne;
        byte [] Ticks = new byte[200];
        string Target_Right, Target_Left;
        int Port_flag=0;
        public event SerialDataReceivedEventHandler DataReceived;
       
        public Form1()
        {  
            InitializeComponent();
            

            string[] ports = SerialPort.GetPortNames();
            foreach (string Port in ports)
            {
                Ports.Items.Add(Port);
            }
                
           
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            
                if (Port_flag==0)
                {
                    port = new SerialPort(Ports.Text, 38400, Parity.None, 8, StopBits.One);
                    port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    port.Open();
                    Port_flag = 1;
                    Connect.Text = "Disconnect";
                  
                }
                else
                {
                    port = new SerialPort(Ports.Text, 38400, Parity.None, 8, StopBits.One);
                    port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    port.Close();
                    Port_flag = 0;
                    Connect.Text = "Connect";
                }
            
        }
      
        private void Send_Click(object sender, EventArgs e)
        {
           
            if (OpenLoop.Checked)
            {
                for (int i = 0; i < 2; i++)
                {
                    int qwerty1 = Convert.ToInt16(0);
                    char ch1 = (char)qwerty1;
                    string myString1 = ch1.ToString();
                    port.Write(myString1);
                }
               
               
            }
            else
            {
                int qwerty1 = Convert.ToInt16(Kp.Text);
                char ch1 = (char)qwerty1;
                string myString1 = ch1.ToString();
                port.Write(myString1);
                int qwerty2 = Convert.ToInt16(Kd.Text);
                char ch2 = (char)qwerty2;
                string myString2 = ch2.ToString();
                port.Write(myString2);
                

            }
         
        }

        private void Plot_Click(object sender, EventArgs e)
        {
            myPane = Graph.GraphPane;
            myPane.Title.Text = "PID";

            // set X and Y axis titles
            myPane.XAxis.Title.Text = "Time(ms)";
            myPane.YAxis.Title.Text = "Ticks";
            Graph.GraphPane.CurveList.Clear();
           
            for (int i = 0; i < 200; i++)
            {
                listPointsOne.Add(i*3.2,(Ticks[i]));
            }
            myCurveOne = myPane.AddCurve(null, listPointsOne, Color.Black, SymbolType.Circle);
            Graph.AxisChange();
            Graph.Invalidate();
            Graph.Refresh();
            for (int i = 0; i < 200; i++)
            {
                Ticks[i] = 0;
            }
           
            
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }
  

        private void ResetButton_Click(object sender, EventArgs e)
        {

            Graph.GraphPane.CurveList.Clear();
            Graph.Invalidate();
            Graph.Refresh();
          
            listPointsOne.Clear();
            for (int i = 1; i < listPointsOne.Count; i++)
            {
                listPointsOne.RemoveAt(i);
            }

            for (int i = 0; i < 200; i++)
            {
                Ticks[i] = 0;
            }
           
        }

       

        private void Send_targets_Click(object sender, EventArgs e)
        {

            int qwerty4 = Convert.ToInt16(Velocity_left_textbox.Text);
            char ch4 = (char)qwerty4;
            string myString4 = ch4.ToString();
            port.Write(myString4);
            int qwerty5 = Convert.ToInt16(Velocity_right_textbox.Text);
            char ch5 = (char)qwerty5;
            string myString5 = ch5.ToString();
            port.Write(myString5);
         
            
        }
         public void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        {
            //char a;
             SerialPort sp = (SerialPort)sender;
             
        for (int i = 0; i < 200; i++)
        {
           // int qwerty5 = Convert.ToInt16(sp.ReadExisting());
          //  char ch5 = (char)qwerty5;
          //string myString4 = ch5.ToString();

            Ticks[i] = Convert.ToByte(sp.ReadByte());
           
            
        }
        for (int i = 0; i < 200; i++)
        {
            Console.Write(Ticks[i]);
            Console.Write("\t");

        }
        
        
    }

         private void Graph_Load(object sender, EventArgs e)
         {

         }
            
       

        

       
    }
}
