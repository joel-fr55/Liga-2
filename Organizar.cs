//eclase Organizar
class Organizar{
    public String[] equipo = {"I","J","K","N","O","Q","W","X","Z"};                             //Variables de nombre de los equipo
    public int[] win = new int[9];                                                              //victorias de los equipo
    public int[] lose = new int[9];                                                             //derrotas de los equipo
    public int[] care = new int[9];                                                             //carreras de los equipos
    public String CHA = " ";                                                                    //variable vacio
    public int vac = 0;                                                                         //variable cero
    public int valA, valB;                                                                      //variable contadores
    public String[] pos = {"1ro", "2do", "3ro", "4to", "5to"};                                  //Variables de posiciones

    public void Ordenar(){                                      //Metodo para organizar los equipo en orden

        for (int cont = 0; cont <= 8; cont++){
            valA = 0; valB = 1;
            for (int sum = 0; sum <= 7; sum++){
                if (win[valA] < win[valB] || win[valA] == win[valB] && care[valA] < care[valB])
                {
                    CHA = equipo[valA]; equipo[valA] = equipo[valB]; equipo[valB] = CHA;
                    vac = win[valA]; win[valA] = win[valB]; win[valB] = vac;
                    vac = care[valA]; care[valA] = care[valB]; care[valB] = vac;
                }
                valA++; valB++;
            }
        }

        for (int cont = 0; cont <= 8; cont++) { lose[cont] = win[cont] - 16; }             //contador para contar las derratas de c/a team
        
    }//fin del metodo Ordenar


    public void Mostrar(){                                      //Metodo para mostrar los equipo
        Console.WriteLine("\nOrdenado");
        for (int cont = 0; cont <= 8; cont++) { Console.WriteLine(equipo[cont] + ": " + win[cont] + "W" + lose[cont] + "L " + care[cont] + "C"); }
        
    }//fin del metodo Mostrar

    public void Nombrar(){                                       //Metodo para Nombrar los equipo
        for (int cont = 0; cont <= 7; cont++){
            if (equipo[cont] == "I") { equipo[cont] = "Indiana"; }
            if (equipo[cont] == "J") { equipo[cont] = "Jefferson"; }
            if (equipo[cont] == "K") { equipo[cont] = "Kansas City"; }
            if (equipo[cont] == "N") { equipo[cont] = "New Orleand"; }
            if (equipo[cont] == "O") { equipo[cont] = "Oaklan"; }
            if (equipo[cont] == "Q") { equipo[cont] = "Queen"; }
            if (equipo[cont] == "W") { equipo[cont] = "Washington"; }
            if (equipo[cont] == "X") { equipo[cont] = "Xian"; }
            if (equipo[cont] == "Z") { equipo[cont] = "Zap Canon"; }
        }
    }//fin del metodo Nombrar

    public void Clasificado() {                                  //Metodo para mostrar los clasificados de c/a team
        Console.WriteLine("\nClasificados");
        for (int cont = 0; cont <= 4; cont++) { Console.WriteLine(pos[cont] + ": " + equipo[cont]); }
    }//fin del metodo Clasificado

}//fin de la clase Organizar