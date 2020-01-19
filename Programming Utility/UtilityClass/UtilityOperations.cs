using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Win32;
using System.Security.Cryptography;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace bhojarajsahu88.Programming_Utility.UtilityClass
{
    static class UtilityOperations
    {
        public static int GetInputLength(string displayFormat)
        {
            try
            {
                string firstChar = displayFormat.Substring(0, 1);
                int len = 0;
                string lenChar = "";

                #region SWITCH Appproach
                switch (firstChar)
                {
                    case "X":
                    case "9":
                        if (displayFormat.Contains("("))
                        {
                            lenChar = displayFormat.Substring(displayFormat.IndexOf("("), displayFormat.Length - 1);
                            lenChar = lenChar.Substring(1, lenChar.IndexOf(")") - 1);
                            len = Convert.ToInt32(lenChar);
                        }
                        else
                            len = displayFormat.Length;
                        break;
                    default:
                        len = 10;
                        break;
                }
                #endregion

                return len;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static void ShowMessageBox(string displayText, MessageBoxIcon icon)
        {
            MessageBox.Show(displayText, "Property Generator Notifier", MessageBoxButtons.OK, icon, MessageBoxDefaultButton.Button1);
        }
        public static MySqlConnection getSqlConnection()
        {
            string connectionString = "SERVER=199.79.63.90;" + "DATABASE=jenainfo_lazzycoder;" + "UID=jenainfo_lazycod;" + "PASSWORD=N+.vJAOSXTbW;";
            MySqlConnection con = new MySqlConnection(connectionString);
            return con;
        }
        //public static string getConnectionString()
        //{
        //    string connectionString = "Data Source=;Initial Catalog=LazzyCoderDb;Integrated Security=SSPI;";
        //    return connectionString;
        //}
        public static string getConnectionString()
        {
            string connectionString = "SERVER=199.79.63.90;" + "DATABASE=jenainfo_lazzycoder;" + "UID=jenainfo_lazycod;" + "PASSWORD=N+.vJAOSXTbW;";
            return connectionString;
        }
        public static void showMessage(string text)
        {
            MessageBox.Show(text, "LazzyCoder Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }
        public static void updateRegistryValue(string userId, string password, int userKey, bool status)
        {
            RegistryKey keyValue = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\ProgrammingUtility", true);
            if (keyValue != null)
            {
                keyValue.SetValue("UserId", userId);
                keyValue.SetValue("UserKey", passwordEncrypt(userKey.ToString(), "ProgrammingUtility"));
                keyValue.SetValue("Password", passwordEncrypt(password, "ProgrammingUtility"));
                //key.SetValue("DecryptPassword", passwordDecrypt(passwordEncrypt("abc@gmail.com", "ProgrammingUtility"), "ProgrammingUtility"));
                keyValue.SetValue("LoginStatus", status);
                keyValue.Close();
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ProgrammingUtility");
                key.SetValue("UserId", userId);
                key.SetValue("UserKey", passwordEncrypt(userKey.ToString(), "ProgrammingUtility"));
                key.SetValue("Password", passwordEncrypt(password, "ProgrammingUtility"));
                //key.SetValue("DecryptPassword", passwordDecrypt(passwordEncrypt("abc@gmail.com", "ProgrammingUtility"), "ProgrammingUtility"));
                key.SetValue("LoginStatus", status);
                key.Close();
            }
        }
        public static bool checkRegistryValue()
        {
            bool status = false;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\ProgrammingUtility");
            if (key != null)
            {

                if (key != null)
                {
                    if (key.GetValue("LoginStatus").ToString() == "True")
                        status = true;
                    else
                        status = false;
                }
                else
                    status = false;
                key.Close();
            }
            else
                status = false;
            return status;
        }
        public static int getUserKey()
        {
            int userKey = 0;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\ProgrammingUtility");
            if (key != null)
            {
                userKey = Convert.ToInt32(passwordDecrypt(key.GetValue("UserKey").ToString(), "ProgrammingUtility"));
                key.Close();
            }
            else
                userKey = 0;
            return userKey;
        }
        public static string GetLocalIPAddress()
        {
            string ipAddress = "";
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        ipAddress = ip.ToString();
                    }
                }
                return ipAddress;
            }
            catch
            {
                return ipAddress;
            }
        }

        //Encrypting a string
        public static string passwordEncrypt(string inText, string key)
        {
            byte[] bytesBuff = Encoding.Unicode.GetBytes(inText);
            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes crypto = new Rfc2898DeriveBytes(key, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                aes.Key = crypto.GetBytes(32);
                aes.IV = crypto.GetBytes(16);
                using (MemoryStream mStream = new MemoryStream())
                {
                    using (CryptoStream cStream = new CryptoStream(mStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cStream.Write(bytesBuff, 0, bytesBuff.Length);
                        cStream.Close();
                    }
                    inText = Convert.ToBase64String(mStream.ToArray());
                }
            }
            return inText;
        }
        //Decrypting a string
        public static string passwordDecrypt(string cryptTxt, string key)
        {
            cryptTxt = cryptTxt.Replace(" ", "+");
            byte[] bytesBuff = Convert.FromBase64String(cryptTxt);
            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes crypto = new Rfc2898DeriveBytes(key, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                aes.Key = crypto.GetBytes(32);
                aes.IV = crypto.GetBytes(16);
                using (MemoryStream mStream = new MemoryStream())
                {
                    using (CryptoStream cStream = new CryptoStream(mStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cStream.Write(bytesBuff, 0, bytesBuff.Length);
                        cStream.Close();
                    }
                    cryptTxt = Encoding.Unicode.GetString(mStream.ToArray());
                }
            }
            return cryptTxt;
        }
    }
}
