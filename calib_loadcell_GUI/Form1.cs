using System.IO.Ports;
using System.Windows.Forms;

namespace calib_loadcell_GUI
{
    public partial class Form1 : Form
    {
        private SerialPort serCOM;  // Khai bao cong COM

        public Form1()
        {
            InitializeComponent();
            string[] Baudrate = { "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "56000", "57600", "115200" };
            cboBaud.Items.AddRange(Baudrate);
            serCOM = new SerialPort();  // KKhoi tao Serial Port
            string[] cmds = { "01", "02", "03" };
            cboCMD.Items.AddRange(cmds);
            string[] lens = { "01", "02", "04", "08" };
            cboLEN.Items.AddRange(lens);
            Control.CheckForIllegalCrossThreadCalls = false;
            serCOM.DataReceived += serCOM_DataReceived;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCOM.DataSource = SerialPort.GetPortNames();
            btnExit.BackColor = Color.Gray;
            btn_Con_Dis.BackColor = Color.Green;
            btnSend.BackColor = Color.Blue;
        }

        private void btn_Con_Dis_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                serCOM.PortName = cboCOM.Text;
                serCOM.BaudRate = Convert.ToInt32(cboBaud.Text);
                serCOM.Open();
                btn_Con_Dis.Text = "Disconnect";
                btn_Con_Dis.BackColor = Color.Red;
            }
            else if (serCOM.IsOpen)
            {
                serCOM.Close();
                btn_Con_Dis.Text = "Connect";
                btn_Con_Dis.BackColor = Color.Green;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private byte CalcCRC(byte[] data)
        {
            byte crc = 0x00;
            foreach (byte b in data)
            {
                crc ^= b;  // XOR từng byte
            }
            return crc;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            /*
             cmd = 01: Gửi yêu cầu calib offset
             cmd = 02: Gửi giá trị vật đã biết và calib theo tỷ lệ
             cmd = 03: Bắt đầu calib lại (reset vdk)
             */
            if(serCOM.IsOpen)
            {
                // Lấy cmd từ cboCMD
                string cmdString = cboCMD.Text.Trim();
                byte cmd = Convert.ToByte(cmdString, 16);

                // Lấy data length từ cboLEN
                string lenString = cboLEN.Text.Trim();
                byte len = Convert.ToByte(lenString, 16);

                // Lấy data cần gửi
                string dataString = tboDATA.Text.Trim();

                // Kiểm tra xem tboDATA có dữ liệu không
                if (string.IsNullOrEmpty(dataString))
                {
                    MessageBox.Show("Hãy nhập dữ liệu.");
                    return;
                }
                byte[] data = new byte[0]; // Khởi tạo giá trị đầu
                // Chuyển đổi dữ liệu từ float đọc được là string vào byte array
                try
                {
                    float floatValue = float.Parse(dataString); // Chuyển chuỗi sang float
                    data = BitConverter.GetBytes(floatValue); // float -> 4 byte

                    // Nếu cần đảo byte theo chuẩn thiết bị (little/big endian), có thể:
                    // Array.Reverse(bytes);

                    // Xuất kết quả ra textbox hoặc debug
                    string hexResult = string.Join(" ", data.Select(b => b.ToString("X2")));
                    MessageBox.Show("Byte array (hex): " + hexResult);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chuyển đổi: " + ex.Message);
                }

                // Tạo frame
                byte[] frame = new byte[5 + data.Length];  // Frame bao gồm header, cmd, data, CRC, footer
                frame[0] = 0xFF;    // Byte đầu tiên là 0xFF
                frame[1] = cmd;     // Byte thứ 2 là cmd
                frame[2] = len;     // Byte thứ 3 là len (bao gồm cmd và data)
                Array.Copy(data, 0, frame, 3, data.Length);  // Sao chép data vào frame
                frame[frame.Length - 2] = CalcCRC(frame.Skip(1).Take(frame.Length - 3).ToArray());  // Tính CRC (excl. 0xFF và footer)
                frame[frame.Length - 1] = 0xFE;    // Byte cuối cùng là 0xFE

                // Gửi frame qua SerialPort
                if (len == data.Length)
                {
                    serCOM.Write(frame, 0, frame.Length);
                    tboDataSend.AppendText($"Sent: cmd {cmd:X2}, len {len:X2}, CRC {frame[frame.Length - 2]:X2}\r\n");
                }
                else
                {
                    MessageBox.Show("Độ dài len không hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Cống COM chưa mở");
            }
        }

        private void serCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serCOM.ReadExisting();
                tboDataReceive.AppendText(data.Trim() + "\r\n");
            }
            catch (Exception ex)
            {
                tboDataReceive.Text = "Lỗi đọc dữ liệu: " + ex.Message;
            }
        }
    }
}
