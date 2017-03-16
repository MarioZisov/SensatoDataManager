using SensatoClient.Exceptions;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SensatoClient.Utilities
{
    public class CommandReader
    {
        private const string PortName = "COM3";

        private byte[] data;
        private SerialPort port;
        private StringBuilder commandResult;

        public bool IsDeviceAvalible()
        {
            bool isAvalible = SerialPort.GetPortNames().Any(p => p == PortName);
            return isAvalible;
        }

        public void OpenPort()
        {
            this.port = new SerialPort(PortName, 19200, Parity.None, 8, StopBits.One);
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

            while (true)
            {
                if (port.BytesToRead == 0)
                {
                    Thread.Sleep(100);
                    if (port.BytesToRead == 0)
                    {
                        break;
                    }

                    //this.commandResult.Append("@");
                }

                @byte = port.ReadByte();
                this.commandResult.Append((char)@byte);
            }

            return this.commandResult.ToString();
        }
    }
}
