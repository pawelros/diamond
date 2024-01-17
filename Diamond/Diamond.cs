using System;
namespace Diamond
{
    public class Diamond
    {
        private readonly char _midpointChar;

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

        public Diamond(char midpointChar)
        {
            if (!char.IsLetter(char.ToUpper(midpointChar)))
            {
                throw new ArgumentException("Invalid input. Midpoint character must be a letter.");
            }

            this._midpointChar = char.ToUpper(midpointChar);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

