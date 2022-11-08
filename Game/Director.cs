using System;

namespace Jumper.Game
{
    public class Director
    {
        private bool _isPlaying = true;

        public Director()
        {}

        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        private void GetInputs()
        {}

        private void DoUpdates()
        {}

        private void DoOutputs()
        {}

    }
}