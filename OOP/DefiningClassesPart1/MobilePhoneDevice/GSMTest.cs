using System;

namespace MobilePhoneDevice
{
    class GSMTest
    {
        static void Main()
        {
            GSM[] arrayOfPhones = new GSM[3];

            Battery nokiaBattery = new Battery("BL-5K", BatteryType.LiIon, 20, 5);
            Display nokiaDisplay = new Display("320x240", 4096);
            GSM nokiaN86 = new GSM("N86 8MP", "NOKIA", 150.4m, "Lora", nokiaBattery, nokiaDisplay);

            Battery samsungBattery = new Battery("2100 mAh", BatteryType.LiIon, 25, 6);
            Display samsungDisplay = new Display("720 x 1280", 16000000);
            GSM samsungS3 = new GSM("Galaxy S3", "Samsung", 900.45m, "Nora", samsungBattery, samsungDisplay);

            Battery lgBattery = new Battery("1500 mAh", BatteryType.LiIon, 3, 2);
            Display lgDisplay = new Display("480x800", 65535);
            GSM LGOptimus = new GSM("Optimus 3D", "LG", 778.2m, "Dora", lgBattery, lgDisplay);
            
            arrayOfPhones[0] = nokiaN86;
            arrayOfPhones[1] = samsungS3;
            arrayOfPhones[2] = LGOptimus;

            foreach (var phone in arrayOfPhones)
            {
                Console.WriteLine(phone);
            }
            
            // Test the static field IPhone4S
            Console.WriteLine(GSM.IPhone4S.Manufacturer);
            Console.WriteLine(GSM.IPhone4S.Model);
            Console.WriteLine(GSM.IPhone4S.Price);
           
            Console.WriteLine();

            // Test Call History
            GSMCallHistoryTest callHistoryTest = new GSMCallHistoryTest(samsungS3);
            callHistoryTest.CallHistoryTest();
        }
    }
}
