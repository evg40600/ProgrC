// перестановки https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=9&id_topic=123&id_problem=765

void Varianti (char[] txt, int n)
{
    char tmp_char;
    if (n<2)
        Console.WriteLine(txt);
    else
    {
        for (int i = n-1; i >= 0; i--)
        {
            tmp_char = txt[i];
            txt[i]= txt[n-1];
            txt[n-1]=tmp_char;

            Varianti(txt, n-1);

            tmp_char = txt[i];
            txt[i]= txt[n-1];
            txt[n-1]=tmp_char;
        }
    }    
}

Console.Clear();
string text = Console.ReadLine();
char[] ch = new char[text.Length];

for (int i = 0; i < text.Length; i++)
    ch[i] = text [i];

Varianti(ch, text.Length);

