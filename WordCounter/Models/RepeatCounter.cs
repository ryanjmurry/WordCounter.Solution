using System;
using System.Collections.Generic;
using System.Linq;

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
            _targetWord = targetWord.ToLower();
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

        public void SetSearchPhrase(string searchPhrase)
        {
            _searchPhrase = searchPhrase;
        }

        public string GetSearchPhrase()
        {
            return _searchPhrase;
        }

        public void SetSearchPhraseToLower()
        {
            _searchPhrase = this.GetSearchPhrase().ToLower();
        }

        public void SetSearchList(string searchPhrase)
        {
            this.SetSearchPhrase(searchPhrase);
            this.SetSearchPhraseToLower();
            _searchList = _searchPhrase.Split(' ').ToList();
        }

        public List<string> GetSearchList()
        {
            return _searchList;
        }

        public void IncrementMatches()
        {
            _matches++;
        }

        public int GetMatches()
        {
            return _matches;
        }

        public void SetMatches()
        {
            foreach(string testWord in _searchList)
            {
                if (testWord == _targetWord)
                {
                    this.IncrementMatches();
                }
            }
        }

        public int NumberOfMatches(string targetWord, string searchPhrase)
        {
            this.SetTargetWord(targetWord);
            this.SetSearchList(searchPhrase);
            this.SetMatches();
            return _matches;
        }
    }
}
