using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockHW
{
    class AClock:Label
    {
        private DateTime time;
        private Timer timer;

        public AClock()
        {
            Width = 250;
            Height = 250;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += TimerTick;
        }
        public void Start()
        {
            timer.Enabled = true;
        }
        public void Stop()
        {
            timer.Enabled = false;
        }
        void TimerTick(object sender,EventArgs e)
        {
            time = DateTime.Now;
            Text = time.ToString("HH:mm:ss");
        }
    }
    
}
