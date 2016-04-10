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
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;
using BorderType = Emgu.CV.CvEnum.BorderType;

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
        private List<Brick> _availibleBricks = new List<Brick>();

        private Emgu.CV.Capture _capture = null;
        static int offsetX, offsetY, horizontalScrollBarValue, verticalScrollBarValue;
        private Mat frame = new Mat();
        private Mat undistFrame = new Mat();
        private Mat frameHSV = new Mat();
        private bool _orderApproved;
        private bool _isCalibrated = false;
        


        //Camcalib stuff
        private Mat _cameraMatrix;
        private Mat _distCoeffs;



        public Main()
        {
            InitializeComponent();
            _figures = new List<Figure>();
            FillFigures();

            img_camfeed.FunctionalMode = ImageBox.FunctionalModeOption.Everything;
            CvInvoke.UseOpenCL = false;
            try
            {
                //_capture = new Emgu.CV.Capture(CaptureType.DShow);
                //_capture.SetCaptureProperty(CapProp.FrameWidth, 1280);
                //_capture.SetCaptureProperty(CapProp.FrameHeight, 720);
                //_capture.SetCaptureProperty(CapProp.Settings, 0);
                //_capture.ImageGrabbed += ProcessFrame;

                frame = CvInvoke.Imread(@"D:\GDrive\AAU\P8 VGIS\Courses\Robot Vision\Mini Project\Imgbricks\im720a.jpg", LoadImageType.AnyColor);
                //CvInvoke.Undistort(frame, frame, _cameraMatrix, _distCoeffs);
                Application.Idle += ProcessFrame;

            }

            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        private void ProcessFrame(object sender, EventArgs e)
        {

            // _capture.Retrieve(frame, 0);
            frame.CopyTo(undistFrame);
            //if (_isCalibrated)
            // CvInvoke.Undistort(frame, undistFrame, _cameraMatrix, _distCoeffs);
            CvInvoke.CvtColor(undistFrame, frameHSV, ColorConversion.Bgr2Hsv);

            //CvInvoke.PutText(frame, "X-Coordinate " + offsetX, new System.Drawing.Point(50, 20), FontFace.HersheyPlain, 1.5, new Bgr(155, 50, 50).MCvScalar);
            //CvInvoke.PutText(frame, "Y-Coordinate " + offsetY, new System.Drawing.Point(50, 40), FontFace.HersheyPlain, 1.5, new Bgr(155, 50, 50).MCvScalar);
            //colorFilter(frameHSV, 105, 125, 150, 255, 25, 255, false);
            //colorFilter(frameHSV, 12, 18, 170, 255, 220, 255, false);
            img_camfeed.Image = undistFrame;

        }

        #region Figure Related

        private struct ColorFilt
        {
            private readonly List<object> _filter;

            public ColorFilt(List<object> input)
            {
                _filter = input;
            }

            public ColorFilt(Color color)
            {
                if (color == Color.Blue)
                    _filter = new List<object> {110, 120, 230, 255, 230, 255, false};
                else if (color == Color.Yellow)
                    _filter = new List<object> {20, 25, 165, 229, 200, 255, false};
                else if (color == Color.Orange)
                    _filter = new List<object> {0, 10, 153, 204, 215, 255, false};
                else if (color == Color.Green)
                    _filter = new List<object> {50, 75, 175, 229, 153, 229, false};
                else if (color == Color.White)
                    _filter = new List<object> {70, 100, 25, 90, 229, 255, false};
                else
                {
                    MessageBox.Show(@"Color not found");
                    _filter = null;
                }
            }

            public List<object> Filter()
            {
                return _filter;
            }
        }

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

        private class Brick : IEquatable<Brick>
        {
            private Color _color;
            private Point _position;
            private double _angle;

            public Brick(Color color, Point position, double angle)
            {
                _color = color;
                _position = position;
                _angle = angle;
            }

            public Color Color
            {
                get { return _color; }
                set { _color = value; }
            }

            public Point Position
            {
                get { return _position; }
                set { _position = value; }
            }

            public double Angle
            {
                get { return _angle; }
                set { _angle = value; }
            }
                

            public override string ToString()
            {
                return "Brick: Color: " + _color.ToString() + " Position: " + _position.ToString() + " Angle: " + _angle.ToString();
            }

            public bool Equals(Brick other)
            {
                // Would still want to check for null etc. first.
                return this._color == other._color;
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
            while (!_hostStream.DataAvailable)
            {
            }

            byte[] inStream = new byte[1024];
            _hostStream.Read(inStream, 0, inStream.Length);
            string returnData = Encoding.ASCII.GetString(inStream);
            rTBox_main.AppendText("Data Recieved:" + returnData);
            rTBox_main.AppendText("\n");
        }

        List<double> RobotGetPos()
        {

            RobotSend("GETPOS;");

            while (!_hostStream.DataAvailable)
            {
            }

            byte[] inStream = new byte[1024];
            _hostStream.Read(inStream, 0, inStream.Length);
            string returnData = Encoding.ASCII.GetString(inStream);
            rTBox_main.AppendText("Data Recieved:" + returnData + "\n");
            List<double> position = new List<double>();

            IEnumerable<string> strings =
                returnData.Split(new[] {' ', ']', '['}, StringSplitOptions.RemoveEmptyEntries)
                    .Where(s => !string.IsNullOrWhiteSpace(s) && s.Length < 50);
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
            _availibleBricks.Clear();
            
            foreach (object obj in lb_orders.Items)
            {
                _orders.Add((Figure) obj);
            }

            List<Color> orderColors = _orders.SelectMany(fig => fig.Color).ToList();

            HashSet<Color> uniques = new HashSet<Color>(orderColors);

            foreach (Color col in uniques)
            {
                List<object> filter = new ColorFilt(col).Filter();

                colorFilter(frameHSV, col, Convert.ToSingle(filter[0]), Convert.ToSingle(filter[1]), Convert.ToSingle(filter[2]), Convert.ToSingle(filter[3]), Convert.ToSingle(filter[4]), Convert.ToSingle(filter[5]), false);
            }

            foreach (var brick in _availibleBricks)
            {
                rTBox_main.AppendText(brick.ToString() + "\n");
            }

            List<Color> availibleCols = _availibleBricks.Select(brick => brick.Color).ToList();
            var uniquecols = orderColors.Distinct();
            int failed = 0;
            foreach (var color in uniquecols)
            {
                var amountordered = orderColors.Count(x => x == color);
                var amountAvailable = availibleCols.Count(x => x == color);
                if (amountordered > amountAvailable)
                {
                    rTBox_main.AppendText("Not enough: " + color.ToString() +"\n");
                    failed++;
                }
                else
                    rTBox_main.AppendText("Enough " + color.ToString() + "\n");
            }

            if (failed > 0)
            {
                rTBox_main.AppendText("Order is not approved - Missing bricks\n");
                _orderApproved = false;
                lbl_isValidated.Text = @"False";
            }
            else
            {
                rTBox_main.AppendText("Order is approved - prepping for assembly\n");
                _orderApproved = true;
                lbl_isValidated.Text = @"True";
            }

            SortedList<double, Brick> testList = DistanceSortedList(_availibleBricks, new Point(0, 0));
            
            foreach(var x in testList)
            {
                rTBox_main.AppendText("Distance (Key): " + x.Key + "Brick: " + x.Value + "\n");
            }
        }

        private void btn_calibrate_Click(object sender, EventArgs e)
        {
            using (var calibrate = new Calibrator())
            {
                var result = calibrate.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _cameraMatrix = calibrate.CameraMatrix;
                    _distCoeffs = calibrate.DistCoeffs;
                    _isCalibrated = true;
                    calibrate.Close();

                }
            }

        }

        #endregion

        private void img_camfeed_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int mouseX = (int) (e.Location.X/img_camfeed.ZoomScale);
            int mouseY = (int) (e.Location.Y/img_camfeed.ZoomScale);
            int horizontalScroll = img_camfeed.HorizontalScrollBar.Visible
                ? (int) img_camfeed.HorizontalScrollBar.Value
                : 0;
            int verticalScroll = img_camfeed.VerticalScrollBar.Visible ? (int) img_camfeed.VerticalScrollBar.Value : 0;

            int x, y;
            x = mouseX + horizontalScroll;
            y = mouseY + verticalScroll;

            ScreenToWorld_Mapping(x, y);
        }

        private void img_camfeed_MouseMove(object sender, MouseEventArgs e)
        {
            offsetX = (int) (e.Location.X/img_camfeed.ZoomScale);
            offsetY = (int) (e.Location.Y/img_camfeed.ZoomScale);
            horizontalScrollBarValue = img_camfeed.HorizontalScrollBar.Visible
                ? (int) img_camfeed.HorizontalScrollBar.Value
                : 0;
            verticalScrollBarValue = img_camfeed.VerticalScrollBar.Visible
                ? (int) img_camfeed.VerticalScrollBar.Value
                : 0;
            txt_coordinates.Text = Convert.ToString(offsetX + horizontalScrollBarValue) + "." +
                                   Convert.ToString(offsetY + verticalScrollBarValue + "  ImgSize: " + frame.Size);
        }

        private void ScreenToWorld_Mapping(int x, int y)
        {
            double _x = -337.8 - (x*0.86);
            double _y = 533.8 - (y* 0.86);

            RobotMoveJoint(_y, _x, 0, -165, 0, 90, 200);
        }

        private Point WorldToScreen_Mapping(List<double> pos)
        {
            Point imgCoord = new Point();
            imgCoord.X = (ushort)((pos.ElementAt(1) - (-334)) * 1.163);
            imgCoord.Y = (ushort)((pos.ElementAt(0) - 534) * 1.163);

            return imgCoord;
        }

        private SortedList<double, Brick> DistanceSortedList(List<Brick> brickList, Point robotPos)
        {
            SortedList<double, Brick> sortedList = new SortedList<double, Brick>();
            double distance;

            foreach(var brick in brickList)
            {
                distance = DistanceBetweenPoints(brick.Position, robotPos);
                sortedList.Add(distance, brick);
            }
            return sortedList;
        }

        private double DistanceBetweenPoints(Point x, Point y)
        {
            double distance = 0;

            distance = Math.Sqrt(Math.Pow(y.X - x.X, 2) + Math.Pow(y.Y - x.Y, 2));

            return distance; 
        }

        private void ScreenToWorld(int x, int y)
        {

        }

        private void ReleaseData()
        {
            if (_capture != null)
                _capture.Dispose();
        }

        void colorFilter(Mat frameHSV, Color color, float minHue, float maxHue, float minSat, float maxSat, float minVal, float maxVal, bool red)
        {
            Mat element = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(7, 7), new Point(3, 3));

            Image<Hsv, Byte> frameHSV_3 = frameHSV.ToImage<Hsv, Byte>();
            Image<Gray, Byte>[] channels = frameHSV_3.Split();
            Image<Gray, Byte> imghue = channels[0];
            Image<Gray, Byte> imgsat = channels[1];
            Image<Gray, Byte> imgval = channels[2];

            double[] min, max;
            Point[] minLocation, maxLocation;

            if (red == true)
            {
                Image<Gray, Byte> aux = imghue.InRange(new Gray(minHue), new Gray(maxHue));
                imghue = imghue.InRange(new Gray(180 - maxHue), new Gray(180));
                imghue = imghue.Or(aux);
            }
            else
            {
                imghue = imghue.InRange(new Gray(minHue), new Gray(maxHue));
            }

            imgsat = imgsat.InRange(new Gray(minSat), new Gray(maxSat));
            imgval = imgval.InRange(new Gray(minVal), new Gray(maxVal));
            imghue = imghue.And(imgsat);
            imghue = imghue.And(imgval);
            imghue = imghue.MorphologyEx(MorphOp.Close, element, new Point(3, 3), 3, BorderType.Default,
                new MCvScalar(1));
            imghue.MinMax(out min, out max, out minLocation, out maxLocation);
            imghue = (imghue/max[0])*255;


            CvInvoke.NamedWindow("Some window " + color.ToString(), NamedWindowType.AutoSize);
            CvInvoke.Imshow("Some window " + color.ToString(), imghue);

            blobAnalysis(imghue.Mat, this.frameHSV, color);
        }

        void blobAnalysis(Mat binaryIm, Mat frameHSV, Color color)
        {
            int largest_area = 0;
            int largest_contour_index = 0;
            Rectangle bounding_rect = new Rectangle();
            Rectangle bounding_rectDef = new Rectangle();

            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            Mat hierarchy = new Mat();

            Mat conBin = binaryIm.Clone();
            CvInvoke.FindContours(conBin, contours, hierarchy, RetrType.Ccomp, ChainApproxMethod.ChainApproxSimple);

            for (int i = 0; i < contours.Size; i++) // iterate through each contour.
            {
                double a = CvInvoke.ContourArea(contours[i], false); //  Find the area of contour
                bounding_rect = CvInvoke.BoundingRectangle(contours[i]);
                int totElements = bounding_rect.Width*bounding_rect.Height;
                double perc = CvInvoke.Sum(new Mat(binaryIm, bounding_rect)).V0 / totElements *0.3921;
                double rectRatio = ((double)bounding_rect.Width / (double)bounding_rect.Height) * 100;



                //txt_algorithmoutput.Text = perc + " ; " + totElements + " ; " + a;

                if (perc > 45 && totElements > 1000 && totElements < 3000 && (rectRatio > 75 && rectRatio < 125))
                {

                    CvInvoke.Rectangle(frameHSV, bounding_rect, new MCvScalar(0, 0, 0), 2, LineType.EightConnected, 0);
                    Point center = new Point(bounding_rect.X +(bounding_rect.Width/2),bounding_rect.Y+(bounding_rect.Height/2));
                    int minX = 10000;
                    int minY = 10000;
                    Point coord1 = new Point();
                    Point coord2 = new Point();

                    for (int j = 0; j < contours[i].Size; j++)
                    {
                        if (contours[i][j].X < minX)
                        {
                            minX = contours[i][j].X;
                            coord1 = contours[i][j];
                        }
                        if(contours[i][j].Y < minY)
                        {
                            minY = contours[i][j].Y;
                            coord2 = contours[i][j];
                        }
                    }
                    CvInvoke.Line(frameHSV, coord1, new Point(coord1.X, coord2.Y), new MCvScalar(255, 255, 255), 2, LineType.AntiAlias, 0);
                    CvInvoke.Line(frameHSV, coord1, coord2, new MCvScalar(255, 255, 255), 2, LineType.AntiAlias, 0);

                    Point slopeA  = new Point(coord1.X-coord1.X, coord2.Y-coord1.Y);
                    Point slopeB = new Point(coord2.X-coord1.X, coord2.Y-coord1.Y);

                    double angle = Math.Atan2(slopeB.X, slopeB.Y) - Math.Atan2(slopeA.X, slopeA.Y);
                    angle = angle*(180/Math.PI);

                    bounding_rectDef = CvInvoke.BoundingRectangle(contours[i]);

                    _availibleBricks.Add(new Brick(color, center, angle));
                    CvInvoke.NamedWindow("Bounding box and angle " + color.ToString(), NamedWindowType.AutoSize);
                    CvInvoke.Imshow("Bounding box and angle " + color.ToString(), frameHSV);
                }
            
            }

            

        }
    }
}
