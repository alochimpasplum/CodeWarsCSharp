/*
 * https://www.codewars.com/kata/554a44516729e4d80b000012?utm_source=newsletter
 */
namespace CodeWars.kiu6
{
    public static class BuyingACar
    {
        public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingPerMonth, double percentLossByMonth)
        {
            double loss = 0, percent = percentLossByMonth, priceOld = startPriceOld, priceNew = startPriceNew;
            int month = 0, saving = 0;
            int[] result = new int[2];

            loss = saving + priceOld - priceNew;
            while (loss < 0)
            {
                month++;
                saving += savingPerMonth;

                if (month % 2 == 0)
                    percent += 0.5;

                priceOld -= (percent / 100) * priceOld;
                priceNew -= (percent / 100) * priceNew;

                loss = saving + priceOld - priceNew;
                //Console.WriteLine($"month {month}, saving {saving}, priceold {priceOld}, pricenew {priceNew}, loss {loss}, percent {percent}");
            }

            result[0] = month;
            result[1] = (int)System.Math.Round(loss);

            return result;
        }
    }
}
