// See https://aka.ms/new-console-template for more information

//Aufgaben 1
//1.1

/*
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
//Studenten Liste erstellen, Studenten hinzufügen anzeigen filtern
//7.3 


using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using Microsoft.VisualBasic;

List<Student> studentliste=new List<Student>()
{
    
};


//7.4
studentliste.Add(new Student { name = "Agnieszka", alter = 38 });
studentliste.Add(new Student { name = "Lukas", alter = 25 });
studentliste.Add(new Student { name = "Uwe", alter = 30 });
studentliste.Add(new Student { name = "Beata", alter = 42 });
studentliste.Add(new Student { name = "Anna", alter = 19 });

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

//8.1
foreach (var student in studentliste)
{
    if (student.alter > 20)
    {
        Console.WriteLine($"Name: {student.name}, Alter: {student.alter}");
    }
}
//8.2
foreach (var student in studentliste)
{
    if (student.alter<18)
    {
        Console.WriteLine($"Name: {student.name}, Alter: {student.alter}");
    }
}
//8.3 
int anzahlStudentUber25=0;
foreach (var student in studentliste)
{
    if(student.alter>25)
    {
       anzahlStudentUber25++; 
    }
}
Console.WriteLine($"Anzahl der Studenten über 25 Jahre: {anzahlStudentUber25}");
//8.4
studentliste.Sort((a,b) => a.alter.CompareTo(b.alter));
studentliste.ForEach(student=> Console.WriteLine(student.alter + " " +student.name));
//8.5
studentliste.Sort((a,b) => string.Compare(a.name, b.name));
studentliste.ForEach(student=>Console.WriteLine(student.name));
//8.6
studentliste.OrderByDescending(student => student.alter);
var alteste=studentliste.OrderByDescending(student => student.alter).First();
Console.WriteLine($"Älteste Student ist {alteste.name}");
//noch kurzer geschrieben mit 'MaxBy' funktion 
var alteste2=studentliste.MaxBy(student => student.alter);
Console.WriteLine($"Älteste Student ist {alteste2.name}");

//Aufgabe 9 LINQ Häufigste Befehle

//9.1 Durschnitalter
studentliste.Average(student => student.alter);
Console.WriteLine($"Durschnitalter der Studenten ist: {studentliste.Average(student => student.alter)}");

//9.2 älteste Student
studentliste.Max(student => student.alter);
Console.WriteLine($"Älteste Student ist {studentliste.Max(student => student.alter)} Jahre alt.");

//9.3 sortieren Studenten nach Name
studentliste.OrderBy(student => student.name);
foreach (var student in studentliste)
{
    Console.WriteLine(student.name);
}
//9.4 Studenten unter 20 
studentliste.Where(student=>student.alter<20);
foreach (var student in studentliste.Where(student=>student.alter<20))
{
    Console.WriteLine(student.name + " " + student.alter);
}
//9.5 StudentenCount
studentliste.Count();
Console.WriteLine($"Anzahl der Studenten ist: {studentliste.Count()}");

//9.6 Liste nur mit Namen  (Warum wird automatisch alpabetisch sortiert? Wie kann ich das andern??)
studentliste.ForEach(student=>Console.WriteLine(student.name));

//Aufgabe 10
//10.1
//10.2
//10.3
//10.4
//10.5
//10.6

//Aufgabe 11
//Klasse Kurs erstellen, Zwei Objekte von Kurs erstellen, Studenten hinzufügen und anzeigen. Max Teilnehmer prüfen.

Kurs kurs1= new Kurs("Hagrids Armee", 5);
Kurs kurs2= new Kurs("Haus Slytherin", 6);

Console.WriteLine(kurs1.Info()+"\n"+kurs2.Info());

kurs1.teilnehmerListe.Add(studentliste[0]);
kurs1.teilnehmerListe.Add(studentliste[1]);
kurs2.teilnehmerListe.Add(studentliste[3]);
kurs2.teilnehmerListe.Add(studentliste[2]);

Console.WriteLine($"Teilnehmer von {kurs1.Info()} sind: ");
foreach (var teilnehmer in kurs1.teilnehmerListe)
{
    Console.WriteLine(teilnehmer.name);
}

Console.WriteLine($"Teilnehmer von {kurs2.Info()} sind: ");
foreach(var teilnehmer in kurs2.teilnehmerListe)
{
    Console.WriteLine(teilnehmer.name);
}
 
foreach (var teilnehmer in kurs1.teilnehmerListe)
{
    if (kurs1.teilnehmerListe.Count > kurs1.maXTeilnehmer)
    {
        Console.WriteLine($"Der Kurs {kurs1.Info()} hat die maximale Teilnehmerzahl überschritten.");
        break;
    }
    else
    {
        Console.WriteLine($"Der Kurs {kurs1.Info()} hat noch Platz für weitere Teilnehmer.");
        break;
    }
}

// Aufgabe 12 Statistik ( Unterschied zwischen LINQ, Filtern, und Statistik merken )

//Anzahl Studenten
int anzahlStudenten=studentliste.Count();
Console.WriteLine(anzahlStudenten);
int anzahlStudentenInKurs=kurs1.teilnehmerListe.Count();
Console.WriteLine(anzahlStudentenInKurs);

//Durschnittalter
double durschnittAltStudent=studentliste.Average(student => student.alter);
Console.WriteLine(durschnittAltStudent);
double durschnittAltStudentInKurs=kurs1.teilnehmerListe.Average(student => student.alter);
Console.WriteLine(durschnittAltStudentInKurs);

//Ältsete Student
int altesteStudent=studentliste.Max(student => student.alter);
Console.WriteLine(altesteStudent);
int altesteKursTeilnehmer=kurs1.teilnehmerListe.Max(student => student.alter);
Console.WriteLine(altesteKursTeilnehmer);

//Jüngste Student
int jungsteStudent=studentliste.Min(student=> student.alter);
Console.WriteLine(jungsteStudent);
int jungsteKursTeilnehmer=kurs2.teilnehmerListe.Min(student=> student.alter);
Console.WriteLine(jungsteKursTeilnehmer);

//Sortieren Liste
var kursTeihlenmerRanking= kurs2.teilnehmerListe.OrderByDescending(student => student.alter);
Console.WriteLine($"Ranking der Teilnehmer in {kurs2.Info()} nach Alter:");

//Nur name zeigen 
kurs1.teilnehmerListe.ForEach(student=>Console.WriteLine(student.name));


//Aufgabe 13 MENU

List<Student> studentslist2= new List<Student>();

Console.WriteLine("Das ist auswahl MENU und du hast folgende Optionen zuverfügung:");
Console.WriteLine("1 Neue Student hinzufügen");
Console.WriteLine("2 Studen anzeigen");
Console.WriteLine("3 Statistik schauen");
Console.WriteLine("4 Beenden");


bool lauft = true;

while(lauft)
{
   Console.WriteLine("Nimm ein Option");
   string userOption = Console.ReadLine();

   switch(userOption)
    {
        case "1":
            Console.WriteLine("Gib Name von Student");
            string nameOfStudent = Console.ReadLine();
            Console.WriteLine("Gib alter");
            int alterOfStudent= Convert.ToInt32(Console.ReadLine()); 
            studentslist2.Add(new Student{name=nameOfStudent, alter=alterOfStudent });
            Console.WriteLine($"Student {nameOfStudent} wurde hinzugefügt");
            break;


        case "2":
            Console.WriteLine("Student anzeigen");

            if (studentslist2.Count == 0)
            {
                Console.WriteLine("0 Studenten an der Liste.");
            }
            else
            {
                Console.WriteLine("Liste alle Studentetn");
                foreach(var student in studentslist2)
                {
                    Console.WriteLine(student.name + " ,"+ student.alter);
                }
            }
            break;

        case "3":
           
            if (studentslist2.Count == 0)
            {
                Console.WriteLine("0 Studenten an der Liste.");
            }
            else
            {
                var jungsteStudent = studentslist2.Min(student => student.alter);
                foreach (var student in studentslist2.Where(student => student.alter == jungsteStudent))
                {
                    Console.WriteLine($"Jüngste Student ist : {student.name}, {jungsteStudent} Jahre");
                }

                var altesteStudent = studentslist2.Max(student => student.alter);
                foreach (var student in studentslist2.Where(student => student.alter == altesteStudent))
                {
                    Console.WriteLine($"Älteste Student ist : {student.name}, {altesteStudent} Jahre");
                }
               
            }
            break;

        case "4":
            Console.WriteLine("Tschüss");
            return;

        default:
            Console.WriteLine("Falsche eingabe");
            break;
    }
}
 */

 /*

  Kurs CSharpAnfaenger = new Kurs("C# Anfänger", 7);

        bool laeuft = true;

        while (laeuft)
        {
            Console.WriteLine("\n1. Neue Student hinzufügen");
            Console.WriteLine("2. Studenten anzeigen");
            Console.WriteLine("3. Statistik anzeigen");
            Console.WriteLine("4. Beenden");
            Console.WriteLine("5. Status ändern");
            Console.WriteLine("6. Status anzeigen");

            Console.Write("Wähle eine Option: ");
            int auswahl = Convert.ToInt32(Console.ReadLine());

            MenuOptionen option = auswahl switch
            {
                1 => MenuOptionen.StudentHinzufuegen,
                2 => MenuOptionen.TeilnehmerAnzeigen,
                3 => MenuOptionen.StatistikAnzeigen,
                4 => MenuOptionen.Beenden,
                5 => MenuOptionen.StatusAndern,
                6 => MenuOptionen.StatusAnzeigen,
                _ => throw new Exception("Ungültige Option")
            };


   switch(option)
    {
        case MenuOptionen.StudentHinzufuegen:
            if(CSharpAnfaenger.Status == KursStatus.Abgeschlossen)
            {
                Console.WriteLine("Der Kurs ist abgeschlossen. Kein weiterer Student kann hinzugefügt werden.");
                break;
            }
            if(CSharpAnfaenger.Status == KursStatus.Aktiv)
            {
                Console.WriteLine("Der Kurs ist bereits begonenn. Frag Organisator ob du dich noch anmelden kannst. ");
                break;
            }
        
            Console.WriteLine("Gib Name von Student");
            string nameOfStudent = Console.ReadLine();
            Console.WriteLine("Gib alter von Student");
            int alterOfStudent= Convert.ToInt32(Console.ReadLine()); 
            
            CSharpAnfaenger.Teilnehmer.Add(new Student{name=nameOfStudent, alter=alterOfStudent, Status=KursStatus.Anmelden_möglich });
            Console.WriteLine($"Student {nameOfStudent} wurde hinzugefügt");
            break;

        case MenuOptionen.TeilnehmerAnzeigen:
            Console.WriteLine("Student anzeigen");

            if (CSharpAnfaenger.Teilnehmer.Count == 0)
            {
                Console.WriteLine("0 Studenten an der Liste.");
            }
            else
            {
                Console.WriteLine("Liste alle Studentetn");
                foreach(var student in CSharpAnfaenger.Teilnehmer)
                {
                Console.WriteLine(student.name + " ,"+ student.alter + "," + student.Status);
                }
            }
            break;

        case MenuOptionen.StatistikAnzeigen:
            if (CSharpAnfaenger.Teilnehmer.Count == 0)
            {
                Console.WriteLine("0 Studenten an der Liste.");
            }
            else
            {
                var jungsteStudent = CSharpAnfaenger.Teilnehmer.Min(student => student.alter);
                foreach (var student in CSharpAnfaenger.Teilnehmer.Where(student => student.alter == jungsteStudent))
                {
                    Console.WriteLine($"Jüngste Student ist : {student.name}, {jungsteStudent} Jahre");
                }

                var altesteStudent = CSharpAnfaenger.Teilnehmer.Max(student => student.alter);
                foreach (var student in CSharpAnfaenger.Teilnehmer.Where(student => student.alter == altesteStudent))
                {
                    Console.WriteLine($"Älteste Student ist : {student.name}, {altesteStudent} Jahre");
                }
               
            }
            break;

        case MenuOptionen.Beenden:
            Console.WriteLine("Tschüss");
            return;

        case MenuOptionen.StatusAndern:
            Console.WriteLine("Status ändern:");
            Console.WriteLine("1. Anmelden möglich");  
            Console.WriteLine("2. Aktiv");
            Console.WriteLine("3. Abgeschlossen");
            string statusOption = Console.ReadLine();
            switch (statusOption)
            {
                case "1":
                    CSharpAnfaenger.Status = KursStatus.Anmelden_möglich;
                    Console.WriteLine($"Der Status des Kurses {CSharpAnfaenger.titel} wurde auf 'Anmelden möglich' geändert.");
                    break;
                case "2":
                    CSharpAnfaenger.Status = KursStatus.Aktiv;
                    Console.WriteLine($"Der Status des Kurses {CSharpAnfaenger.titel} wurde auf 'Aktiv' geändert.");
                    break;
                case "3":
                    CSharpAnfaenger.Status = KursStatus.Abgeschlossen;
                    Console.WriteLine($"Der Status des Kurses {CSharpAnfaenger.titel} wurde auf 'Abgeschlossen' geändert.");
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe. Status wurde nicht geändert.");
                    break;
            }

            break;

        case MenuOptionen.StatusAnzeigen:
        Console.WriteLine("Status anzeigen:");
        Console.WriteLine($"Der Kurs {CSharpAnfaenger.titel} hat den Status: {CSharpAnfaenger.Status}");
        break;


        default:
            Console.WriteLine("Falsche eingabe");
            break;
    }
}
*/


