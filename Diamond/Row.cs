using System;
namespace Diamond
{
    public class Row
    {
        public char CurrentCharacter { get; set; }
        public int TotalDepth { get; set; }
        private readonly char _whitespace;

        public Row(char currentCharacter, int totalDepth, bool printWhitespace = false)
        {
            this.CurrentCharacter = currentCharacter;
            this.TotalDepth = totalDepth;
            this._whitespace = printWhitespace ? '_' : ' ';
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

