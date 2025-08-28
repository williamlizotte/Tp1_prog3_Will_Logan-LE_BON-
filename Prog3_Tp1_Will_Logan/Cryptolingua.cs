using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3_Tp1_Will_Logan
{
    internal class Cryptolingua : Creature, IParlable
    {
        public Cryptolingua(int vitesse, int position_X, int position_Y, string nom) : base(vitesse, position_X, position_Y, nom)
        {

        }

        void IParlable.Parler(string message)
        {
            Console.WriteLine("Message codé : " + EncryptMessage(message));

        }

        static string EncryptMessage(string message)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string cipher = "cjdgoyhktvxfzelquapwmbsnri";

            string result = "";

            foreach (char c in message)
            {
                if (char.IsLetter(c))
                {
                    int index = alphabet.IndexOf(c);
                    result += cipher[index];
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
