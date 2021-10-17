using System;
using System.Collections.Generic;
using System.Text;

namespace Tuples
{
    public class MyTuple<Item1, Item2>
    {

        public MyTuple(Item1 firstItem, Item2 secondItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
        }
        public  Item1 FirstItem { get; set; }

        public Item2 SecondItem { get; set; }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem}";
        }
    }
}
