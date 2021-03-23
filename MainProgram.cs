using System.Threading.Tasks;
using Tran_Duc_Anh_CSharpFundamentals_Day2.DigitalClock;
using Tran_Duc_Anh_CSharpFundamentals_Day2.PrimeCalculator;

namespace Tran_Duc_Anh_CSharpFundamentals_Day2
{
    public class MainProgram
    {
        public static async Task Main(string[] args)
        {
            // DigitalClockProgram.Run();
            await PrimeCalculatorProgram.Run();
        }
    }
}