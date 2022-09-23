namespace Exercises.Classes
{
    public class Television
    {

        public bool IsOn { get; private set; } = false;
        public int CurrentChannel { get; private set; } = 3;
        public int CurrentVolume { get; private set; } = 2;


        public void TurnOff()
        {
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
        }

        public void ChangeChannel(int newChannel)
        {
            if (IsOn == true)
            {
                if (newChannel >= 3 || newChannel <= 18)
                {
                    CurrentChannel = newChannel;
                }
                
            }
            
        }

        public void ChannelUp()
        {
            if (IsOn == true)
            {
                if (CurrentChannel == 18)
                {
                    CurrentChannel = 3;
                    
                }

                else if (CurrentChannel < 18)
                {
                    CurrentChannel++;
                }
                
            }
        }

        public void ChannelDown()
        {
            if (IsOn == true)
            {
                if ( CurrentChannel > 3)
                {
                    CurrentChannel--;
                }
                else if (CurrentChannel == 3)
                {
                    CurrentChannel = 18;
                }
            }
        }

        public void RaiseVolume()
        {
            if (IsOn == true)
            {
                if (CurrentVolume < 10)
                {
                    CurrentVolume++;
                }
            }
        }

        public void LowerVolume()
        {
            if (IsOn == true)
            {
                if (CurrentVolume > 0)
                {
                    CurrentVolume--;
                }
            }
        }
    }
}
