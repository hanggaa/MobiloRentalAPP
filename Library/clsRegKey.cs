using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Library
{
    public class clsRegKey
    {
        private string m_RegistryPathCurrentUser;

        public string RegistryPathCurrentUser
        {
            get { return m_RegistryPathCurrentUser; }
            set { m_RegistryPathCurrentUser = value; }
        }

        //Dapatkan Key value nya-nya
        public string getSetting(String strFile)
        {
            RegistryKey regkey = Registry.CurrentUser;
            regkey = regkey.CreateSubKey(RegistryPathCurrentUser);
            string strValue = "";
            strValue = regkey.GetValue("" + strFile + "", "").ToString();

            return strValue;
        }
        //Simpan Key value nya-nya
        public void SaveSetting(String strFile, String strValue)
        {
            RegistryKey regkey = Registry.CurrentUser;
            regkey = regkey.CreateSubKey(RegistryPathCurrentUser);
            regkey.SetValue(strFile, strValue);
        }
    }
}
    


