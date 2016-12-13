using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraceLogAsync;

namespace TraceLog
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //GeneLog.GeneLog.Log(args[0], Convert.ToInt32(args[1]), args[2]);
                LogWriter write = LogWriter.Instance;
                write.WriteToLog(args[0], Convert.ToInt32(args[1]), args[2]);
            }
            catch (Exception err)
            {
                string NameDate = DateTime.Now.ToString("yyyyMMdd");
                string Date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                using (StreamWriter writer = File.AppendText(@"C:\ProgramData\CtrlPc\LOG\TraceLog_ERREUR_" + NameDate + ".log"))
                {
                    writer.WriteLine(Date + "     " + "TraceLog.exe" + "     " + "ERREUR : " + args[0]);
                    writer.WriteLine(Date + "     " + "TraceLog.exe" + "     " + "ERREUR : " + err.Message);

                }
            }
            
        }
    }
}
