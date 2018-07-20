using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using canlibCLSNET;

namespace CanTest
{
    class Program
    {
        static void DisplayError(Canlib.canStatus status, String routineName)
        {
            String errText = "";
            if (status != Canlib.canStatus.canOK)
            {
                Canlib.canGetErrorText(status, out errText);
                Console.WriteLine("{2} failed: {0} = {1}", status, errText, routineName);
                Environment.Exit(0);
            }
            else
                Console.WriteLine("{0} succeeded", routineName);
        }

        static void DispalyMessage(int id, int dlc, byte[] data, int flags, long time)
        {
            if ((flags & Canlib.canMSGERR_OVERRUN) > 0)
                Console.WriteLine("****  RECEIVE OVERRUN ****");
            if ((flags & Canlib.canMSG_ERROR_FRAME) == Canlib.canMSG_ERROR_FRAME)
                Console.WriteLine("ErrorFrame                                       {0}", time);
            else
            {
                Console.Write("{0:x8} ", id);
                if ((flags & Canlib.canMSG_EXT) == Canlib.canMSG_EXT)
                    Console.Write("X");
                else
                    Console.Write(" ");
                if ((flags & Canlib.canMSG_RTR) == Canlib.canMSG_RTR)
                    Console.Write("R");
                else
                    Console.Write(" ");
                if ((flags & Canlib.canMSG_TXACK) == Canlib.canMSG_TXACK)
                    Console.Write("A");
                else
                    Console.Write(" ");
                if ((flags & Canlib.canMSG_WAKEUP) == Canlib.canMSG_WAKEUP)
                    Console.Write("W");
                else
                    Console.Write(" ");
                Console.Write("   {0xx1} ", dlc);
                for (int i = 0; i < 8; i++)
                {
                    if (i < dlc)
                        Console.Write("  {0:x2}", data[i]);
                    else
                        Console.Write("    ");
                }
                Console.WriteLine("     {0}", time);
            }
        } // end of function DisplayMessage

        static void Main(string[] args)
        {
            Canlib.canStatus status;
            int chanHandle;

            Canlib.canInitializeLibrary();
            Console.WriteLine("CAN Interface Library Initialized");

            chanHandle = Canlib.canOpenChannel(0, Canlib.canOPEN_ACCEPT_VIRTUAL);
            DisplayError((Canlib.canStatus)chanHandle, "canOpenChannel");

            status = Canlib.canSetBusParams(chanHandle, Canlib.canBITRATE_250K, 0, 0, 0, 0, 0);
            DisplayError(status, "canSetBusParams");

            status = Canlib.canBusOn(chanHandle);
            DisplayError(status, "canBusOn");

            Console.WriteLine("Press Escape Key to exit");
            Console.WriteLine("   ID    Flag DLC  Data                             Timestamp");

            bool notFinished = true;

            while (notFinished)
            {
                int id = 0;
                byte[] data = new byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
                int dlc = 0;
                int flags = 0;
                long time = 0;

                // Wait for up to 1 second to receive a CAN frame
                status = Canlib.canReadWait(chanHandle, out id, data, out dlc, out flags, out time, 1000);

                if (status == Canlib.canStatus.canOK)
                {
                    DispalyMessage(id, dlc, data, flags, time);
                }
                else if (status != Canlib.canStatus.canERR_NOMSG)
                {
                    // an error communicating with the hardware detected so shutdown
                    notFinished = false;
                    Canlib.canBusOff(chanHandle);
                    Canlib.canClose(chanHandle);
                    DisplayError(status, "canRead");
                }

                if (Console.KeyAvailable == true)
                {
                    ConsoleKeyInfo cki = new ConsoleKeyInfo();
                    cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Escape)
                        notFinished = false;
                }
            } // end if while not finished loop

            status = Canlib.canBusOff(chanHandle);
            DisplayError(status, "canBusOff");

            status = Canlib.canClose(chanHandle);
            DisplayError(status, "canClose");

        } // end of function Main
    } // end of class Program
} // end of namespace CanTest
