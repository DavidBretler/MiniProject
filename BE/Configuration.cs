﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
  public   class Configuration
    {
        public static int  HostingUnitKey ;
        public static int GuestRequestKey;
        public static int HostKey;
        public static int OrderKey=0;
        public static int Commission = 10; //commission for orders
        public static int Password = 999;
        public static string MangerPassword = "9999";
        public static string SystemEmail = "israelhostingservice@gmail.com";
        public static string SystemEmailPassward = "israel0000";
        static public String getMangerPassword() { return MangerPassword; }
        static public int getPassword() { return ++Password; }
        static public double getCommission() { return Commission; }
        static public int getNewHostingUnitKey() { return ++HostingUnitKey; }//the func in adding one to the num and then returning the new num
        static public int getNewGuestRequestKey() { return ++GuestRequestKey; }//the func in adding one to the num and then returning the new num
        static public int getNewHostKey() { return ++HostKey; }//the func in adding one to the num and then returning the new num
        static public int getNewOrderKey() { return ++OrderKey; }//the func in adding one to the num and then returning the new num

    }
  
}
