using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp7Eigther {
    public static class Helpers {
        public static bool IsX64() {
            return System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86).Contains("x86");
        }

        public static void ParseUpdateWpOutput(string wpUpdateOutput) {
            DeviceInfo.Id = wpUpdateOutput.Split(new string[] { "Id:" }, StringSplitOptions.None)[1];
            DeviceInfo.Id = DeviceInfo.Id.Split(new string[] { "\n" }, StringSplitOptions.None)[0];
            DeviceInfo.Id = DeviceInfo.Id.Trim();

            DeviceInfo.SerialNumber = wpUpdateOutput.Split(new string[] { "SN:" }, StringSplitOptions.None)[1];
            DeviceInfo.SerialNumber = DeviceInfo.SerialNumber.Split(new string[] { "\n" }, StringSplitOptions.None)[0];
            DeviceInfo.SerialNumber = DeviceInfo.SerialNumber.Trim();

            DeviceInfo.Name = wpUpdateOutput.Split(new string[] { "Name:" }, StringSplitOptions.None)[1];
            DeviceInfo.Name = DeviceInfo.Name.Split(new string[] { "\n" }, StringSplitOptions.None)[0];
            DeviceInfo.Name = DeviceInfo.Name.Trim();

            DeviceInfo.KITLName = wpUpdateOutput.Split(new string[] { "KITLName:" }, StringSplitOptions.None)[1];
            DeviceInfo.KITLName = DeviceInfo.KITLName.Split(new string[] { "\n" }, StringSplitOptions.None)[0];
            DeviceInfo.KITLName = DeviceInfo.KITLName.Trim();

            DeviceInfo.Manufacturer = wpUpdateOutput.Split(new string[] { "Manufacturer:" }, StringSplitOptions.None)[1];
            DeviceInfo.Manufacturer = DeviceInfo.Manufacturer.Split(new string[] { "\n" }, StringSplitOptions.None)[0];
            DeviceInfo.Manufacturer = DeviceInfo.Manufacturer.Trim();

            DeviceInfo.ModelId = wpUpdateOutput.Split(new string[] { "ModelId:" }, StringSplitOptions.None)[1];
            DeviceInfo.ModelId = DeviceInfo.ModelId.Split(new string[] { "\n" }, StringSplitOptions.None)[0];
            DeviceInfo.ModelId = DeviceInfo.ModelId.Trim();

            DeviceInfo.Model = wpUpdateOutput.Split(new string[] { "Model:" }, StringSplitOptions.None)[1];
            DeviceInfo.Model = DeviceInfo.Model.Split(new string[] { "\n" }, StringSplitOptions.None)[0];
            DeviceInfo.Model = DeviceInfo.Model.Trim();

            DeviceInfo.MobileOperator = wpUpdateOutput.Split(new string[] { "MobileOperator:" }, StringSplitOptions.None)[1];
            DeviceInfo.MobileOperator = DeviceInfo.MobileOperator.Split(new string[] { "\n" }, StringSplitOptions.None)[0];
            DeviceInfo.MobileOperator = DeviceInfo.MobileOperator.Trim();

            DeviceInfo.Version = wpUpdateOutput.Split(new string[] { "Version:" }, StringSplitOptions.None)[1];
            DeviceInfo.Version = DeviceInfo.Version.Split(new string[] { "\n" }, StringSplitOptions.None)[0];
            DeviceInfo.Version = DeviceInfo.Version.Trim();

            DeviceInfo.Revision = Convert.ToInt32(DeviceInfo.Version.Split(new char[] { '.' })[2]).ToString();
        }
    }
}
