using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Utilities
{
    public class DeviceCommadsManager
    {
        private const string CheckTimeCommand = "TIME?";
        private const string SetTimeCommand = "SET{0}";
        private const string GetDataCommand = "GET{0}";
        private const string GetTodayDataCommand = "TODAY";
        private const string SetNumberCommand = "NUM{0}";
        private const string CheckNumberCommand = "NUM?";

        private CommandReader commandReader;

        public DeviceCommadsManager()
        {
            this.commandReader = new CommandReader();
        }

        public string CheckTime()
        {
            string date = this.commandReader.ReadCommand(CheckTimeCommand).Trim();
            return date;
        }

        public string SetTime(DateTime date)
        {
            string dateString = $"{date.TimeOfDay},{date.Date}";
            string command = string.Format(SetTimeCommand, dateString);
            string result = this.commandReader.ReadCommand(command).Trim();

            return result;
        }



        public bool InitilizePort()
        {
            if (this.commandReader.IsDeviceAvalible())
            {
                this.commandReader.SetPort();
                return true;
            }

            return false;
        }
    }
}
