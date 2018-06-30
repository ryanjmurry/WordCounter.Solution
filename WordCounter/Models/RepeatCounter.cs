using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _targetWord;
        private string _searchPhrase;
        private int _arrayStart; //possible edge case properties
        private int _arrayEnd; //possible edge case properties
        private int _arrayRange; //possible edge case properties
        private List<string> _searchList = new List<string>() { };
        private char[] _searchArray; //possible edge case properties
        private string _cleanWord;
        private List<string> _cleanSearchList = new List<string>() { }; //possible edge case properties
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
            _searchPhrase = GetSearchPhrase().ToLower();
        }

        public void SetSearchList(string searchPhrase)
        {
            SetSearchPhrase(searchPhrase);
            SetSearchPhraseToLower();
            _searchList = _searchPhrase.Split(' ').ToList();
        }

        public List<string> GetSearchList()
        {
            return _searchList;
        }


        public void SetArrayEnd(string word)
        {
            _searchArray = word.ToCharArray();
            _arrayEnd = _searchArray.Length - 1;
        }

        public int GetArrayEnd()
        {
            return _arrayEnd;
        }

        //------------Buggy Edge Case Methods-----------------//
        //-----------Program Meets Minimum Requirements----//

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
        // public void ReduceArrayEnd()
        // {
        //     _arrayEnd--;
        // }
        //
        // public void SetArrayRange()
        // {
        //     _arrayRange = (_arrayEnd - _arrayStart) + 1;
        // }
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
        //         SetArrayEnd();
        //         while(Char.IsPunctuation(_searchArray[_arrayStart]))
        //         {
        //             IncrementArrayStart();
        //         }
        //         while(Char.IsPunctuation(_searchArray[_arrayEnd]))
        //         {
        //             ReduceArrayEnd();
        //         }
        //         SetArrayRange();
        //         // _cleanWord = new String(_searchArray, _arrayStart, _arrayRange);
        //         _cleanSearchList.Add(new String(_searchArray, _arrayStart, _arrayRange));
        //         // ResetArrayCounters();
        //     }
        // }
        //
        // public List<string> GetCleanSearchList()
        // {
        //     return _cleanSearchList;
        // }

        //------------End of Buggy Edge Case Methods-----------------//

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
                    IncrementMatches();
                }
            }
        }

        public int NumberOfMatches(string targetWord, string searchPhrase)
        {
            SetTargetWord(targetWord);
            SetSearchList(searchPhrase);
            SetMatches();
            return _matches;
        }
    }
}
