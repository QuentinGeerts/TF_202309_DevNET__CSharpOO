using ExempleDelegate;

CarWash MonCarWash = new CarWash();


etudiant Aguilera = new etudiant();
Aguilera.DHurle += Ecoute;

Aguilera.HurleAAA();
etudiant Jennifer = new etudiant();
Jennifer.DHurle += Ecoute;
etudiant Shakira = new etudiant();
Shakira.DHurle += Ecoute;
etudiant DwayneJ = new etudiant();
Aguilera.Lancer(MonCarWash.ListOperation, "0-A-0");
 
MonCarWash.ChangementDeForfait(1);
Jennifer.Lancer(MonCarWash.ListOperation, "1-A-1");
MonCarWash.ChangementDeForfait(0);
Shakira.Lancer(MonCarWash.ListOperation, "2-A-2");
MonCarWash.ChangementDeForfait(1);
DwayneJ.Lancer(MonCarWash.ListOperation,"3-A-3");




void Ecoute(string info)
{
    Console.WriteLine($"info : {info}");
}