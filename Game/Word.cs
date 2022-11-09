using System;
using System.Collections.Generic;
using System.IO;

namespace Jumper.Game
{
    public class Word
    {
        private Random _rand = new Random();
        private List<string> _wordlist = new List<string> {"obese","gutter","bleed","captain","concept","allow","cheat","unfair","federation","thread","convict","gaffe","ego","killer","reach","thrust","dorm","gloom","accept","achievement","gradual","persist","attractive","acceptance","false","performer","element","glacier","veteran","interface","complete","broccoli","dramatic","incapable","chip","active","thanks","thaw","comment","trick","question","taste","goal","voter","orchestra","draft","apathy","exceed","bacon","manager","makeup","embox","feign","magazine","microphone","hate","iron","drawer","indulge","nervous","leader","operational","star","cable","hit","chicken","echo","absorption","desire","color-blind","nun","pot","settlement","candidate","draw","classroom","lease","path","article","large","noble","selection","ghostwriter","secretion","quotation","office","home","pity","open","if","circulation","lead","establish","discount","cereal","blue","whole","handicap","deficit","mushroom"};
        public string word;
        
        public Word()
        {}

        public string _randWord()
        {
            word = _wordlist[_rand.Next(1,51)];
            return word;
        }
    }
}