using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceLog
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GeneLog.GeneLog.Log(args[0], Convert.ToInt32(args[1]), args[2]);
            }
            catch (Exception err)
            {

                
            }
            
        }
    }
}
