using System;
using System.Windows.Forms;
//using System.IO;
using System.IO.Ports;
using System.Threading;
using ViconDataStreamSDK.DotNET;

namespace Telega_new_V2._1_Vicon_Tracking
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort = new SerialPort();
        private Client client;
        private Thread trackThread, driveThread;
        private double xActual, yActual, xTarget, yTarget;
        private double[] rotation = new double[4];
        //private string rotationResult = "";
        private readonly string newLine = string.Format(Environment.NewLine + ">> ");
        private bool isStopped, isRotationComplete;

        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            portName.Items.AddRange(SerialPort.GetPortNames());
            if (portName.Items.Count > 1)
                portName.Text = portName.Items[1].ToString();
            else if (portName.Items.Count == 1)
                portName.Text = portName.Items[0].ToString();
            baudRate.Text = "9600";
            if (serialPort.IsOpen)
                serialPort.Close();
            status.Text = "Disconnected";

            xTargetBox.Text = "0";
            yTargetBox.Text = "0";
            speedValueMain.Text = "40";
            modeRadioButton1.Checked = true;
            angleManual.Text = angleAuto.Text = "90";
            speedValue1.Text = speedValue4.Text = "40";
            speedValue2.Text = speedValue3.Text = "-40";

            isStopped = isRotationComplete = false;

            logBox.Text = string.Format(">> Log started @ {0}" + newLine, DateTime.Now.ToString());

            trackThread = driveThread = null;
            trackThread = new Thread(GetMotionCapture);
            driveThread = new Thread(SetSpeed);

            client = null;
            client = new Client();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (connectButton.Text == "Connect")
            {
                status.Text = "Connecting...";
                status.Update();
                serialPort.PortName = portName.Text;
                serialPort.BaudRate = Convert.ToInt32(baudRate.Text);
                serialPort.ReadTimeout = 500;
                serialPort.WriteTimeout = 500;
                try
                {
                    serialPort.Open();
                }
                catch
                {
                    status.Text = "Error";
                    return;
                }
                status.Text = "OK";
                connectButton.Text = "Disconnect";
            }
            else
            {
                status.Text = "Disconnected";
                connectButton.Text = "Connect";
                try
                {
                    serialPort.Close();
                }
                catch
                {
                    return;
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            portName.Items.Clear();
            portName.Items.AddRange(SerialPort.GetPortNames());
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            byte[] dir = { 1, 1, 1, 1 };
            int[] sp = {Convert.ToInt32(speedValue1.Text),
                        Convert.ToInt32(speedValue2.Text),
                        Convert.ToInt32(speedValue3.Text),
                        Convert.ToInt32(speedValue4.Text)};
            for (int i = 0; i < 4; i++)
            {
                if (sp[i] < 0)
                {
                    dir[i] = 2;
                    sp[i] = -sp[i];
                }
            }
            CommandSet(2, 125, dir[0], sp[0], dir[1], sp[1], dir[2], sp[2], dir[3], sp[3], 1);
        }

        private void BackwardButton_Click(object sender, EventArgs e)
        {
            byte[] dir = { 2, 2, 2, 2 };
            int[] sp = {Convert.ToInt32(speedValue1.Text),
                        Convert.ToInt32(speedValue2.Text),
                        Convert.ToInt32(speedValue3.Text),
                        Convert.ToInt32(speedValue4.Text)};
            for (int i = 0; i < 4; i++)
            {
                if (sp[i] < 0)
                {
                    dir[i] = 1;
                    sp[i] = -sp[i];
                }
            }
            CommandSet(2, 125, dir[0], sp[0], dir[1], sp[1], dir[2], sp[2], dir[3], sp[3], 1);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            CommandSet(2, 125, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        }

        private void TrackButton_Click(object sender, EventArgs e)
        {
            if (trackButton.Text == "Track")
            {
                if (serialPort.IsOpen)
                {
                    for (byte i = 0; i < 5; i++)
                    {
                        Thread.Sleep(1000);
                        logBox.Text += string.Format("{0}" + newLine, 5 - i);
                        logBox.Update();
                    }
                    trackButton.Text = "Stop Tracking";
                    trackButton.Update();
                    Thread.Sleep(0);
                    logBox.Text += "Connecting ";
                    logBox.Update();
                    while (!client.IsConnected().Connected)
                    {
                        client.Connect("localhost:801");
                        logBox.Text += ". ";
                        logBox.Update();
                        Thread.Sleep(200);
                    }
                    logBox.Text += newLine + "Connected" + newLine;
                    logBox.Update();
                    client.EnableSegmentData();
                    client.SetStreamMode(StreamMode.ClientPull);
                    client.SetAxisMapping(Direction.Forward,
                                             Direction.Left,
                                             Direction.Up);
                    Output_GetAxisMapping output_GetAxisMapping = client.GetAxisMapping();
                    Output_GetVersion output_GetVersion = client.GetVersion();

                    try
                    {
                        trackThread.Start();
                    }
                    catch
                    {
                        MessageBox.Show("Unable to start new thread! Please restart the app.", "Error");
                    }
                    logBox.Text += "\"track\" thread started" + newLine;
                    logBox.Update();
                }
                else
                {
                    status.Text = "Disconnected";
                    MessageBox.Show("Serial Port connection required.", "Warning");
                }
            }
            else
            {
                if (!driveThread.IsAlive)
                {
                    client.Disconnect();
                    trackButton.Text = "Track";
                    trackButton.Update();
                }
                else
                {
                    MessageBox.Show("\"Drive\" thread still running!", "Warning");
                }
            }
            Thread.Sleep(0);
        }

        private void DriveButton_Click(object sender, EventArgs e)
        {
            if (driveButton.Text == "Drive")
            {
                driveButton.Text = "Stop Driving";
                driveButton.Update();
                xTarget = Convert.ToDouble(xTargetBox.Text);
                yTarget = Convert.ToDouble(yTargetBox.Text);
                try
                {
                    driveThread.Start();
                }
                catch
                {
                    MessageBox.Show("Unable to start new thread! Please restart the app.", "Error");
                }
                logBox.Text += "\"drive\" thread started" + newLine;
                logBox.Update();
            }
            else
            {
                driveButton.Text = "Drive";
                driveButton.Update();
            }
            Thread.Sleep(0);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            trackThread = null;
            driveThread = null;
            client = null;
            serialPort = null;
            /*logBox.Text += string.Format(newLine + ">> Log stopped @ {0}", DateTime.Now.ToString());
            var file = "log.txt";
            for (var i = 0; File.Exists(file); i++)
            {
                file = "log" + i.ToString() + ".txt";
            }
            File.AppendAllText(file, logBox.Text);*/
        }

        private void CommandSet(byte a0, byte a1, byte dir1, int speed1, byte dir2, int speed2, byte dir3, int speed3, byte dir4, int speed4, byte move)
        {
            byte[] Command = new byte[15];

            Command[0] = a0;
            Command[1] = a1;
            Command[2] = dir1;
            Command[3] = (byte)(speed1 >> 8);
            Command[4] = (byte)(speed1 & 0xff);
            Command[5] = dir2;
            Command[6] = (byte)(speed2 >> 8);
            Command[7] = (byte)(speed2 & 0xff);
            Command[8] = dir3;
            Command[9] = (byte)(speed3 >> 8);
            Command[10] = (byte)(speed3 & 0xff);
            Command[11] = dir4;
            Command[12] = (byte)(speed4 >> 8);
            Command[13] = (byte)(speed4 & 0xff);
            Command[14] = move;

            SendRF(Command);
        }

        private void SendRF(byte[] command)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Write(command, 0, command.Length);
                    Thread.Sleep(10);
                }
                catch
                {
                    MessageBox.Show("Robot was disconnected", "Error");
                    return;
                }
            }
            else
            {
                status.Text = "Disconnected";
            }
        }

        private void GetMotionCapture()
        {
            while (trackButton.Text == "Stop Tracking")
            {
                while (client.GetFrame().Result != Result.Success)
                {
                    Thread.Sleep(200);
                }
                string SubjectName = client.GetSubjectName(0).SubjectName;
                string SegmentName = client.GetSegmentName(SubjectName, 0).SegmentName;
                Output_GetSegmentGlobalTranslation _Output_GetSegmentGlobalTranslation =
                  client.GetSegmentGlobalTranslation(SubjectName, SegmentName);
                Output_GetSegmentGlobalRotationMatrix _Output_GetSegmentGlobalRotationMatrix =
                    client.GetSegmentGlobalRotationMatrix(SubjectName, SegmentName);
                if (!_Output_GetSegmentGlobalTranslation.Occluded)
                {
                    xActual = _Output_GetSegmentGlobalTranslation.Translation[0];
                    yActual = _Output_GetSegmentGlobalTranslation.Translation[1];
                    rotation[0] = _Output_GetSegmentGlobalRotationMatrix.Rotation[0];
                    rotation[1] = _Output_GetSegmentGlobalRotationMatrix.Rotation[1];
                    rotation[2] = _Output_GetSegmentGlobalRotationMatrix.Rotation[3];
                    rotation[3] = _Output_GetSegmentGlobalRotationMatrix.Rotation[4];
                }
                else
                {
                    continue;
                }
            }
        }

        private void SetSpeed()
        {
            while (driveButton.Text == "Stop Driving" && !isStopped)
            {
                int speed = Convert.ToInt32(speedValue1.Text);
                byte[] dir = { 1, 1, 1, 1 };
                double globalAngle = (Math.Atan2(Math.Abs(rotation[0]), Math.Abs(rotation[1])) + (Math.Atan2(Math.Abs(rotation[3]), Math.Abs(rotation[2])))) / (2 * Math.PI / 180);
                if (rotation[0] > 0 && rotation[1] > 0 && rotation[2] < 0 && rotation[3] > 0) { }
                else if (rotation[0] < 0 && rotation[1] > 0 && rotation[2] < 0 && rotation[3] < 0)
                    globalAngle = 360 - globalAngle;
                else if (rotation[0] < 0 && rotation[1] < 0 && rotation[2] > 0 && rotation[3] < 0)
                    globalAngle = 180 + globalAngle;
                else if (rotation[0] > 0 && rotation[1] < 0 && rotation[2] > 0 && rotation[3] > 0)
                    globalAngle = 180 - globalAngle;
                else
                {
                    MessageBox.Show("\"Rotation\" array is probably broken.", "Error");
                    return;
                }

                if (Math.Abs(xActual - xTarget) < 20 && Math.Abs(yActual - yTarget) < 20)
                {
                    CommandSet(2, 125, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    Thread.Sleep(100);
                    isStopped = true;
                    return;
                }
                else
                {
                    var temp = Math.Atan(Math.Abs(yActual - yTarget) / Math.Abs(xActual - xTarget));
                    double localAngle = temp * 180 / Math.PI;

                    if (yActual - yTarget > 0 && xActual - xTarget > 0)
                        localAngle += 180;
                    else if (yActual - yTarget > 0 && xActual - xTarget < 0)
                        localAngle = 360 - localAngle;
                    else if (yActual - yTarget < 0 && xActual - xTarget > 0)
                        localAngle = 180 - localAngle;

                    if (modeRadioButton1.Checked)
                    {
                        if (!isRotationComplete)
                        {
                            if (Math.Abs(globalAngle - localAngle) > 50)
                            {
                                CommandSet(2, 125, 1, speed, 2, speed, 1, speed, 2, speed, 1);
                            }
                            else if (Math.Abs(globalAngle - localAngle) > 30)
                            {
                                int LocalSpeed = (int)(speed * 0.66);
                                CommandSet(2, 125, 1, LocalSpeed, 2, LocalSpeed, 1, LocalSpeed, 2, LocalSpeed, 1);
                            }
                            else if (Math.Abs(globalAngle - localAngle) > 6.3)
                            {
                                int LocalSpeed = (int)(speed * 0.35);
                                CommandSet(2, 125, 1, LocalSpeed, 2, LocalSpeed, 1, LocalSpeed, 2, LocalSpeed, 1);
                            }
                            else
                            {
                                Thread.Sleep(2000);
                                isRotationComplete = true;
                            }
                        }
                        else
                        {
                            if (Math.Abs(xActual - xTarget) < 50 && Math.Abs(yActual - yTarget) < 50)
                            {
                                CommandSet(2, 125, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                                Thread.Sleep(100);
                                isStopped = true;
                                return;
                            }
                            else
                            {
                                var tmpAngle = (90 + (globalAngle - localAngle)) * Math.PI / 180;
                                int[] sp = {(int)(-speed * Math.Cos(tmpAngle) - speed * Math.Sin(tmpAngle)),
                                        (int)(-speed * Math.Cos(tmpAngle) + speed * Math.Sin(tmpAngle)),
                                        (int)( speed * Math.Cos(tmpAngle) + speed * Math.Sin(tmpAngle)),
                                        (int)( speed * Math.Cos(tmpAngle) - speed * Math.Sin(tmpAngle))};
                                for (int i = 0; i < 4; i++)
                                {
                                    if (sp[i] < 0)
                                    {
                                        dir[i] = 2;
                                        sp[i] = -sp[i];
                                    }
                                }
                                CommandSet(2, 125, dir[0], sp[0], dir[1], sp[1], dir[2], sp[2], dir[3], sp[3], 1);
                            }
                        }
                    }
                    else if (modeRadioButton2.Checked)
                    {
                        if (yActual - yTarget > 20)
                        {
                            double tmp = (xTarget - xActual) / (yActual - yTarget);
                            localAngle += (int)(Math.Atan(tmp));
                        }
                        else if (yActual - yTarget < -20)
                        {
                            double tmp = (xTarget - xActual) / (yTarget - yActual);
                            localAngle -= (int)(Math.Atan(tmp));
                        }

                        int[] sp = {(int)(-speed * Math.Cos(localAngle) - speed * Math.Sin(localAngle)),
                                    (int)(-speed * Math.Cos(localAngle) + speed * Math.Sin(localAngle)),
                                    (int)( speed * Math.Cos(localAngle) + speed * Math.Sin(localAngle)),
                                    (int)( speed * Math.Cos(localAngle) - speed * Math.Sin(localAngle))};
                        for (int i = 0; i < 4; i++)
                        {
                            if (sp[i] < 0)
                            {
                                dir[i] = 2;
                                sp[i] = -sp[i];
                            }
                        }

                        CommandSet(2, 125, dir[0], sp[0], dir[1], sp[1], dir[2], sp[2], dir[3], sp[3], 1);
                    }
                    Thread.Sleep(0);
                }
            }
        }
    }
}
