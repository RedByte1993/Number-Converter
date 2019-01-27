
namespace NumberConverter
{
    public class NumberConverter
    {
        #region Fields

        private bool inputIsCorrect;
        private uint m_currentBase;
        private uint m_convertedToBase;
        private string m_currentNumber;
        private const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        #endregion

        #region Constructor

        /// <summary>
        /// This class is supposed to convert each positive integer
        /// between base 2 to 36 into the desired base in the range 2 to 36.
        /// </summary>
        /// <param name="currentNumber">The current Number as String</param>
        /// <param name="currentBase">The current Base.</param>
        /// <param name="convertedToBase">The base in which the conversion is to take place.</param>
        public NumberConverter(string currentNumber, uint currentBase = 10, uint convertedToBase = 10)
        {
           
            if (currentBase > 1 && currentBase < 37 && convertedToBase > 1 && convertedToBase < 37 && !currentNumber.Contains("-"))
            {
                m_currentBase = currentBase;
                m_convertedToBase = convertedToBase;
                CurrentNumber = currentNumber;
                inputIsCorrect = true;
            }
            
        }

        #endregion

        #region Properties

        public string CurrentNumber
        {
            get
            {
                return m_currentNumber;
            }
            set
            {
                if (!value.Contains("-"))
                {
                    m_currentNumber = value;
                    inputIsCorrect = true;
                }
                else
                {
                    inputIsCorrect = false;
                }
            }
        }

        public uint CurrentBase
        {
            get
            {
                return m_currentBase;
            }

            set
            {
                if (value > 1 || value < 37)
                {
                    m_currentBase = value;
                    inputIsCorrect = true;
                }
                else
                {
                    inputIsCorrect = false;
                }

            }
        }

        public uint ConvertedToBase
        {
            get
            {
                return m_convertedToBase;
            }

            set
            {
                if (value > 1 || value < 37)
                {
                    m_convertedToBase = value;
                    inputIsCorrect = true;
                }
                else
                {
                    inputIsCorrect = false;
                }
            }
        }

        #endregion

        #region Methodes

        /// <summary>
        /// This method calculates the current value.
        /// </summary>
        /// <param name="checkCharacter"></param>
        /// <returns></returns>
        private int GetCurrentValue(char checkCharacter)
        {
            //Check if the variable CheckCharacter is a digit

            if ((int)checkCharacter > 47 && (int)checkCharacter < 58)
            {
                return int.Parse(checkCharacter.ToString());
            }
            else
            {
                return (int)checkCharacter - 55;
            }
        }

        /// <summary>
        /// This method is responsible for the potentiation.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="exponent"></param>
        /// <returns></returns>
        private int Power(int value, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }
            else
            {
                int tempValue = value;

                for (int i = 1; i < exponent; i++)
                {
                    tempValue *= value;
                }

                return tempValue;
            }
        }

        /// <summary>
        /// This method converts any integer in the base from 2 to 36 into the base 10.
        /// </summary>
        /// <returns></returns>
        private int ConvertToDecimal()
        {
            int decimalNumber = 0;

            for (int i = 0; i < CurrentNumber.Length; i++)
            {
                int currentIndex = CurrentNumber.Length - (i + 1);
                decimalNumber += GetCurrentValue(CurrentNumber[currentIndex]) * Power((int)m_currentBase, i);
            }

            return decimalNumber;
        }

        /// <summary>
        /// This method is responsible for the conversion.
        /// </summary>
        /// <returns></returns>
        public string Convert()
        {
            string output = "";

            if (inputIsCorrect)
            {
                
                int decimalNumber = ConvertToDecimal();

                while (decimalNumber > 0)
                {
                    if (decimalNumber % m_convertedToBase > 9)
                    {
                        int currentIndex = (decimalNumber % (int)m_convertedToBase) - 10;
                        output = letters[currentIndex].ToString() + output;
                    }
                    else
                    {
                        output = (decimalNumber % m_convertedToBase).ToString() + output;
                    }

                    decimalNumber /= (int)m_convertedToBase;
                }

                inputIsCorrect = false;
                
            }

            return output;

        }

        #endregion
    }
}
