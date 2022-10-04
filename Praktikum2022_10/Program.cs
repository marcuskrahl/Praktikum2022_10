namespace Praktikum2022_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Der Programmcode, den wir erstellen wollen, wird ab dieser Stelle eingegeben
            //Zeilen, die mit // beginnen, sind ein Kommentar und werden beim Interpretieren des Programmcodes ignoriert

            //Mit Console.WriteLine("text") kann in der Konsole ein Text ausgegeben werden
            //Die folgende Zeile gibt den Text "Hello, World!" aus
            Console.WriteLine("Hello, World!");

            //Aufgabe 1: Gib auf der Konsole deinen Namen aus


            //Werte können in sogenannten Variablen gespeichert werden.
            //Jede Variable besteht aus dem Typ (hier string) und einem Namen (hier meineSchule).
            //Der Wert der Variable wird mit = zugewiesen (hier "42. Mittelschule")

            //string meineSchule = "42. Mittelschule";
            //Console.WriteLine(meineSchule);

            //Aufgabe 2: Lege eine Variable für deine Lieblingsfarbe an, und gebe sie auf der Konsole aus


            //Man kann den Nutzer auch nach Eingaben Fragen und das Ergebnis in eine Variable speichern
            //Dazu kannst du die Funktoin Console.ReadLine() nutzen
            //Console.WriteLine("Was ist dein Lieblingstier?");
            //string lieblingsTier = Console.ReadLine();
            //Console.WriteLine("Dein Lieblingstier ist " + lieblingsTier);

            //Aufgabe 3: Frage den Nutzer nach seinem Namen und begrüße ihn

            //Der Typ string steht für Zeichenketten, sprich Text 
            //Daneben gibt es noch Typen für ganze Zahlen
            //int meineZahl = 10;
            //Rationale Zahlen
            //double pi = 3.1415d;
            //und einzelne Zeichen eines Textes:
            //char ersterBuchstabe = 'c';

            //Mit Zahlen kann man zum Beispiel rechnen:
            //int ergebnis = 35 + 17;
            //Console.WriteLine(ergebnis);

            //Aufgabe 4: Berechne den Flächeninhalt von einem Rechteck mit den Seitenlängen 3cm und 5cm und gib
            //das Ergebnis auf der Konsole aus


            //Wenn der Nutzer einen Text mit Console.ReadLine() eingibt, ist der Typ erst einmal "string"
            //Um mit der Eingabe rechnen zu können, muss die Eingabe erst in eine Zahl umgewandelt werden.
            //Das kannst du mit int.Parse("42") machen:
            //string zahlAlsString = Console.ReadLine();
            //int zahl = int.Parse(zahlAlsString);
            //Console.WriteLine(2 * zahl);

            //Aufgabe 5: Lasse den Nutzer zwei Zahlen eingeben und berechne deren Summe

        }
    }
}