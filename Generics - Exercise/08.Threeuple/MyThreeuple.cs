using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class MyThreeuple<Item1, Item2, Item3>
    {
        public MyThreeuple(Item1 firstItem, Item2 secondItem, Item3 thirdItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
            ThirdItem = thirdItem; 
        }
        public Item1 FirstItem { get; set; }

        public Item2 SecondItem { get; set; }

        public Item3 ThirdItem { get; set; }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThirdItem}";
        }
    }
}
