// clase inicial
Console.WriteLine("Bienvenido");

//MOSTRAR LIGA 2
Liga2 myLiga2 = new Liga2();
//myLiga2.MostrarResultado();
myLiga2.Mostrar();
Console.ReadKey();

//crear una clase para organizar los team
Organizar liga2org = new Organizar();

//asignando las victorias  
liga2org.win[0] = myLiga2.I; liga2org.win[1] = myLiga2.J; liga2org.win[2] = myLiga2.K; 
liga2org.win[3] = myLiga2.N; liga2org.win[4] = myLiga2.O; liga2org.win[5] = myLiga2.Q; 
liga2org.win[6] = myLiga2.W; liga2org.win[7] = myLiga2.X; liga2org.win[8] = myLiga2.Z;

//asignando las carreras 
liga2org.care[0] = myLiga2.CaI; liga2org.care[1] = myLiga2.CaJ; liga2org.care[2] = myLiga2.CaK; 
liga2org.care[3] = myLiga2.CaN; liga2org.care[4] = myLiga2.CaO; liga2org.care[5] = myLiga2.CaQ; 
liga2org.care[6] = myLiga2.CaW; liga2org.care[7] = myLiga2.CaX; liga2org.care[8] = myLiga2.CaZ;

//AQUI MUESTRA LA ORGANIZACION DE DATOS
liga2org.Ordenar();
liga2org.Mostrar();
Console.ReadKey();

//AQUI MUESTRA LOS CLASIFICADOS
liga2org.Nombrar();
liga2org.Clasificado();
Console.ReadKey();

//crear una clase para losPlayoffs
Playoffs losPlayoffs = new Playoffs();

//asignando los Clasificados 
for (int cont = 0; cont <= 4; cont++) { losPlayoffs.Clasificados[cont] = liga2org.equipo[cont]; }

//AQUI MUESTRA LOS Playoffs
losPlayoffs.Mostrar();
Console.ReadKey();