using System;
namespace Lab3App
{
    using System;
    using System.Collections.Generic;

    namespace Lab3App
    {
        public class MagicWand : Tool
        {
            public MagicWand(string description) : base(description) { }


            public override void Display()
            {
                Console.WriteLine($"Magic Wand {Description} is displayed");
            }

            public override void doAction()
            {
                Console.WriteLine("Magic Wand is used");
            }
        }


    }

}