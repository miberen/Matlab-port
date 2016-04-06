#define LOG

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace FanucConnector
{
    public partial class Main : Form
    {
        private readonly IPAddress _hostIpAddress = IPAddress.Parse("192.168.1.25");
        //private readonly IPAddress _hostIpAddress = IPAddress.Parse("127.0.0.1");
        private readonly int _hostPort = 59002;
        //private readonly int _hostPort = 8001;
        private TcpClient _client;
        private NetworkStream _hostStream;
        private readonly List<Figure> _figures;
        private List<Figure> _orders = new List<Figure>();  

        public Main()
        {
            InitializeComponent(); 
            _figures = new List<Figure>();      
            FillFigures();
        }

        #region Figure Related
        private class Figure
        {
            public Figure(Character chararacter)
            {
                Type = chararacter;
                Color = new List<Color>();
                FillColor(Color);
            }

            public enum Character
            {
                Homer,
                Marge,
                Bart,
                Lisa,
                Maggie
            }
            public Character Type;
            public Point Point;
            public List<Color> Color;

            void FillColor(List<Color> colors)
            {
                switch (Type)
                {
                    case Character.Homer:
                        colors.Add(System.Drawing.Color.Blue);
                        colors.Add(System.Drawing.Color.White);
                        colors.Add(System.Drawing.Color.Yellow);
                        break;
                    case Character.Marge:
                        colors.Add(System.Drawing.Color.Green);
                        colors.Add(System.Drawing.Color.Yellow);
                        colors.Add(System.Drawing.Color.Blue);
                        break;
                    case Character.Bart:
                        colors.Add(System.Drawing.Color.Blue);
                        colors.Add(System.Drawing.Color.Orange);
                        colors.Add(System.Drawing.Color.Yellow);
                        break;
                    case Character.Lisa:
                        colors.Add(System.Drawing.Color.Yellow);
                        colors.Add(System.Drawing.Color.Orange);
                        colors.Add(System.Drawing.Color.Yellow);
                        break;
                    case Character.Maggie:
                        colors.Add(System.Drawing.Color.Blue);
                        colors.Add(System.Drawing.Color.Yellow);
                        break;
                }
            }

            public override string ToString()
            {
                switch (Type)
                {
                        case Character.Homer:
                        return "Homer";
                        case Character.Marge:
                        return "Marge";
                        case Character.Bart:
                        return "Bart";
                        case Character.Lisa:
                        return "Lisa";
                        case Character.Maggie:
                        return "Maggie";
                    default:
                        return null;
                }
            }
        }

        private void FillFigures()
        {
            _figures.Add(new Figure(Figure.Character.Homer));
            _figures.Add(new Figure(Figure.Character.Marge));
            _figures.Add(new Figure(Figure.Character.Bart));
            _figures.Add(new Figure(Figure.Character.Lisa));
            _figures.Add(new Figure(Figure.Character.Maggie));
            lb_figures.Items.AddRange(_figures.ToArray());
        }
        #endregion

        #region Send/Recieve
        private async void Connect()
        {
            rTBox_main.AppendText("Attemtping to connect to: " + _hostIpAddress + ":" + _hostPort + "\n");
            await Task.Delay(200);
            try
            {
                _client = new TcpClient();
                await _client.ConnectAsync(_hostIpAddress.ToString(), _hostPort);

                _hostStream = _client.GetStream();

                rTBox_main.AppendText("Connected to: " + _hostIpAddress + ":" + _hostPort + "\n");
            }
            catch (ArgumentNullException e)
            {
                rTBox_main.AppendText("ArgumentNullException: {0}" + e + "\n");
            }
            catch (SocketException e)
            {
                rTBox_main.AppendText("SocketException: {0}" + e + "\n");
            }
        }

        private void RobotSend(string data)
        {
            if (_hostStream.CanWrite)
            {
                _hostStream.Flush();
                byte[] outStream = Encoding.ASCII.GetBytes(data);
                List<byte> outList = outStream.ToList();
                outList.Add(10);
                _hostStream.Write(outList.ToArray(), 0, outList.Count);

#if LOG
                rTBox_main.AppendText("Data sent: " + data + "\n");
#endif
            }
            else
            {
                rTBox_main.AppendText("CanWrite is false! \n");
            }
            
        }

        private void RecieveData()
        {
            while (!_hostStream.DataAvailable) { }

            byte[] inStream = new byte[1024];
            _hostStream.Read(inStream, 0, inStream.Length);
            string returnData = Encoding.ASCII.GetString(inStream);
            rTBox_main.AppendText("Data Recieved:" + returnData);
            rTBox_main.AppendText("\n");
        }

        List<double> RobotGetPos()
        {

            RobotSend("GETPOS;");

            while (!_hostStream.DataAvailable) { }

            byte[] inStream = new byte[1024];
            _hostStream.Read(inStream, 0, inStream.Length);
            string returnData = Encoding.ASCII.GetString(inStream);
            rTBox_main.AppendText("Data Recieved:" + returnData + "\n");
            List<double> position = new List<double>();

            IEnumerable<string> strings = returnData.Split(new[] { ' ', ']', '[' }, StringSplitOptions.RemoveEmptyEntries).Where(s => !string.IsNullOrWhiteSpace(s) && s.Length < 50);
            foreach (string strs in strings)
            {
                //rTBox_main.AppendText(strs.Length + "\n");
                position.Add(double.Parse(strs, new CultureInfo("en-US")));
                //position.Add(Convert.ToDouble(strs, new CultureInfo("en-US")));
            }

            txt_coord0.Text = position[0].ToString();
            txt_coord1.Text = position[1].ToString();
            txt_coord2.Text = position[2].ToString();
            txt_coord3.Text = position[3].ToString();
            txt_coord4.Text = position[4].ToString();
            txt_coord5.Text = position[5].ToString();

            return position;
        }

        void RobotMoveJoint(double x, double y, double z, double w, double p, double r, double speed)
        {
            const string whatTheFuck = ".#################################;-.##################################;0";
#if LOG
            rTBox_main.AppendText("MOVEJ;[" + x.ToString(whatTheFuck, new CultureInfo("en-US")) + "," +
                                              y.ToString(whatTheFuck, new CultureInfo("en-US")) + "," +
                                              z.ToString(whatTheFuck, new CultureInfo("en-US")) + "," +
                                              w.ToString(whatTheFuck, new CultureInfo("en-US")) + "," +
                                              p.ToString(whatTheFuck, new CultureInfo("en-US")) + "," +
                                              r.ToString(whatTheFuck, new CultureInfo("en-US")) + "," +
                                              speed.ToString(whatTheFuck, new CultureInfo("en-US")) + "];");
#endif         

            RobotSend("MOVEJ;[" + x.ToString(whatTheFuck, new CultureInfo("en-US")) + "," +
                                              y.ToString(whatTheFuck, new CultureInfo("en-US")) + "," +
                                              z.ToString(whatTheFuck, new CultureInfo("en-US")) + "," +
                                              w.ToString(whatTheFuck, new CultureInfo("en-US")) + "," +
                                              p.ToString(whatTheFuck, new CultureInfo("en-US")) + "," +
                                              r.ToString(whatTheFuck, new CultureInfo("en-US")) + "," +
                                              speed.ToString(whatTheFuck, new CultureInfo("en-US")) + "];");
            RecieveData();
            RecieveData();

        }

        void OpenGrapper()
        {
            RobotSend("GRABOFF;");
            RecieveData();
        }

        void CloseGrapper()
        {
            RobotSend("GRABON;");
            RecieveData();
        }

        #endregion

        #region ButtonEvents

        private void btn_connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if (_client.Connected)
            {
                _hostStream.Close();
                _client.Close();
                rTBox_main.AppendText("Socket closed \n");
            }
        }

        private void btn_testSend_Click(object sender, EventArgs e)
        {
            foreach (var data in RobotGetPos())
            {
                rTBox_main.AppendText(data.ToString() + "\n");
            }
        }

        private void btn_openGrapper_Click(object sender, EventArgs e)
        {
            OpenGrapper();
        }

        private void btn_closeGrapper_Click(object sender, EventArgs e)
        {
            CloseGrapper();
        }

        private void btn_getPos_Click(object sender, EventArgs e)
        {
            List<double> positions = RobotGetPos();
            foreach (double dbl in positions)
            {             
                rTBox_main.AppendText(dbl.ToString() + "\n");
            }
            
        }

        private void btn_moveJoint_Click(object sender, EventArgs e)
        {
            RobotMoveJoint(double.Parse(txt_coord0.Text), 
                           double.Parse(txt_coord1.Text), 
                           double.Parse(txt_coord2.Text), 
                           double.Parse(txt_coord3.Text), 
                           double.Parse(txt_coord4.Text), 
                           double.Parse(txt_coord5.Text), 
                           double.Parse(txt_speed.Text));
            RobotGetPos();
        }

        private void btn_listAdd_Click(object sender, EventArgs e)
        {
            lb_orders.Items.Add(lb_figures.SelectedItem);

        }

        private void btn_listRemove_Click(object sender, EventArgs e)
        {
            lb_orders.Items.Remove(lb_orders.SelectedItem);
        }

        private void lb_figures_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lb_figures.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                lb_orders.Items.Add(lb_figures.Items[index]);
            }
        }

        private void lb_orders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lb_orders.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                lb_orders.Items.Remove(lb_orders.Items[index]);
            }
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            int selectedIndex = lb_orders.SelectedIndex;
            if (selectedIndex < lb_orders.Items.Count - 1 & selectedIndex != -1)
            {
                lb_orders.Items.Insert(selectedIndex + 2, lb_orders.Items[selectedIndex]);
                lb_orders.Items.RemoveAt(selectedIndex);
                lb_orders.SelectedIndex = selectedIndex + 1;

            }
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            int selectedIndex = lb_orders.SelectedIndex;
            if (selectedIndex > 0)
            {
                lb_orders.Items.Insert(selectedIndex - 1, lb_orders.Items[selectedIndex]);
                lb_orders.Items.RemoveAt(selectedIndex + 1);
                lb_orders.SelectedIndex = selectedIndex - 1;
            }
        }
        private void btn_build_Click(object sender, EventArgs e)
        {

        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            _orders.Clear();
            foreach (object obj in lb_orders.Items)
            {
                _orders.Add((Figure)obj);
            }

            List<Color> orderColors = _orders.SelectMany(fig => fig.Color).ToList();
#if LOG
            foreach (Color color in orderColors)
            {
                rTBox_main.AppendText(color.ToString() + "\n");
            }
#endif
        }
        #endregion

    }
}
