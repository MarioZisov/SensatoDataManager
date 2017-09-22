using MetroFramework;
using MetroFramework.Controls;
using SensatoClient.Exceptions;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensatoClient.Utilities
{
    public class CommandReader
    {
        private byte[] data;
        private SerialPort port;
        private StringBuilder commandResult;

        public void OpenPort()
        {
            string[] portsNames = SerialPort.GetPortNames();
            if (portsNames.Length > 1)
                throw new MoreThenOnePortFoundException();

            this.port = new SerialPort(portsNames[0], 19200, Parity.None, 8, StopBits.One);
            try
            {
                this.port.Open();
            }
            catch (Exception)
            {
                throw new NoPortFoundException();
            }
        }

        public string ReadCommand(string command)
        {
            this.commandResult = new StringBuilder();

            var commandBytes = Encoding.ASCII.GetBytes(command);

            for (int i = 0; i < commandBytes.Length; i++)
            {
                port.Write(commandBytes, i, 1);
                Thread.Sleep(1);
            }

            data = new byte[port.BytesToRead];
            Thread.Sleep(100);

            int @byte;

            string bytesCol = "";
            string charCol = "";

            while (true)
            {
                if (port.BytesToRead == 0)
                {
                    Thread.Sleep(100);
                    if (port.BytesToRead == 0)
                    {
                        break;
                    }
                }

                @byte = port.ReadByte();
                bytesCol += @byte + ",";
                charCol += (char)@byte;
                this.commandResult.Append((char)@byte);
            }

            this.port.Close();
            return this.commandResult.ToString();
        }
    }
}