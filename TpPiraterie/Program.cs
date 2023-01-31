using ClassLibraryPiraterie;

#region Test 1
//// Test de la partie 1
//Console.WriteLine("***Test de la partie 1***");
//Console.WriteLine();
////Un bateau pirate 0,0 avec le drapeau 1 et avec dommages
Navire ship1 = new Pirate(0, 0, 1, true);
////Un bateau marchand en 25,0 avec le drapeau 2
Navire ship2 = new Marchand(25, 0, 2);
//Console.WriteLine(ship1);
//Console.WriteLine(ship2);
//Console.WriteLine("Distance: " + ship1.Distance(ship2));
//Console.WriteLine("Quelques deplacements horizontaux et verticaux");
////Se deplace de 75 unites a droite et 100 en haut
//ship1.Avance(75, 100);
//Console.WriteLine(ship1);
//Console.WriteLine(ship2);
//Console.WriteLine("Un deplacement en bas:");
//ship1.Avance(0, -5);
//Console.WriteLine(ship1);
//ship1.Coule();
//ship2.Coule();
//Console.WriteLine("Apres destruction:");
//Console.WriteLine(ship1);
//Console.WriteLine(ship2);
//Console.ReadKey();
#endregion
#region Test 2
// Test de la partie 2
Console.Clear();
Console.WriteLine("***Test de la partie 2***");
Console.WriteLine();
// deux vaisseaux sont ennemis s’ils ont des drapeaux différents 
Console.WriteLine("Bateau pirate et marchand ennemis (trop loins):");
// bateau pirate intact
ship1 = new Pirate(0, 0, 1, false);
ship2 = new Marchand(0, 25, 2);
Console.WriteLine(ship1);
Console.WriteLine(ship2);
ship1.Rencontre(ship2);
Console.WriteLine("Apres la rencontre:");
Console.WriteLine(ship1);
Console.WriteLine(ship2);
Console.WriteLine();
Console.WriteLine("Bateau pirate et marchand ennemis (proches):");
// bateau pirate intact
ship1 = new Pirate(0, 0, 1, false);
ship2 = new Marchand(2, 0, 2);
Console.WriteLine(ship1);
Console.WriteLine(ship2);
ship1.Rencontre(ship2);
Console.WriteLine("Apres la rencontre:");
Console.WriteLine(ship1);
Console.WriteLine(ship2);
Console.WriteLine();
Console.WriteLine("Bateau pirate et marchand amis (proches):");
// bateau pirate intact
ship1 = new Pirate(0, 0, 1, false);
ship2 = new Marchand(2, 0, 1);
Console.WriteLine(ship1);
Console.WriteLine(ship2);
ship1.Rencontre(ship2);
Console.WriteLine("Apres la rencontre:");
Console.WriteLine(ship1);
Console.WriteLine(ship2);
Console.WriteLine();
Console.WriteLine("Deux bateaux pirates ennemis intacts (proches):");
// bateaux pirates intacts
ship1 = new Pirate(0, 0, 1, false);
ship2 = new Pirate(2, 0, 2, false);
Console.WriteLine(ship1);
Console.WriteLine(ship2);
ship1.Rencontre(ship2);
Console.WriteLine("Apres la rencontre:");
Console.WriteLine(ship1);
Console.WriteLine(ship2);
Console.WriteLine();
Console.WriteLine("Un bateau pirate intact et un avec dommages, ennemis:");
// bateau pirate intact
Navire ship3 = new Pirate(0, 2, 3, false);
Console.WriteLine(ship1);
Console.WriteLine(ship3);
ship3.Rencontre(ship1);
Console.WriteLine("Apres la rencontre:");
Console.WriteLine(ship1);
Console.WriteLine(ship3);
Console.WriteLine();
Console.WriteLine("Deux bateaux pirates ennemis avec dommages:");
Console.WriteLine(ship2);
Console.WriteLine(ship3);
ship3.Rencontre(ship2);
Console.WriteLine("Apres la rencontre:");
Console.WriteLine(ship2);
Console.WriteLine(ship3);
Console.WriteLine();
Console.ReadKey();
#endregion
