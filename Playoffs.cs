//clase Playoffs
public class Playoffs
{
    public String[] Clasificados = new string[5];                                       //variables para los nombres de los team
    public String[] Ganador = new string[4];                                            //variables para definir los ganadores
    public int V, H;                                                                    //variables para contar las victorias y derrotas
    public int WinV, WinH;                                                              //variables para contar las victorias y derrotas V/H
    public String Visit = " ", Home = " ";                                              //variables de los nombre de equipos HOME Y VISIT de c/a game

    public void LosPlayoffs(){                                                         //metodo para Mostrar los Playoffs
        Console.WriteLine("\n********************************* THE PLAYOFF ***********************************");
        Console.WriteLine("\t\t\t     Will Card");
        Console.WriteLine("{0}\t{1} {2} {3}\t\t {4}\n", "(4 Clasification)", Clasificados[3], "-", Clasificados[4], "(5 Clasification)");
        Console.WriteLine("\t\t\t      1 Round");
        Console.WriteLine("{0}\t{1}{2}", "(1 Clasification)",  Clasificados[0], " - (WILDCARD)");
        Console.WriteLine("{0}\t{1} {2} {3}\t\t{4}\n", "(2 Clasification)", Clasificados[1], "-", Clasificados[2], "(5 Clasification)");
        
    }//fin del metodo LosPlayoffs

    public void Contar(){                                                               //metodo para contar las carreras
        Random numerosAleatorios = new Random();
        { do { V = numerosAleatorios.Next(0, 10); H = numerosAleatorios.Next(0, 10); } while (V == H); }     
    }//fin del metodo Contar
    
    public void Reiniciar() { WinV = 0; WinH = 0; }                                //metodo para Reiniciar las victorias y derrotas
    
    public void Versus(String team1, String team2){                                //metodo para Mostrar los Versus de c/a partido
        Visit = team1; Home = team2;
        Contar();
        Console.WriteLine(Visit + ":" + V + " VS " + Home + ":" + H);
    }

    public void WILDCARD() {                                                          //metodo para Jugar los clasificados 4 y 5
        Console.WriteLine("\n*********************** WILDCARD ***************************");
        Console.WriteLine("\t\t     {0} {1} {2}\n",  Clasificados[3], "-", Clasificados[4]);
        Console.ReadKey();
        do { Versus(Clasificados[3], Clasificados[4]);
            if (V >= H) { WinV++; } if (H >= V) { WinH++; }
            Console.ReadKey();
        } while (WinV <= 0 && WinH <= 0);
        if (WinV >= WinH) { Ganador[0] = Visit; } else { Ganador[0] = Home; }
        Console.WriteLine("Winner: " + Ganador[0] + "\t"); Console.WriteLine(WinV + " - " + WinH);
        Reiniciar();
    }//fin del metodo WILDCARD

    public void Round1(){                                                         //metodo para Jugar el Round 1
        Console.WriteLine("\n\tROUND 1");
        do{ Versus(Clasificados[0], Ganador[0]);
            if (V >= H) { WinV++; } if (H >= V) { WinH++; }
            Console.ReadKey(); 
        } while (WinV <= 2 && WinH <= 2);
        if (WinV >= WinH) { Ganador[1] = Visit; } else { Ganador[1] = Home; }
        Console.WriteLine("\nGanador: " + Ganador[1] + "\t");
        Console.WriteLine(WinV + " - " + WinH + "\n");
        Reiniciar();
        //---------------------------------------------------------------------------------------------------------------
        Console.ReadKey();
        do{ Versus(Clasificados[1], Clasificados[2]);
            if (V >= H) { WinV++; } if (H >= V) { WinH++; }
            Console.ReadKey(); 
        } while (WinV <= 2 && WinH <= 2);
        if (WinV >= WinH) { Ganador[2] = Visit; } else { Ganador[2] = Home; }
        Console.WriteLine("\nGanador: " + Ganador[2] + "\t");
        Console.WriteLine(WinV + " - " + WinH + "\n");
        Reiniciar();
    }//fin del metodo Round1

    public void Final(){                                                         //metodo para Jugar la Final
        Console.WriteLine("*********************** GRAN FINAL ***************************");
        Console.WriteLine("\t\t     {0} {1} {2}\n",  Ganador[1], "-", Ganador[2]);
        Console.ReadKey();
        do{ Versus(Ganador[1], Ganador[2]);
            if (V >= H) { WinV++; } if (H >= V) { WinH++; }
            Console.ReadKey(); 
        } while (WinV <= 3 && WinH <= 3);
        if (WinV >= WinH) { Ganador[3] = Visit; } else { Ganador[3] = Home; }
    }//fin del metodo Final

    public void NombreCompleto(){                                                   //metodo nombrar nombre completo del team
        if (Ganador[3] == "Indiana") { Ganador[3] = "Indiana Iguana"; } 
        if (Ganador[3] == "Jefferson") { Ganador[3] = "Jefferson Jelly fish"; }
        if (Ganador[3] == "Kansas City") { Ganador[3] = "Kansas City Kill Bull"; } 
        if (Ganador[3] == "New Orleand") { Ganador[3] = "New Orleand Neut"; }
        if (Ganador[3] == "Oaklan") { Ganador[3] = "Oaklan Oriols"; } 
        if (Ganador[3] == "Queen") { Ganador[3] = "Queen Quail"; }
        if (Ganador[3] == "Washington") { Ganador[3] = "Washington Whale"; } 
        if (Ganador[3] == "Xian") { Ganador[3] = "Xian Sox"; }
        if (Ganador[3] == "Zap Canon") { Ganador[3] = "Zap Canon Zebra"; }
    }//fin del metodo nombreCompleto

    public void Winner(){                                                        //metodo para Anunciar el Ganador de esta Playoff
        Console.WriteLine("\n{0} {1}\n{2} {3} {4}\n", "El Gran ganador es:", Ganador[3], WinV, "-", WinH);
    }//fin del metodo Winner

    public void Mostrar(){                                                       //metodo para mostrar los metodos en Orden
        LosPlayoffs();     Console.ReadKey();
        WILDCARD();        Console.ReadKey();
        Round1();          Console.ReadKey();
        Final();

        NombreCompleto();
        Winner();
        Console.Write("FIN");
    }//fin del metodo Mostrar

}//fin de la clase Playoffs
