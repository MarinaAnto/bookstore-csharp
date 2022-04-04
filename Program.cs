// See https://aka.ms/new-console-template for more information
string titolo = "Le mille e una notte";
string autore = "Armando Dominicis";
int pagine = 959;
long ISBN = 8854180483;
double peso=1.04;
double larghezza = 16.5;
short profondità = 6;
double altezza = 24.2;
double prezzo = 12.25;
double valutazione = 4.3;
bool copertina_rigida = true;
bool Kindle = false;

Console.WriteLine("Il libro di oggi è " + titolo + "  di " + autore +"con valutazione di "+valutazione +" stelle.");
Console.WriteLine("Il prezzo è " + prezzo + " con copertina rigida e un numero di pagine di " + pagine);
Console.WriteLine("Il peso è di " + peso + " kg, mentre le dimensioni (altezza, larghezza, profondità) sono rispettivamente: " + altezza + "-" + larghezza + "-" + profondità);
Console.WriteLine("ISBN-" + ISBN + ", copertina rigida-" + copertina_rigida + ", Kindle-" + Kindle);