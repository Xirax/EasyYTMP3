using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeDownloader.Modules
{
    class ProgressAnimator
    {
        private CircularProgressBar.CircularProgressBar animatedBar;
        private ProgressBar normal;
        private bool invertedDirection = false;


        public bool PLAY = true;

        public void selectBarToAnimate(CircularProgressBar.CircularProgressBar bar)
        {
            this.animatedBar = bar;
        }

        public void normalS(ProgressBar n)
        {
            this.normal = n;
        }

        public async void animate()
        {
            while (this.PLAY)
            {

                if (this.invertedDirection && this.animatedBar.Value > 0)
                    this.animatedBar.Value -= 1;
                else
                    this.invertedDirection = !this.invertedDirection;

                if (!this.invertedDirection && this.animatedBar.Value < 100)
                    this.animatedBar.Value += 1;
                else
                    this.invertedDirection = !this.invertedDirection;


                    await Task.Delay(10);
            }
        }
    }
}
