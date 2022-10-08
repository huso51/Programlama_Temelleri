using System;

namespace BTKAkademi.ProgramlamaTemelleri
{
    public class VeriTurleri
    {
        public static void YerlesikVeriTurlerininAltveUstLimitleri()
        {
            // 8-bit integer
            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt limit       : {SByte.MinValue,20}");
            Console.WriteLine($"Üst limit       : {SByte.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(SByte),20}");
            Console.WriteLine();
            Console.ReadKey();

            // Unsigned 8-bit integer
            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Alt limit       : {Byte.MinValue,20}");
            Console.WriteLine($"Üst limit       : {Byte.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(Byte),20}");
            Console.WriteLine();
            Console.ReadKey();


            // Signed 16-bit integer
            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Alt limit       : {Int16.MinValue,20}");
            Console.WriteLine($"Üst limit       : {Int16.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(Int16),20}");
            Console.WriteLine();
            Console.ReadKey();

            // Unsigned 16-bit integer
            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"Alt limit       : {UInt16.MinValue,20}");
            Console.WriteLine($"Üst limit       : {UInt16.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(UInt16),20}");
            Console.WriteLine();
            Console.ReadKey();


            // Signed 32-bit integer
            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Alt limit       : {Int32.MinValue,20}");
            Console.WriteLine($"Üst limit       : {Int32.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(Int32),20}");
            Console.WriteLine();
            Console.ReadKey();

            // Signed double 64-bit 
            Console.WriteLine(nameof(Double));
            Console.WriteLine($"Alt limit       : {Double.MinValue,20}");
            Console.WriteLine($"Üst limit       : {Double.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(Double),20}");
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void BenimMetodum()
        {
            Console.WriteLine("...");
        }
    }
    
}


