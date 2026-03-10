// See https://aka.ms/new-console-template for more information

//Aufgaben 1

/*
string name = "Agnieszka";
int alter= 38;
string stadt ="Lippstadt";
Console.WriteLine($"Mein Name ist {name}, ich bin {alter} Jahre alt und wohne in {stadt}.");

Console.WriteLine("Hallo, wie heißt du?");
string userName = Console.ReadLine();
Console.WriteLine($"Hallo {userName}, schön dich kennenzulernen!");   

Console.WriteLine("Wie alt bist du?");
string userAge= Console.ReadLine();
Console.WriteLine($"Du bist {userAge} alt.");

int a = 10;
int b= 20;
int sume= a+b;
int differnz=Math.Abs(a-b);
Console.WriteLine($"Sume ist {sume} und differenz ist {differnz}");


Console.WriteLine("Gib eine Zahlen ein:");
int userZahl1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Gib  noch eine Zahlen ein:");
int userZahl2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sume von deine Zahlen ist: {userZahl1 + userZahl2}");


Console.WriteLine("Gib eine Zahl ein:");
int userZahl3= Convert.ToInt32(Console.ReadLine());
Console.WriteLine(userZahl3 * userZahl3);


//Aufgaben 2

Console.WriteLine("Gib mir bitte eine Zahl");
int userZahl1=Convert.ToInt32(Console.ReadLine());

if (userZahl1 >10)
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
int userZahl= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Gib noch eine Zahl ein");
int userZahl2= Convert.ToInt32(Console.ReadLine());
int maxZahl= Math.Max(userZahl, userZahl2);
Console.WriteLine(maxZahl);

//Aufgaben 3

int i;
string liste1="";

for(i=1;i <=20; i++)
{
    liste1+=i + ",";
    
}
Console.WriteLine(liste1);


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
for (int i=2; i<=50;i+=2)
{
    liste5+=i + ",";
}
Console.WriteLine(liste5);



int sume=0;

for (int i=1; i <= 100; i++)
{
    sume+=i;
    
}
Console.WriteLine(sume);


Console.WriteLine("Gib eine Zahl ein:");
int userZahl= Convert.ToInt32(Console.ReadLine());  
for (int i=1; i <=userZahl; i++)
{
    Console.WriteLine(i);
}

Console.Write("Gib eine Zahl ein: ");

int zahl =7;

int i = 1;

while (i <= 10)
{
    Console.WriteLine($"{zahl} x {i} = {zahl * i}");
    i++;
}

for (int i=10; i >=1; i--)
{
    Console.WriteLine(i);
    
}
*/

