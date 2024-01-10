
class Program
{
    static void Main()
    {
       //ex1();
       //ex2();
       //ex3();
       // ex4();
       // ex5();
       // ex6();
       // ex7();
       // ex8();
       // ex9();
       //ex10();
       //ex11();
       //ex12();
       //ex13();
       //ex14();
       //ex15();
       //ex16();
       //ex17();
       //ex18();
       //ex19();
       //ex20();
       //ex21();

    }
    static void ex6()
    {
        Console.Write("Introduceți lungimea laturii a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Introduceți lungimea laturii b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Introduceți lungimea laturii c: ");
        double c = double.Parse(Console.ReadLine());

        if (!EsteTriunghi(a, b, c))
        {
            Console.WriteLine($"Numerele {a}, {b} si {c} NU pot reprezenta lungimile laturilor unui triunghi.");
        }
        else
        {
            Console.WriteLine($"Numerele {a}, {b} si {c} pot reprezenta lungimile laturilor unui triunghi.");
        }
    }

    private static bool EsteTriunghi(double a, double b, double c)
    {
        // Verificăm condiția de inegalitate triunghiulară
        return a + b > c && a + c > b && b + c > a;
    }

    static void ex7()
    {
        Console.Write("Introduceți valoarea lui a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Introduceți valoarea lui b: ");
        int b = int.Parse(Console.ReadLine());

        // Swap fără variabilă intermediară
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;

        Console.WriteLine($"Valorile inverse: a = {a}, b = {b}");
    }
    static void ex10()
    {
        Console.Write("Introduceți un număr întreg pozitiv: ");
        int n = int.Parse(Console.ReadLine());

        if (EstePrim(n))
        {
            Console.WriteLine($"{n} este un număr prim.");
        }
        else
        {
            Console.WriteLine($"{n} NU este un număr prim.");
        }
    }

    static bool EstePrim(int numar)
    {
        // Verificăm dacă numărul este mai mic sau egal cu 1
        if (numar <= 1)
        {
            return false;
        }

        // Parcurgem toate valorile de la 2 la radicalul din număr
        for (int i = 2; i <= Math.Sqrt(numar); i++)
        {
            // Dacă găsim un divizor, numărul nu este prim
            if (numar % i == 0)
            {
                return false;
            }
        }

        // Dacă nu am găsit divizori, numărul este prim
        return true;
    }
    static void ex8()
    {
        // Citeste valorile a si b de la utilizator
        Console.Write("Introduceti valoarea pentru a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Introduceti valoarea pentru b: ");
        int b = int.Parse(Console.ReadLine());

        // Inversarea valorilor folosind XOR
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;

        // Afisare rezultate
        Console.WriteLine("Valorile inversate: ");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        Console.ReadLine();
    }
    static void ex9()
    {
        Console.Write("Introduceti un numar: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Divizorii lui " + n + " sunt:");

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadLine();
    }
    static void ex11()
    {
        Console.Write("Introduceti un numar: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Cifrele in ordine inversa sunt: ");
        AfiseazaCifreleInvers(n);

        Console.ReadLine();
    }

    static void AfiseazaCifreleInvers(int numar)
    {
        // Converteste numarul la sir de caractere
        string numarString = numar.ToString();

        // Parcurge sirul de la sfarsit la inceput si afiseaza fiecare cifra
        for (int i = numarString.Length - 1; i >= 0; i--)
        {
            Console.Write(numarString[i]);
        }

        Console.WriteLine(); // Adauga o linie noua la final pentru formatare
    }
    static void ex12()
    {
        Console.Write("Introduceti primul capat al intervalului (a): ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al doilea capat al intervalului (b): ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Introduceti numarul (n) cu care sa fie divizibile numerele: ");
        int n = int.Parse(Console.ReadLine());

        int numarDeDivizibile = NumarDeDivizibileInInterval(a, b, n);

        Console.WriteLine($"In intervalul [{a}, {b}] exista {numarDeDivizibile} numere divizibile cu {n}.");

        Console.ReadLine();
    }

