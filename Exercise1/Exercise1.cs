using System;

namespace Exercise1
{
    class Engine
    {
        private const int StateStopped = 1;
        private const int StateStarted = 2;
        public int engineState;

        public void Start()
        {
            Console.Out.WriteLine( "Start" );
            engineState = StateStarted;
        }

        public void Stop()
        {
            Console.Out.WriteLine( "Stop" );
            engineState = StateStopped;
        }

        public String GetState()
        {
            String state = null;

            if( engineState == StateStopped )
                state = "STOPPED";
            else if( engineState == stateStarted )
                state = "STARTED";

            return state;
        }
    }
}
