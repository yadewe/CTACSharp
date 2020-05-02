﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SwigCodeFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(AppContext.BaseDirectory, "*.cs");
            foreach (var file in files)
            {
                var text = File.ReadAllText(file);
                text = text.Replace("SWIGTYPE_p_a_51__char.getCPtr(ClientOrderNo)", "ClientOrderNo");
                text = text.Replace("SWIGTYPE_p_a_51__char.getCPtr(ClientBuyOrderNo)", "ClientBuyOrderNo");
                text = text.Replace("SWIGTYPE_p_a_51__char.getCPtr(ClientSellOrderNo)", "ClientSellOrderNo");
                text = text.Replace("SWIGTYPE_p_a_51__char.getCPtr(clientorderno)", "clientorderno");
                text = text.Replace("(ClientOrderNo == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_a_51__char(ClientOrderNo, false)", "ClientOrderNo");
                text = text.Replace("(ClientBuyOrderNo == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_a_51__char(ClientBuyOrderNo, false)", "ClientBuyOrderNo");
                text = text.Replace("(ClientSellOrderNo == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_a_51__char(ClientSellOrderNo, false)", "ClientSellOrderNo");
                text = text.Replace("(clientorderno == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_a_51__char(clientorderno, false)", "clientorderno");
                text = text.Replace("(sessionID == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_int(sessionID, false)", "out sessionID");

                text = text.Replace("SWIGTYPE_p_int.getCPtr(iResult)", "out iResult");
                File.WriteAllText(file, text);
            }

        }
    }
}