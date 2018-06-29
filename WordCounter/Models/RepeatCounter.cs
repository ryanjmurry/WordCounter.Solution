using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _targetWord;
        private string _searchPhrase;
        private int _arrayStart;
        private int _arrayEnd;
        private int _arrayRange;
        private List<string> _searchList = new List<string>() { };
        private char[] _searchArray;
        private List<string> _cleanSearchList = new List<string>() { };
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


        //**Attempted to catch edge cases but sloppy and breaking**//
        //**Looking to fix later this weekend/tonight**//

        // public void IncrementArrayStart()
        // {
        //     _arrayStart++;
        // }
        //
        // public int GetArrayStart()
        // {
        //     return _arrayStart;
        // }
        //
        // public void SetArrayEnd()
        // {
        //     _arrayEnd = _searchArray.Length - 1;
        // }
        //
        // public void ReduceArrayEnd()
        // {
        //     _arrayEnd--;
        // }
        //
        // public int GetArrayEnd()
        // {
        //     return _arrayEnd;
        // }
        //
        // public void SetArrayRange()
        // {
        //     _arrayRange = (_arrayEnd - _arrayStart) + 1;
        // }
        //
        //
        // public int GetArrayRange()
        // {
        //     return _arrayRange;
        // }
        //
        // public void ResetArrayCounters()
        // {
        //     _arrayStart = 0;
        //     _arrayEnd = 0;
        //     _arrayRange = 0;
        // }
        //
        // public char[] GetSearchArray()
        // {
        //     return _searchArray;
        // }
        //
        // public void SetCleanSearchList()
        // {
        //     foreach(string word in _searchList)
        //     {
        //         _searchArray = word.ToCharArray();
        //         this.SetArrayEnd();
        //         while(Char.IsPunctuation(_searchArray[_arrayStart]))
        //         {
        //             this.IncrementArrayStart();
        //         }
        //         while(Char.IsPunctuation(_searchArray[_arrayEnd]))
        //         {
        //             this.ReduceArrayEnd();
        //         }
        //         this.SetArrayRange();
        //         String cleanWord = new String(_searchArray, _arrayStart, _arrayEnd);
        //         _cleanSearchList.Add(cleanWord);
        //         // this.ResetArrayCounters();
        //     }
        // }
        //
        // public List<string> GetCleanSearchList()
        // {
        //     return _cleanSearchList;
        // }

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
