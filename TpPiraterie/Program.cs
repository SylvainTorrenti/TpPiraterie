using ClassLibraryPiraterie;

// Test de la partie 1
Console.WriteLine("***Test de la partie 1***");
Console.WriteLine();
//Un bateau pirate 0,0 avec le drapeau 1 et avec dommages
Navire ship1 = new NavirePirate(0, 0, 1, true);
//Un bateau marchand en 25,0 avec le drapeau 2
Navire ship2 = new NavireMarchand(25, 0, 2);
Console.WriteLine(ship1);
Console.WriteLine(ship2);
Console.WriteLine("Distance: " + ship1.Distance(ship2));
Console.WriteLine("Quelques deplacements horizontaux et verticaux");
//Se deplace de 75 unites a droite et 100 en haut
ship1.Avance(75, 100);
Console.WriteLine(ship1);
Console.WriteLine(ship2);
Console.WriteLine("Un deplacement en bas:");
ship1.Avance(0, -5);
Console.WriteLine(ship1);
ship1.Coule();
ship2.Coule();
Console.WriteLine("Apres destruction:");
Console.WriteLine(ship1);
Console.WriteLine(ship2);
Console.ReadKey();