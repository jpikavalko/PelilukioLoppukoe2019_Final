using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Vaikuttavaa, jos ratkaiset nimen ja koodisi
/// suorittamatta referenssitehtävää.
/// </summary>
/// 
public class Crypting
{
    public char[] CryptedNumbers { get; set; }

    public Crypting(char a, char b, char c)
    {
        CryptedNumbers = new char[3];
        CryptedNumbers = NumberCrypting(a + b + c);
        //Debug.Log(CryptedNumbers[0] +" "+ CryptedNumbers[1]+ " "+ CryptedNumbers[2]);

    }

    public char[] NumberCrypting(int number)
    {
        char[] crypt = new char[3];

        for (int i = 0; i < crypt.Length; i++)
        {
            crypt[i] = number.ToString()[i];
        }
        
        return crypt;
    }

    public static int DoMagicToNumber(int value)
    {
        int newNumber = 101 % value;
        return newNumber;
    }
}
