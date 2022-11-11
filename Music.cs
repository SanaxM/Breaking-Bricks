using System.Media;

namespace Breakout
{
    class Music
    {
        SoundPlayer Audio;
        public void MainMenu()
        {
            Audio = new SoundPlayer(Breakout.Properties.Resources.BreakoutMusic);
            Audio.PlayLooping();
        }
        public void StopMusic()
        {
            Audio.Stop();
        }
        public void LoadingMusic()
        {
            StopMusic();
            Audio = new SoundPlayer(Properties.Resources.LoadingMusic);
            Audio.PlayLooping();
        }
        public void GameMusic()
        {
            StopMusic();
            Audio = new SoundPlayer(Properties.Resources.GameMusic);
            Audio.PlayLooping();
        }
        public void LevelTwoMusic()
        {
            StopMusic();
            Audio = new SoundPlayer(Properties.Resources.Level2Music);
            Audio.PlayLooping();
        }
    }
}
