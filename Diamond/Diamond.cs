using System;
using System.Text;

namespace Diamond
{
    public class Diamond
    {
        private readonly char _midpointChar;
        private readonly bool _printWhitespace;

        public int Depth
        {
            get
            {
                int d = this._midpointChar - 'A' + 1;
                if (d > 1)
                {
                    return 2 * d - 1;
                }

                return d;
            }
        }

        public Diamond(char midpointChar, bool printWhitespace = false)
        {
            if (!char.IsLetter(char.ToUpper(midpointChar)))
            {
                throw new ArgumentException("Invalid input. Midpoint character must be a letter.");
            }

            this._midpointChar = char.ToUpper(midpointChar);
            this._printWhitespace = printWhitespace;
        }

        public override string ToString()
        {
            // _ _ A _ _
            // _ B _ B _
            // C _ _ _ C
            // _ B _ B _
            // _ _ A _ _

            // C == 3


            StringBuilder sb = new StringBuilder();

            // print the upper half of the diamond
            for (int i = 0; i <= this.Depth / 2; i++)
            {
                var row = new Row((char)('A' + i), this.Depth, this._printWhitespace);
                sb.AppendLine(row.ToString());
            }

            //print the lower half of the diamond
            for (int i = this.Depth / 2 - 1; i >= 0; i--)
            {
                var row = new Row((char)('A' + i), this.Depth, this._printWhitespace);
                sb.AppendLine(row.ToString());
            }


            return sb.ToString();
        }
    }
}

