// See https://aka.ms/new-console-template for more information

//Aufgaben 1
//1.1

string name = "Agnieszka";
int alter= 38;
string stadt ="Lippstadt";
Console.WriteLine($"Mein Name ist {name}, ich bin {alter} Jahre alt und wohne in {stadt}.");

//1.2
Console.WriteLine("Hallo, wie heißt du?");
string userName = Console.ReadLine();
Console.WriteLine($"Hallo {userName}, schön dich kennenzulernen!");   

//1.3
Console.WriteLine("Wie alt bist du?");
string userAge= Console.ReadLine();
Console.WriteLine($"Du bist {userAge} alt.");

//1.4
int a = 10;
int b= 20;
int sume= a+b;
int differnz=Math.Abs(a-b);
Console.WriteLine($"Sume ist {sume} und differenz ist {differnz}");

// 1.5
Console.WriteLine("Gib eine Zahlen ein:");
int userZahl1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Gib  noch eine Zahlen ein:");
int userZahl2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sume von deine Zahlen ist: {userZahl1 + userZahl2}");

//1.6
Console.WriteLine("Gib eine Zahl ein:");
int userZahl3= Convert.ToInt32(Console.ReadLine());
Console.WriteLine(userZahl3 * userZahl3);


//Aufgaben 2

Console.WriteLine("Gib mir bitte eine Zahl");
int userZahl7=Convert.ToInt32(Console.ReadLine());

if (userZahl7 >10)
    Console.WriteLine("Gross");

else
    Console.WriteLine("Klein.");

Console.WriteLine("Wie viel Punkte hast du ?");
int punktezahl= Convert.ToInt32(Console.ReadLine());

if (punktezahl <=50)
    Console.WriteLine("bestanden");
else
    Console.WriteLine("nicht bestanden");


string bewertung2=punktezahl switch
{
    >=90 => "Note 1",
    >=80 => "Note 2",
    >=70 => "Note 3",
    >=60 => "Note 4",
    _ => "Nicht bestanden, tut mir leid"
};
Console.WriteLine(bewertung2);    


Console.WriteLine("Wie alt bist du?");
int userAlter=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(userAlter <18? "Minderjahrig": "Volljahrig");

Console.WriteLine("Gib eine Zahl ein:");
int userZahl= Convert.ToInt32(Console.ReadLine());
Console.WriteLine(userZahl % 2 ==0? "Gerade": "Ungerade");



Console.WriteLine("Gib eine Zahl ein:");
int userZahl9= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Gib noch eine Zahl ein");
int userZahl10= Convert.ToInt32(Console.ReadLine());
int maxZahl= Math.Max(userZahl9, userZahl10);
Console.WriteLine(maxZahl);


//Aufgaben 3
//3.1

int i;
string liste1="";

for(i=1;i <=20; i++)
{
    liste1+=i + ",";
    
}
Console.WriteLine(liste1);

//3.2
int i2;
string liste2="";

for (i2=1; i2<=50; i2++)
{
    if (i2 % 2 ==0)
    {
        liste2+=i2 + ",";
    }
}
Console.WriteLine(liste2);

//das gleiche wie oben aber anders
string liste5="";
for (int h=2; h<=50;h+=2)
{
    liste5+=h + ",";
}
Console.WriteLine(liste5);

//3.3

int suma=0;

for (int j=1; j <= 100; j++)
{
    suma+=j;
    
}
Console.WriteLine(suma);

//3.4

Console.WriteLine("Gib eine Zahl ein:");
int userrZahl= Convert.ToInt32(Console.ReadLine());  
for (int c=1; c <=userrZahl; c++)
{
    Console.WriteLine(c);
}


//3.5
int zahl =7;

int d = 1;

while (d <= 10)
{
    Console.WriteLine($"{zahl} x {d} = {zahl * d}");
    d++;
}
//3.6
for (int f=10; f >=1; f--)
{
    Console.WriteLine(f);
}

//Aufgabe 4
//4.1

string SagHallo()
{
    return "Hallo!";
}
Console.WriteLine(SagHallo());
//4.2
int Addiere(int a, int b)
{
    return a + b;
}
Console.WriteLine(Addiere(2, 15));
//4.3
string IstGerade(int zahl)
{
    return zahl % 2 == 0 ? "Gerade" : "Ungerade";
}
Console.WriteLine(IstGerade(22));
//4.4
int Quadrat(int zahl)
{
    return zahl * zahl;
}
Console.WriteLine(Quadrat(5));
//4.5
int Max(int a , int b)
{
    return Math.Max(a, b);
}   
Console.WriteLine(Max(10, 20));
//4.6
int NoteBerechen (int punkte)
{
    if (punkte >= 92) return 1;
    else if (punkte >= 80) return 2;
    else if (punkte >= 67) return 3;
    else if (punkte >= 50) return 4;
    else return 5;
}
//Aufgaben 5
//5.2  


Auto auto1 = new Auto();
auto1.Marke = "Toyota Yaris";
auto1.Baujahr = 2025;
Console.WriteLine($"Marke ist: {auto1.Marke} und Baujahr ist: {auto1.Baujahr}");

//5.3
Auto auto2= new Auto() { Marke = "Audi", Baujahr = 1995 };
Console.WriteLine($"Marke ist: {auto2.Marke} und Baujahr ist: {auto2.Baujahr}");
Console.WriteLine(auto2);

//5.5
auto2.Fahren(158);
auto1.Fahren(52);

//5.6
List<Auto> autoListe = new List<Auto>()
{
  new Auto() { Marke = "BMW v7", Baujahr = 2025 },
  new Auto() { Marke = "Audi a4", Baujahr = 2024 },
  new Auto() { Marke = "VW Golf 5", Baujahr = 2025 },   
  new Auto() { Marke = "Ford Fiesta", Baujahr = 2022 },
  new Auto() { Marke = "Fiat Punto", Baujahr = 2025 }    
};

Console.WriteLine("Autos in der Liste:");
foreach (var auto in autoListe)
{
    Console.WriteLine($"Marke: {auto.Marke}, Baujahr: {auto.Baujahr}");
}


//6.3
Auto auto3= new Auto("Toyota Yaris", 2020);
Auto auto4= new Auto("Opel Fiesta", 2018);
Auto auto5= new Auto("VW Polo", 1999);


//6.4
List<Auto> autoListe2 = new List<Auto>()
{
    auto3,
    auto4,
    auto5
};
foreach (var auto in autoListe2)
{
    Console.WriteLine(auto);
}

//6.6
foreach (var auto in autoListe2)
{
    auto.Info();
}

//7.3 

using Microsoft.VisualBasic;

List<Student> studentliste=new List<Student>()
{
    
};

//7.4
studentliste.Add(new Student { name = "Agnieszka", alter = 38 });
studentliste.Add(new Student { name = "John", alter = 25 });
studentliste.Add(new Student { name = "Maria", alter = 30 });
studentliste.Add(new Student { name = "Peter", alter = 22 });
studentliste.Add(new Student { name = "Anna", alter = 28 });

//7.5
foreach (var student in studentliste)
{
    Console.WriteLine($"Name: {student.name}, Alter: {student.alter}");
}

//7.6
int anzahlStudent=0;
foreach (var student in studentliste)
{
    anzahlStudent++;
}
Console.WriteLine($"Anzahl der Studenten: {anzahlStudent}");