    static int NumarDeDivizibileInInterval(int a, int b, int n)
    {
        int contor = 0;

        for (int i = a; i <= b; i++)
        {
            if (i % n == 0)
            {
                contor++;
            }
        }

        return contor;
    }
    static void ex13()
    {
        Console.Write("Introduceti anul de start (y1): ");
        int y1 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti anul de sfarsit (y2): ");
        int y2 = int.Parse(Console.ReadLine());

        int numarAniBisecti = NumarAniBisectiInInterval(y1, y2);

        Console.WriteLine($"In intervalul [{y1}, {y2}] sunt {numarAniBisecti} ani bisecti.");

        Console.ReadLine();
    }

    static int NumarAniBisectiInInterval(int y1, int y2)
    {
        int contor = 0;

        for (int an = y1; an <= y2; an++)
        {
            if (EsteAnBisect(an))
            {
                contor++;
            }
        }

        return contor;
    }

    static bool EsteAnBisect(int an)
    {
        // Un an este bisect daca este divizibil cu 4,
        // dar nu este divizibil cu 100, cu exceptia cazului
        // in care este divizibil cu 400.
        return (an % 4 == 0 && an % 100 != 0) || (an % 400 == 0);
    }
    static void ex14()
    {
        Console.Write("Introduceti un numar: ");
        int n = int.Parse(Console.ReadLine());

        if (EstePalindrom(n))
        {
            Console.WriteLine($"{n} este palindrom.");
        }
        else
        {
            Console.WriteLine($"{n} nu este palindrom.");
        }

        Console.ReadLine();
    }

    static bool EstePalindrom(int numar)
    {
        int numarInitial = numar;
        int invers = 0;

        while (numar > 0)
        {
            int cifra = numar % 10;
            invers = invers * 10 + cifra;
            numar = numar / 10;
        }

        // Verifica daca numarul invers este egal cu numarul initial
        return invers == numarInitial;
    }
    static void ex15()
    {
        Console.Write("Introduceti primul numar: ");
        int numar1 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al doilea numar: ");
        int numar2 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al treilea numar: ");
        int numar3 = int.Parse(Console.ReadLine());

        AfiseazaInOrdineCrescatoare(numar1, numar2, numar3);

        Console.ReadLine();
    }

    static void AfiseazaInOrdineCrescatoare(int a, int b, int c)
    {
        int temp;

        // Sortare folosind comparatii
        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }

