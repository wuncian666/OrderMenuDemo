using System;
using 點餐.Discounts;

namespace 點餐
{
    internal class DiscountFactory
    {
        public DiscountFactory()
        { }

        public static Discount create(String discount)
        {
            Discount implDiscount = new NoDiscount();
            switch (discount)
            {
                case "咖哩飯買二送一":
                    implDiscount = new CurryDiscount();
                    break;

                case "排骨飯送可樂":
                    implDiscount = new RibsDiscount();
                    break;

                case "雞腿飯三個250":
                    implDiscount = new TripleChickenDiscount();
                    break;

                case "全場85折":
                    implDiscount = new FifteenOffDiscount();
                    break;

                case "消費滿300折50":
                    implDiscount = new Over300Discount();
                    break;

                case "套餐A-雞腿飯加點沙士100元":
                    implDiscount = new SetADiscount();
                    break;
            }
            return implDiscount;
        }
    }
}