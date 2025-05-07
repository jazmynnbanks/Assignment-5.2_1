//Given a string s consisting of words and spaces, return the length of the last word in the string. A word is a maximal substring consisting of non-space characters only.

static void LastWord()
{

    string s = "Welcome to the Jungle";
    int x = s.Length - 1; 
    int count = 0;

    while (x > 0 && s[x] == ' ')
    {
        x--;
    }

    while (x > 0 && (s[x] != ' '))
        {
        count++;
        x--;
    }
    Console.WriteLine(count);

}

LastWord();

