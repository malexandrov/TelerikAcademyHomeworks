using System;

namespace MobilePhoneDevice
{
    class GSMCallHistoryTest
    {
        private GSM phone = new GSM("Galaxy S3", "Samsung", 900.45m, "Nora");
        private Call call1 = new Call(new DateTime(2013,02,24,13,38,0), 00359884070734, 126);
        private Call call2 = new Call(new DateTime(2013, 02, 24, 15, 05, 0), 0887887887, 38);
        private Call call3 = new Call(new DateTime(2013, 02, 25, 08, 38, 0), 0898123123, 256);

        public GSMCallHistoryTest(GSM phone)
        {
            this.phone = phone;
        }

        public void CallHistoryTest()
        {
            phone.AddCall(call1);
            phone.AddCall(call2);
            phone.AddCall(call3);

            foreach (var call in phone.CallHistory)
            {
                Console.WriteLine(call);
            }
            Console.WriteLine();

            Console.WriteLine("Total price of calls: {0:0.00}", phone.CalculatePrice(0.37m)); Console.WriteLine();
            
            phone.RemoveCall(2);
            Console.WriteLine("Total price without longest call: {0:0.00}", phone.CalculatePrice(0.37m)); Console.WriteLine();
            
            phone.ClearHistory();
            foreach (var call in phone.CallHistory)
            {
                Console.WriteLine(call);
            }
        }
    }
}
