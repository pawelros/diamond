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
            int distanceFromTheEndge = (this.TotalDepth - 1) / 2 - (this.CurrentCharacter - 'A');
            int innerPadding = this.TotalDepth - distanceFromTheEndge * 2 - 2;

            if (this.isTipOfDiamond())
            {
                return $"{new string(this._whitespace, distanceFromTheEndge)}{this.CurrentCharacter}{new string(this._whitespace, distanceFromTheEndge)}";
            }

            return $"{new string(this._whitespace, distanceFromTheEndge)}{this.CurrentCharacter}{new string(this._whitespace, innerPadding)}{this.CurrentCharacter}{new string(this._whitespace, distanceFromTheEndge)}";
        }

        private bool isTipOfDiamond()
        {
            return this.CurrentCharacter == 'A';
        }
    }
}

