using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Client__Server___Testy_klienta
{
    class testowy
    {
        TcpClient client = new TcpClient();
        public testowy()
        {
            client.Connect("127.0.0.1", 8843);
        }

        public void Receiver(TextBlock s)
        {
            BinaryReader reader;
            try
            {
                while ((true))
                {
                    reader = new BinaryReader(client.GetStream());
                    //MessageBox.Show(reader.ReadString());
                    string z = reader.ReadString();
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        s.Text = z;
                    });
                }
            }
            catch
            {
                client.Close();
                MessageBox.Show("rozłączono");
            }
        }

        public void Sender(string command)
        {
            try
            {
                BinaryWriter writer = new BinaryWriter(client.GetStream());
                writer.Write(command);
            }
            catch
            {
                client.Close();
                MessageBox.Show("rozłączono");
            }
        }
    }
}
