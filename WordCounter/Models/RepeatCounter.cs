using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _targetWord;
        private string _searchPhrase;
        private List<string> _searchList = new List<string>() { };
        private int _matches;

        public string GetTargetWord()
        {
            return _targetWord;
        }

        public void SetTargetWord(string targetWord)
        {
            _targetWord = targetWord;
        }

        public bool CheckTargetWordForPunctuation()
        {
            foreach(char letter in _targetWord)
            {
                if(Char.IsPunctuation(letter))
                {
                    return false;
                }
            }
            return true;
        }

        public void SetTargetWordLowerCase()
        {
            if (this.CheckTargetWordForPunctuation())
            {
                _targetWord = _targetWord.ToLower();
            }
        }

        public void SetSearchPhrase(string searchPhrase)
        {
            _searchPhrase = searchPhrase;
        }

        public string GetSearchPhrase()
        {
            return _searchPhrase;
        }
    }
}
