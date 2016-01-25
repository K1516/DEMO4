using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirjahylly
{
    class Speaker
    {
        private readonly int maxvolume = 10;
        private readonly int minvolume = 0;
        private int volume;
        private readonly int onoff = 1;
        private readonly int onff1 = 0;
        private int onOFF;

        public int ONOFF
        {
            get
            {
                return onOFF;
            }
            set
            {
                if (value >= 0 && value <= 1) onOFF = value;
                else
                {
                    Console.WriteLine("Wrong value, speaker turned on! Volume set max, have fun!");
                    onOFF = 1;
                    volume = maxvolume;
                }
            }
        }
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= 10 && value >= 0) volume = value;
                else
                {
                    Console.WriteLine("Wrong volume, please try again! Volume set to 4.");
                    volume = 4;
                }
            }
        }


    }
}
