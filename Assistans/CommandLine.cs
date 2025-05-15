using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tamir.SharpSsh;

namespace MSIOFAX_Send.Assistans
{
    public static class CommandLine
    {
        public static string RunCommand(string command)
        {
            SshExec sshexec = new SshExec(Properties.Settings.Default.ServerIP, Properties.Settings.Default.RootUserName,"123456");
            sshexec.Connect(22);
            try
            {
                if (sshexec.Connected)
                {
                    return sshexec.RunCommand(command);
                }
                else return "";

            }
            catch (Exception ex)
            {

                return ex.ToString();
            }

        }
    }
}