//Note Berechnung mit switch expression
Console.WriteLine("Wie viel Punkte hast du bekommen?");
int punktezahl= Convert.ToInt32(Console.ReadLine());
string noteBewertung=punktezahl switch
{
    >=90 => "Note 1",
    >=80 => "Note 2",
    >=70 => "Note 3",
    >=60 => "Note 4",
    _ => "Note 5"
};
Console.WriteLine(noteBewertung);

if (punktezahl >= 60)
{
    Console.WriteLine("Bestanden. Herzlicg Glückwunsch!");
}
else
{
    Console.WriteLine("Nicht bestanden, tut mir leid.");
}


List<Bewertung> bewertungen = new List<Bewertung>();

bewertungen.Add(new Bewertung("Anna", 85));
bewertungen.Add(new Bewertung("Max", 45));
bewertungen.Add(new Bewertung("Tom", 72));

foreach (var bewertung in bewertungen)
{
    string note = bewertung.Punkte switch
    {
        >= 90 => "Note 1",
        >= 80 => "Note 2",
        >= 70 => "Note 3",
        >= 60 => "Note 4",
        _ => "Note 5"
    };
    Console.WriteLine($"Student: {bewertung.StudentName}, Punkte: {bewertung.Punkte}, {note}");
}
//Statistik Bewertungen

int anzahlBewertungen = bewertungen.Count;
int anzahlBestandenStudentetn= bewertungen.Count(b => b.Punkte >= 60);
int anzahlNichtBestandenStudentetn= bewertungen.Count(b => b.Punkte < 60);
double durchschnitt = bewertungen.Average(b => b.Punkte);
double max = bewertungen.Max(b => b.Punkte);
double min = bewertungen.Min(b => b.Punkte);


Console.WriteLine($"Anzahl der Studenten: {anzahlBewertungen}");
Console.WriteLine($"Anzahl der Studenten die bestanden haben: {anzahlBestandenStudentetn}");
Console.WriteLine($"Anzahl der Studenten die nicht bestanden haben: {anzahlNichtBestandenStudentetn}");
Console.WriteLine("Durchschnitt: " + durchschnitt);
Console.WriteLine("Beste Punktzahl: " + max);
Console.WriteLine("Schlechteste Punktzahl: " + min);