        if (b > c)
        {
            temp = b;
            b = c;
            c = temp;
        }

        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }

        // Afisare in ordine crescatoare
        Console.WriteLine("Numerele in ordine crescatoare sunt: " + a + ", " + b + ", " + c);
    }
    static void ex16()
    {
        Console.Write("Introduceti primul numar: ");
        int numar1 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al doilea numar: ");
        int numar2 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al treilea numar: ");
        int numar3 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al patrulea numar: ");
        int numar4 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al cincilea numar: ");
        int numar5 = int.Parse(Console.ReadLine());

        AfiseazaInOrdineCrescatoare(ref numar1, ref numar2, ref numar3, ref numar4, ref numar5);

        Console.WriteLine("Numerele in ordine crescatoare sunt: " + numar1 + ", " + numar2 + ", " + numar3 + ", " + numar4 + ", " + numar5);

        Console.ReadLine();
    }

    static void AfiseazaInOrdineCrescatoare(ref int a, ref int b, ref int c, ref int d, ref int e)
    {
        int temp;

        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }

        if (b > c)
        {
            temp = b;
            b = c;
            c = temp;
        }

        if (c > d)
        {
            temp = c;
            c = d;
            d = temp;
        }

        if (d > e)
        {
            temp = d;
            d = e;
            e = temp;
        }

        // Acum, a, b, c, d și e sunt în ordine crescătoare
    }
    static void ex17()
    {
        Console.Write("Introduceti primul numar: ");
        int numar1 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al doilea numar: ");
        int numar2 = int.Parse(Console.ReadLine());

        int cmmd = CalculareCMMD(numar1, numar2);
        int cmm = CalculareCMM(numar1, numar2, cmmd);

        Console.WriteLine($"Cel mai mare divizor comun (CMMD) al {numar1} si {numar2} este {cmmd}.");
        Console.WriteLine($"Cel mai mic multiplu comun (CMM) al {numar1} si {numar2} este {cmm}.");

        Console.ReadLine();
    }

    static int CalculareCMMD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int CalculareCMM(int a, int b, int cmmd)
    {
        // Utilizează formula: CMM(a, b) = (|a * b|) / CMMD(a, b)
        return Math.Abs(a * b) / cmmd;
    }
    static void ex18()
    {
        Console.Write("Introduceti un numar: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write($"Descompunerea in factori primi ai numarului {n} este: ");
        AfiseazaDescompunereaInFactoriPrimi(n);

        Console.ReadLine();
    }

    static void AfiseazaDescompunereaInFactoriPrimi(int numar)
    {
        for (int i = 2; i <= numar; i++)
        {
            int putere = 0;

            while (numar % i == 0)
            {
                putere++;
                numar /= i;
            }

            if (putere > 0)
            {
                Console.Write($"{i}^{putere}");

                if (numar > 1)
                {
                    Console.Write(" x ");
                }
            }
        }

        Console.WriteLine();
    }
    static void ex19()
    {
        Console.Write("Introduceti un numar: ");
        int numar = int.Parse(Console.ReadLine());

        if (EsteFormatCuDouaCifreRepetate(numar))
        {
            Console.WriteLine($"{numar} este format doar cu doua cifre care se pot repeta.");
        }
        else
        {
            Console.WriteLine($"{numar} nu este format doar cu doua cifre care se pot repeta.");
        }

        Console.ReadLine();
    }

    static bool EsteFormatCuDouaCifreRepetate(int numar)
    {
        // Converteste numarul la sir de caractere
        string numarString = numar.ToString();

        // Verifica daca numarul are doar doua cifre care se pot repeta
        for (int i = 0; i < numarString.Length; i++)
        {
            if (numarString.Replace(numarString[i].ToString(), "").Length != numarString.Length - 2)
            {
                return false;
            }
        }

        return true;
    }
    static void ex20()
    {
        Console.Write("Introduceti numaratorul (m): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Introduceti numitorul (n): ");
        int n = int.Parse(Console.ReadLine());

        AfiseazaFracțieZecimalaCuPerioada(m, n);

        Console.ReadLine();
    }

    static void AfiseazaFracțieZecimalaCuPerioada(int m, int n)
    {
        // Verifică tipul de fracție
        if (EsteFracțieNeperiodica(m, n))
        {
            Console.WriteLine($"{m}/{n} = {1.0 * m / n}");
        }
        else
        {
            int parteIntreaga = m / n;
            int rest = m % n;

            List<int> resturi = new List<int>();
            List<int> zecimale = new List<int>();

            // Calculează partea zecimală
            while (rest != 0 && !resturi.Contains(rest))
            {
                resturi.Add(rest);
                rest *= 10;
                zecimale.Add(rest / n);
                rest %= n;
            }

            // Afișează rezultatul
            Console.Write($"{m}/{n} = {parteIntreaga}.");

            if (rest == 0)
            {
                // Fracție neperiodică
                foreach (var cifra in zecimale)
                {
                    Console.Write(cifra);
                }
            }
            else
            {
                // Fracție periodică
                int indexInceputPerioada = resturi.IndexOf(rest);
                for (int i = 0; i < indexInceputPerioada; i++)
                {
                    Console.Write(zecimale[i]);
                }

                Console.Write("(");

                for (int i = indexInceputPerioada; i < zecimale.Count; i++)
                {
                    Console.Write(zecimale[i]);
                }

                Console.Write(")");
            }

            Console.WriteLine();
        }
    }

    static bool EsteFracțieNeperiodica(int m, int n)
    {
        // Verifică dacă numitorul este de forma 2^m * 5^n
        while (n % 2 == 0)
        {
            n /= 2;
        }

        while (n % 5 == 0)
        {
            n /= 5;
        }

        return n == 1;
    }
    static void ex21()
    {
        Console.WriteLine("Ghiceste un numar intre 1 si 1024.");
        GhicesteNumar(1, 1024);

        Console.ReadLine();
    }

    static void GhicesteNumar(int limitaInferioara, int limitaSuperioara)
    {
        while (limitaInferioara <= limitaSuperioara)
        {
            int mijloc = (limitaInferioara + limitaSuperioara) / 2;

            Console.Write($"Numarul este mai mare sau egal decat {mijloc}? (da/nu): ");
            string raspuns = Console.ReadLine().ToLower();

            if (raspuns == "da")
            {
                limitaInferioara = mijloc + 1;
            }
            else if (raspuns == "nu")
            {
                limitaSuperioara = mijloc - 1;
            }
            else
            {
                Console.WriteLine("Raspuns invalid. Va rugam introduceti 'da' sau 'nu'.");
            }
        }

        Console.WriteLine($"Numarul ghicit este: {limitaSuperioara}");
    }
    static void ex1()
    {
        Console.Write("Introduceti coeficientul a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Introduceti coeficientul b: ");
        double b = double.Parse(Console.ReadLine());

        if (a != 0)
        {
            double x = -b / a;
            Console.WriteLine($"Solutia ecuatiei {a}x + {b} = 0 este x = {x}");
        }
        else
        {
            if (b == 0)
            {
                Console.WriteLine("Ecuatia are o infinitate de solutii.");
            }
            else
            {
                Console.WriteLine("Ecuatia nu are solutie.");
            }
        }

        Console.ReadLine();
    }
    static void ex2()
    {
        Console.Write("Introduceti coeficientul a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Introduceti coeficientul b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Introduceti coeficientul c: ");
        double c = double.Parse(Console.ReadLine());

        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            // Doua solutii reale distincte
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"Solutiile ecuatiei {a}x^2 + {b}x + {c} = 0 sunt x1 = {x1} si x2 = {x2}");
        }
        else if (delta == 0)
        {
            // O singura solutie reala
            double x = -b / (2 * a);
            Console.WriteLine($"Solutia ecuatiei {a}x^2 + {b}x + {c} = 0 este x = {x}");
        }
        else
        {
            // Doua solutii complexe conjugate
            double parteReala = -b / (2 * a);
            double parteImaginara = Math.Sqrt(Math.Abs(delta)) / (2 * a);

            Console.WriteLine($"Solutiile ecuatiei {a}x^2 + {b}x + {c} = 0 sunt complexe conjugate: ");
            Console.WriteLine($"x1 = {parteReala} + {parteImaginara}i");
            Console.WriteLine($"x2 = {parteReala} - {parteImaginara}i");
        }

        Console.ReadLine();
    }
    static void ex3()
    {
        Console.Write("Introduceti numarul n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Introduceti numarul k: ");
        int k = int.Parse(Console.ReadLine());

        if (SeDivide(n, k))
        {
            Console.WriteLine($"{n} se divide cu {k}.");
        }
        else
        {
            Console.WriteLine($"{n} nu se divide cu {k}.");
        }

        Console.ReadLine();
    }

    static bool SeDivide(int n, int k)
    {
        // Utilizăm operatorul modulo pentru a verifica dacă n se divide cu k
        return n % k == 0;
    }
    static void ex4()
    {
        Console.Write("Introduceti anul: ");
        int an = int.Parse(Console.ReadLine());

        if (!EsteAnBisect(an))
        {
            Console.WriteLine($"{an} nu este un an bisect.");
        }
        else
        {
            Console.WriteLine($"{an} este un an bisect.");
        }

        Console.ReadLine();
    }

    private static bool Esteanbisect(int an) =>
        // Verificăm condițiile pentru anul bisect
        (an % 4 == 0 && an % 100 != 0) || (an % 400 == 0);
    static void ex5()
    {
        Console.Write("Introduceti numarul: ");
        int numar = int.Parse(Console.ReadLine());

        Console.Write("Introduceti pozitia k: ");
        int k = int.Parse(Console.ReadLine());

        int cifra = ExtrageCifraDeLaSfarsit(numar, k);

        if (cifra != -1)
        {
            Console.WriteLine($"Cifra de la sfarsitul numarului de pe pozitia {k} este: {cifra}");
        }
        else
        {
            Console.WriteLine($"Numarul nu are suficiente cifre pentru a extrage pozitia {k}.");
        }

        Console.ReadLine();
    }

    static int ExtrageCifraDeLaSfarsit(int numar, int k)
    {
        if (k <= 0)
        {
            Console.WriteLine("Pozitia trebuie sa fie un numar pozitiv.");
            return -1;
        }

        // Iterăm prin cifre până ajungem la poziția k
        for (int i = 1; i < k; i++)
        {
            numar /= 10;
        }

        // Obținem ultima cifră prin modulo 10
        return numar % 10;
    }
}


