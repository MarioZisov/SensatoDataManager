namespace SensatoClient.Utilities
{
    using System;

    public class DeviceCommadsManager
    {
        private const string CheckTimeCommand = "TIME?\r\n";
        private const string SetTimeCommand = "SET{0}\r\n";
        private const string GetDataCommand = "GET{0}\r\n";
        private const string GetTodayDataCommand = "TODAY\r\n";
        private const string SetNumberCommand = "NUM{0}\r\n";
        private const string CheckNumberCommand = "NUM?\r\n";

        private CommandReader commandReader;

        public DeviceCommadsManager()
        {
            this.commandReader = new CommandReader();
            this.commandReader.OpenPort();
        }

        public string CheckTime()
        {
            string date = this.commandReader.ReadCommand(CheckTimeCommand).Trim();
            return date;

        }

        public string SetTime(DateTime date)
        {
            string dateString = date.ToString("HH:mm,dd.MM.yy");
                //$"{date.TimeOfDay.ToString("hh:mm")},{date.Date.ToString("dd.MM.yy")}";
            string command = string.Format(SetTimeCommand, dateString);
            string result = this.commandReader.ReadCommand(command).Trim();

            return result;
        }

        public string GetTodayData()
        {
            string todayData = this.commandReader.ReadCommand(GetTodayDataCommand).Trim();
            return todayData;
        }

        public string GetData(DateTime lastEntryDateTime)
        {
            var currentDate = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day - 1);
            var lastDatePossible = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, DateTime.Now.Day);
            string command;
            string result;
            if (lastEntryDateTime > lastDatePossible)
            {
                command = string.Format(GetDataCommand,
                    $"{lastEntryDateTime.Day}.{lastEntryDateTime.Month}-{currentDate.Day}.{currentDate.Month}");

                result = this.commandReader.ReadCommand(command);

                return result;
            }

            command = string.Format(GetDataCommand,
                                $"{lastDatePossible.Day}.{lastDatePossible.Month}-{currentDate.Day}.{currentDate.Month}");

            result = this.commandReader.ReadCommand(command);
            string todayData = this.commandReader.ReadCommand(GetTodayDataCommand).Trim();
            result = $"{result}{Environment.NewLine}{todayData}";

            return result;
        }

        public string SetDeviceNumber(int deviceNum)
        {
            string command = string.Format(SetNumberCommand, deviceNum.ToString().PadLeft(3,'0'));
            string result = this.commandReader.ReadCommand(command).Trim();

            return result;
        }

        public string CheckDeviceNumber()
        {
            string deviceNumber = this.commandReader.ReadCommand(CheckNumberCommand);

            return deviceNumber;
        }

        public bool InitilizePort()
        {
            if (this.commandReader.IsDeviceAvalible())
            {
                this.commandReader.OpenPort();
                return true;
            }

            return false;
        }
    }
}
