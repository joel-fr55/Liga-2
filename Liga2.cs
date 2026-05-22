//clase de la liga 2
class Liga2{
    //creando las variables
    public int I=0,J=0,K=0,N=0,O=0,Q=0,W=0,X=0,Z=0;                             //variable de cada equipo; se cuentas las victorias de c/a
    public int CaI,CaJ,CaK,CaN,CaO,CaQ,CaW,CaX,CaZ;                             //variable para contar las carreras delequipo
    public int LoI,LoJ,LoK,LoN,LoO,LoQ,LoW,LoX,LoZ;                              //variables de las Loser de cada equipo
    public int DifI,DifJ,DifK,DifN,DifO,DifQ,DifW,DifX,DifZ;                    //variables de las DIF de cada equip

    //para las secciones
    public String secA1 = " ",secA2 = " ",secA3 = " ",secB1 = " ",secB2 = " ",secB3 = " ",secC1 = " ",secC2 = " ",secC3 = " ";        //variable de las pociciones de cada seccion
    public int WinA1,WinA2,WinA3,WinB1,WinB2,WinB3,WinC1,WinC2,WinC3;           //contar las victorias de las secciones de cada equipo
    public int CaEA1,CaEA2,CaEA3,CaEB1,CaEB2,CaEB3,CaEC1,CaEC2,CaEC3;           //variable contar las carreras c/u seccion
    public int GA = 1;                                                          //variable para contar los juegos
    public int seccion = 1;                                                     //contar las secciones
    public int GAME = 0;                                                        //Variable contanste de juego.

    public int Eq1,Eq2,Eq3,Eq4,Eq5,Eq6;                                         //variables para las carreras
    public int Dia = 0;                                                         //variable para contar los dias

    public String poA1 = " ",poA2 = " ",poA3 = " ",poB1 = " ",poB2 = " ",poB3 = " ",poC1 = " ",poC2 = " ",poC3 = " ";                 //variable posiciones de cada equipo

    public void Contar(){                                                    //metodo para contar las carreras
        Random numerosAleatorios = new Random(); 
        do{ Eq1 = numerosAleatorios.Next( 0, 10 );        Eq2 = numerosAleatorios.Next( 0, 10 ); } while (Eq1 == Eq2);//contar seccion A
        do{ Eq3 = numerosAleatorios.Next( 0, 10 );        Eq4 = numerosAleatorios.Next( 0, 10 ); } while (Eq3 == Eq4);//contar seccion B
        do{ Eq5 = numerosAleatorios.Next( 0, 10 );        Eq6 = numerosAleatorios.Next( 0, 10 ); } while (Eq5 == Eq6);//contar seccion C  
    }//fin del metodo Contar


    //poner el metodo Organizar
    public void Organizar(String teamA1,String teamA2,String teamA3,String teamB1,String teamB2,String teamB3,String teamC1,String teamC2,String teamC3){                                                 //metodos para organizar los equipos
        secA1 = teamA1;        secA2 = teamA2;        secA3 = teamA3;
        secB1 = teamB1;        secB2 = teamB2;        secB3 = teamB3;
        secC1 = teamC1;        secC2 = teamC2;        secC3 = teamC3;

        if (seccion >= 2){
            secA1 = poA1;             secA2 = poB1;             secA3 = poC1; 
            secB1 = poA2;             secB2 = poB2;             secB3 = poC2;
            secC1 = poA3;             secC2 = poB3;             secC3 = poC3;
        }

    }//fin del metodo Organizar

    public void Conteo1(){                                      //se cuentan las carreras   //es asi Eq1 vs Eq2    
        //aqui se cuentas las victorias de C/U
        if (Eq1 >= Eq2)        {            WinA1 = WinA1 + 1;        }else {            WinA2 = WinA2 + 1;        }
        if (Eq3 >= Eq4)        {            WinB1 = WinB1 + 1;        }else {            WinB2 = WinB2 + 1;        }
        if (Eq5 >= Eq6)        {            WinC1 = WinC1 + 1;        }else {            WinC2 = WinC2 + 1;        }

        //aqui se cuentas las carreras de C/U
        CaEA1 = CaEA1 + Eq1;        CaEA2 = CaEA2 + Eq2;        //Seccion 1
        CaEB1 = CaEB1 + Eq3;        CaEB2 = CaEB2 + Eq4;        //Seccion 2
        CaEC1 = CaEC1 + Eq5;        CaEC2 = CaEC2 + Eq6;        //Seccion 3
    }

    public void Conteo2(){                                      //se cuentan las carreras   //es asi Eq1 vs Eq3   
        //aqui se cuentas las victorias de C/U
        if (Eq1 >= Eq2)        {            WinA1 = WinA1 + 1;        }else {            WinA3 = WinA3 + 1;        }
        if (Eq3 >= Eq4)        {            WinB1 = WinB1 + 1;        }else {            WinB3 = WinB3 + 1;        }
        if (Eq5 >= Eq6)        {            WinC1 = WinC1 + 1;        }else {            WinC3 = WinC3 + 1;        }

        //aqui se cuentas las carreras de C/U
        CaEA1 = CaEA1 + Eq1;        CaEA3 = CaEA3 + Eq2;        //Seccion 1
        CaEB1 = CaEB1 + Eq3;        CaEB3 = CaEB3 + Eq4;        //Seccion 2
        CaEC1 = CaEC1 + Eq5;        CaEC3 = CaEC3 + Eq6;        //Seccion 3
    }
    public void Conteo3(){                                      //se cuentan las carreras   //es asi Eq2 vs Eq3
        //aqui se cuentas las victorias de C/U
        if (Eq1 >= Eq2)        {            WinA2 = WinA2 + 1;        }else {            WinA3 = WinA3 + 1;        }
        if (Eq3 >= Eq4)        {            WinB2 = WinB2 + 1;        }else {            WinB3 = WinB3 + 1;        }
        if (Eq5 >= Eq6)        {            WinC2 = WinC2 + 1;        }else {            WinC3 = WinC3 + 1;        }

        //aqui se cuentas las carreras de C/U
        CaEA2 = CaEA2 + Eq1;        CaEA3 = CaEA3 + Eq2;        //Seccion 1
        CaEB2 = CaEB2 + Eq3;        CaEB3 = CaEB3 + Eq4;        //Seccion 2
        CaEC2 = CaEC2 + Eq5;        CaEC3 = CaEC3 + Eq6;        //Seccion 3
    }

    public void Ordenar(){                                      //metodo para ordenar las posiciones
        //seccion 1
        if (WinA1 >=WinA2 && WinA1 >=WinA3) { poA1 = secA1; if (WinA2 >= WinA3)  { poA2 = secA2;  poA3 = secA3; }
            else { poA2 = secA3; poA3 = secA2;  } }

        if (WinA2 >=WinA1 && WinA2 >=WinA3)  {  poA1 = secA2;  if (WinA1 >= WinA3) {   poA2 = secA1;   poA3 = secA3;  }  
            else {  poA2 = secA3;   poA3 = secA1;   } }

        if (WinA3 >=WinA1 && WinA3 >=WinA2) { poA1 = secA3;  if (WinA1 >= WinA2)  {   poA2 = secA1;  poA3 = secA2; }
            else {  poA2 = secA2;    poA3 = secA1;  }   

        if (WinA1 == WinA2 && WinA2 == WinA3){          //si fuera un empate
            if (CaEA1 >=CaEA2 && CaEA1 >=CaEA3) {  poA1 = secA1; if (CaEA2 >= CaEA3)  { poA2 = secA2;  poA3 = secA3; }  else { poA2 = secA3; poA3 = secA2;  }  }
            if (CaEA2 >=CaEA1 && CaEA2 >=CaEA3) {  poA1 = secA2; if (CaEA1 >= CaEA3)  { poA2 = secA1;  poA3 = secA3; }  else { poA2 = secA3; poA3 = secA1;  }  }
            if (CaEA3 >=CaEA1 && CaEA3 >=CaEA2) {  poA1 = secA3; if (CaEA1 >= CaEA2)  { poA2 = secA1;  poA3 = secA2; }  else { poA2 = secA2; poA3 = secA1;  }  }  
        } //fin de la variable empate sec 1
        }//fin de la seccion 1

        //seccion 2
        if (WinB1 >=WinB2 && WinB1 >=WinB3) { poB1 = secB1; if (WinB2 >= WinB3)  { poB2 = secB2;  poB3 = secB3; }
            else { poB2 = secB3; poB3 = secB2;  } }

        if (WinB2 >=WinB1 && WinB2 >=WinB3)  {  poB1 = secB2;  if (WinB1 >= WinB3) {   poB2 = secB1;   poB3 = secB3;  }  
            else {  poB2 = secB3;   poB3 = secB1;   }   }  

        if (WinB3 >=WinB1 && WinB3 >=WinB2) { poB1 = secB3;  if (WinB1 >= WinB2)  {   poB2 = secB1;  poB3 = secB2; }
            else {  poB2 = secB2;    poB3 = secB1;  }      

        if (WinB1 == WinB2 && WinB2 == WinB3){          //si fuera un empate
            if (CaEB1 >=CaEB2 && CaEB1 >=CaEB3) {  poB1 = secB1; if (CaEB2 >= CaEB3)  { poB2 = secB2;  poB3 = secB3; }  else { poB2 = secB3; poB3 = secB2;  }  }
            if (CaEB2 >=CaEB1 && CaEB2 >=CaEB3) {  poB1 = secB2; if (CaEB1 >= CaEB3)  { poB2 = secB1;  poB3 = secB3; }  else { poB2 = secB3; poB3 = secB1;  }  }
            if (CaEB3 >=CaEB1 && CaEB3 >=CaEB2) {  poB1 = secB3; if (CaEB1 >= CaEB2)  { poB2 = secB1;  poB3 = secB2; }  else { poB2 = secB2; poB3 = secB1;  }  }  
        } //fin de la variable empate sec 1
        }//fin de la seccion 2

        //seccion 3
        if (WinC1 >=WinC2 && WinC1 >=WinC3) { poC1 = secC1; if (WinC2 >= WinC3)  { poC2 = secC2;  poC3 = secC3; }
            else { poC2 = secC3; poC3 = secC2;  } }

        if (WinC2 >=WinC1 && WinC2 >=WinC3)  {  poC1 = secC2;  if (WinC1 >= WinC3) {   poC2 = secC1;   poC3 = secC3;  }  
            else {  poC2 = secC3;   poC3 = secC1;   }   }   
            
        if (WinC3 >=WinC1 && WinC3 >=WinC2) { poC1 = secC3;  if (WinC1 >= WinC2)  {   poC2 = secC1;  poC3 = secC2; }
            else {  poC2 = secC2;    poC3 = secC1;  } 
            
        if (WinC1 == WinC2 && WinC2 == WinC3){          //si fuera un empate
            if (CaEC1 >=CaEC2 && CaEC1 >=CaEC3) {  poC1 = secC1; if (CaEC2 >= CaEC3)  { poC2 = secC2;  poC3 = secC3; }  else { poC2 = secC3; poC3 = secC2;  }  }
            if (CaEC2 >=CaEC1 && CaEC2 >=CaEC3) {  poC1 = secC2; if (CaEC1 >= CaEC3)  { poC2 = secC1;  poC3 = secC3; }  else { poC2 = secC3; poC3 = secC1;  }  }
            if (CaEC3 >=CaEC1 && CaEC3 >=CaEC2) {  poC1 = secC3; if (CaEC1 >= CaEC2)  { poC2 = secC1;  poC3 = secC2; }  else { poC2 = secC2; poC3 = secC1;  }  }  
        } //fin de la variable empate sec 3
        }//fin de la seccion 3
    }

    public void Reiniciar(){                                      //reinicia las variables de cada seccion
        WinA1 = 0; WinA2 = 0; WinA3 = 0;
        WinB1 = 0; WinB2 = 0; WinB3 = 0;
        WinC1 = 0; WinC2 = 0; WinC3 = 0;

        CaEA1 = 0; CaEA2 = 0; CaEA3 = 0;
        CaEB1 = 0; CaEB2 = 0; CaEB3 = 0;
        CaEC1 = 0; CaEC2 = 0; CaEC3 = 0;       
    }//fin del metodo Reiniciar

    public void ConteoFinal(){                                  //contar las victorias y carreras final
        if (secA1 == "I"){                I = I + WinA1;            CaI = CaI + CaEA1;}
        else if(secA2 == "I"){            I = I + WinA2;            CaI = CaI + CaEA2;        }
        else if(secA3 == "I"){            I = I + WinA3;            CaI = CaI + CaEA3;        }
        else if(secB1 == "I"){            I = I + WinB1;            CaI = CaI + CaEB1;        }
        else if(secB2 == "I"){            I = I + WinB2;            CaI = CaI + CaEB2;        }
        else if(secB3 == "I"){            I = I + WinB3;            CaI = CaI + CaEB3;        }
        else if(secC1 == "I"){            I = I + WinC1;            CaI = CaI + CaEC1;        }
        else if(secC2 == "I"){            I = I + WinC2;            CaI = CaI + CaEC2;        }
        else if(secC3 == "I"){            I = I + WinC3;            CaI = CaI + CaEC3;        }

        if (secA1 == "J"){                J = J + WinA1;            CaJ = CaJ + CaEA1;}
        else if(secA2 == "J"){            J = J + WinA2;            CaJ = CaJ + CaEA2;        }
        else if(secA3 == "J"){            J = J + WinA3;            CaJ = CaJ + CaEA3;        }
        else if(secB1 == "J"){            J = J + WinB1;            CaJ = CaJ + CaEB1;        }
        else if(secB2 == "J"){            J = J + WinB2;            CaJ = CaJ + CaEB2;        }
        else if(secB3 == "J"){            J = J + WinB3;            CaJ = CaJ + CaEB3;        }
        else if(secC1 == "J"){            J = J + WinC1;            CaJ = CaJ + CaEC1;        }
        else if(secC2 == "J"){            J = J + WinC2;            CaJ = CaJ + CaEC2;        }
        else if(secC3 == "J"){            J = J + WinC3;            CaJ = CaJ + CaEC3;        }

        if (secA1 == "K"){                K = K + WinA1;            CaK = CaK + CaEA1;}
        else if(secA2 == "K"){            K = K + WinA2;            CaK = CaK + CaEA2;        }
        else if(secA3 == "K"){            K = K + WinA3;            CaK = CaK + CaEA3;        }
        else if(secB1 == "K"){            K = K + WinB1;            CaK = CaK + CaEB1;        }
        else if(secB2 == "K"){            K = K + WinB2;            CaK = CaK + CaEB2;        }
        else if(secB3 == "K"){            K = K + WinB3;            CaK = CaK + CaEB3;        }
        else if(secC1 == "K"){            K = K + WinC1;            CaK = CaK + CaEC1;        }
        else if(secC2 == "K"){            K = K + WinC2;            CaK = CaK + CaEC2;        }
        else if(secC3 == "K"){            K = K + WinC3;            CaK = CaK + CaEC3;        }

        if (secA1 == "N"){                N = N + WinA1;            CaN = CaN + CaEA1;}
        else if(secA2 == "N"){            N = N + WinA2;            CaN = CaN + CaEA2;        }
        else if(secA3 == "N"){            N = N + WinA3;            CaN = CaN + CaEA3;        }
        else if(secB1 == "N"){            N = N + WinB1;            CaN = CaN + CaEB1;        }
        else if(secB2 == "N"){            N = N + WinB2;            CaN = CaN + CaEB2;        }
        else if(secB3 == "N"){            N = N + WinB3;            CaN = CaN + CaEB3;        }
        else if(secC1 == "N"){            N = N + WinC1;            CaN = CaN + CaEC1;        }
        else if(secC2 == "N"){            N = N + WinC2;            CaN = CaN + CaEC2;        }
        else if(secC3 == "N"){            N = N + WinC3;            CaN = CaN + CaEC3;        }

        if (secA1 == "O"){                O = O + WinA1;            CaO = CaO + CaEA1;          }
        else if(secA2 == "O"){            O = O + WinA2;            CaO = CaO + CaEA2;        }
        else if(secA3 == "O"){            O = O + WinA3;            CaO = CaO + CaEA3;        }
        else if(secB1 == "O"){            O = O + WinB1;            CaO = CaO + CaEB1;        }
        else if(secB2 == "O"){            O = O + WinB2;            CaO = CaO + CaEB2;        }
        else if(secB3 == "O"){            O = O + WinB3;            CaO = CaO + CaEB3;        }
        else if(secC1 == "O"){            O = O + WinC1;            CaO = CaO + CaEC1;        }
        else if(secC2 == "O"){            O = O + WinC2;            CaO = CaO + CaEC2;        }
        else if(secC3 == "O"){            O = O + WinC3;            CaO = CaO + CaEC3;        }

        if (secA1 == "Q"){                Q = Q + WinA1;            CaQ = CaQ + CaEA1;}
        else if(secA2 == "Q"){            Q = Q + WinA2;            CaQ = CaQ + CaEA2;        }
        else if(secA3 == "Q"){            Q = Q + WinA3;            CaQ = CaQ + CaEA3;        }
        else if(secB1 == "Q"){            Q = Q + WinB1;            CaQ = CaQ + CaEB1;        }
        else if(secB2 == "Q"){            Q = Q + WinB2;            CaQ = CaQ + CaEB2;        }
        else if(secB3 == "Q"){            Q = Q + WinB3;            CaQ = CaQ + CaEB3;        }
        else if(secC1 == "Q"){            Q = Q + WinC1;            CaQ = CaQ + CaEC1;        }
        else if(secC2 == "Q"){            Q = Q + WinC2;            CaQ = CaQ + CaEC2;        }
        else if(secC3 == "Q"){            Q = Q + WinC3;            CaQ = CaQ + CaEC3;        }

        if (secA1 == "W"){                W = W + WinA1;            CaW = CaW + CaEA1;}
        else if(secA2 == "W"){            W = W + WinA2;            CaW = CaW + CaEA2;        }
        else if(secA3 == "W"){            W = W + WinA3;            CaW = CaW + CaEA3;        }
        else if(secB1 == "W"){            W = W + WinB1;            CaW = CaW + CaEB1;        }
        else if(secB2 == "W"){            W = W + WinB2;            CaW = CaW + CaEB2;        }
        else if(secB3 == "W"){            W = W + WinB3;            CaW = CaW + CaEB3;        }
        else if(secC1 == "W"){            W = W + WinC1;            CaW = CaW + CaEC1;        }
        else if(secC2 == "W"){            W = W + WinC2;            CaW = CaW + CaEC2;        }
        else if(secC3 == "W"){            W = W + WinC3;            CaW = CaW + CaEC3;        }

        if (secA1 == "X"){                X = X + WinA1;            CaX = CaX + CaEA1;}
        else if(secA2 == "X"){            X = X + WinA2;            CaX = CaX + CaEA2;        }
        else if(secA3 == "X"){            X = X + WinA3;            CaX = CaX + CaEA3;        }
        else if(secB1 == "X"){            X = X + WinB1;            CaX = CaX + CaEB1;        }
        else if(secB2 == "X"){            X = X + WinB2;            CaX = CaX + CaEB2;        }
        else if(secB3 == "X"){            X = X + WinB3;            CaX = CaX + CaEB3;        }
        else if(secC1 == "X"){            X = X + WinC1;            CaX = CaX + CaEC1;        }
        else if(secC2 == "X"){            X = X + WinC2;            CaX = CaX + CaEC2;        }
        else if(secC3 == "X"){            X = X + WinC3;            CaX = CaX + CaEC3;        }

        if (secA1 == "Z"){                Z = Z + WinA1;            CaZ = CaZ + CaEA1;}
        else if(secA2 == "Z"){            Z = Z + WinA2;            CaZ = CaZ + CaEA2;        }
        else if(secA3 == "Z"){            Z = Z + WinA3;            CaZ = CaZ + CaEA3;        }
        else if(secB1 == "Z"){            Z = Z + WinB1;            CaZ = CaZ + CaEB1;        }
        else if(secB2 == "Z"){            Z = Z + WinB2;            CaZ = CaZ + CaEB2;        }
        else if(secB3 == "Z"){            Z = Z + WinB3;            CaZ = CaZ + CaEB3;        }
        else if(secC1 == "Z"){            Z = Z + WinC1;            CaZ = CaZ + CaEC1;        }
        else if(secC2 == "Z"){            Z = Z + WinC2;            CaZ = CaZ + CaEC2;        }
        else if(secC3 == "Z"){            Z = Z + WinC3;            CaZ = CaZ + CaEC3;        }
    }//fin del metodo ConteoFinal

    public void ResultadoSeccion(){                                  //metodo para mostrar resultados de c/a seccion
        //VER RESULTADOS C/A SECCION
        Console.WriteLine(" Resultados:");
        Console.Write("{0}{1}{2}{3}{4}{5} {6}{7}{8}{9}{10}{11} ", secA1, ":", WinA1, "W-", CaEA1, "C", secA2, ":", WinA2, "W-", CaEA2, "C");
        Console.WriteLine("{0}{1}{2}{3}{4}{5} ", secA3, ":", WinA3, "W-", CaEA3, "C");
        
        Console.Write("{0}{1}{2}{3}{4}{5} {6}{7}{8}{9}{10}{11} ", secB1, ":", WinB1, "W-", CaEB1, "C", secB2, ":", WinB2, "W-", CaEB2, "C");
        Console.WriteLine("{0}{1}{2}{3}{4}{5} ", secB3, ":", WinB3, "W-", CaEB3, "C");
        
        Console.Write("{0}{1}{2}{3}{4}{5} {6}{7}{8}{9}{10}{11} ", secC1, ":", WinC1, "W-", CaEC1, "C", secC2, ":", WinC2, "W-", CaEC2, "C");
        Console.WriteLine("{0}{1}{2}{3}{4}{5} ", secC3, ":", WinC3, "W-", CaEC3, "C");
    }

    public void ResultadoFinal(){                                  //metodo para mostrar resultados FINAL
        //VER RESULTADOS
        Console.WriteLine("\n**Resultados Final**");
        Console.WriteLine("I:" + I + "W-" + CaI + "C " + "J:" + J + "W-" + CaJ + "C " + "K:" + K + "W-" + CaK + "C");
        Console.WriteLine("N:" + N + "W-" + CaN + "C " + "O:" + O + "W-" + CaO + "C " + "Q:" + Q + "W-" + CaQ + "C");
        Console.WriteLine("W:" + W + "W-" + CaW + "C " + "X:" + X + "W-" + CaX + "C " + "Z:" + Z + "W-" + CaZ + "C");
    }

    public void Resultados(){                                     //metodos para contar las derrotas y diferencia de c/a team
        LoI = I - GAME;   LoJ = J - GAME;   LoK = K - GAME; LoN = N - GAME;   LoO = O - GAME;   LoQ = Q - GAME; LoW = W - GAME;   LoX = X - GAME;   LoZ = Z - GAME;
        DifI = I - (-LoI);    DifJ = J - (-LoJ);   DifK = K - (-LoK);   DifN = N - (-LoN);    DifO = O - (-LoO);   DifQ = Q - (-LoQ);  DifW = W - (-LoW);    DifX = X - (-LoX);   DifZ = Z - (-LoZ);

        Console.WriteLine("Resultado en Liga: ");
        if (LoI == 0) { Console.Write("I:" + I + "-0" + " dif:" + DifI); } else { Console.Write("I:" + I + LoI + " dif:" + DifI); }
        if (LoJ == 0) { Console.Write("\tJ:" + J + "-0" + " dif:" + DifJ); } else { Console.Write("\tJ:" + J + LoJ + " dif:" + DifJ); }
        if (LoK == 0) { Console.WriteLine("\tK:" + K + "-0" + " dif:" + DifK); } else { Console.WriteLine("\tK:" + K + LoK + " dif:" + DifK); }

        if (LoN == 0) { Console.Write("N:" + N + "-0" + " dif:" + DifN); } else { Console.Write("N:" + N + LoN + " dif:" + DifN); }
        if (LoO == 0) { Console.Write("\tO:" + O + "-0" + " dif:" + DifO); } else { Console.Write("\tO:" + O + LoO + " dif:" + DifO); }
        if (LoK == 0) { Console.WriteLine("\tQ:" + Q + "-0" + " dif:" + DifQ); } else { Console.WriteLine("\tQ:" + Q + LoQ + " dif:" + DifQ); }
        
        if (LoW == 0) { Console.Write("W:" + W + "-0" + " dif:" + DifW); } else { Console.Write("W:" + W + LoW + " dif:" + DifW); }
        if (LoX == 0) { Console.Write("\tX:" + X + "-0" + " dif:" + DifX); } else { Console.Write("\tX:" + X + LoX + " dif:" + DifX); }
        if (LoZ == 0) { Console.WriteLine("\tZ:" + Z + "-0" + " dif:" + DifZ); } else { Console.WriteLine("\tZ:" + Z + LoZ + " dif:" + DifZ); }
    }

    public void Mostrar(){                                  //metodo para mostrar tabla de c/a juego
        secA1 = "I";     secA2 = "J";   secA3 = "K";        secB1 = "N";    secB2 = "O";    secB3 = "Q";        secC1 = "W";    secC2 = "X";    secC3 = "Z";
        Console.WriteLine("***********************LIGA II*************************");
        Console.ReadKey();
        do{                                                             //Iniciar el ciclo
        Organizar(secA1,secA2,secA3,secB1,secB2,secB3,secC1,secC2,secC3);
        Console.WriteLine("EQUIPOS:");
        Console.WriteLine("{0} {1} {2}\t{3} {4} {5}\t{6} {7} {8}", secA1, secA2, secA3, secB1, secB2, secB3, secC1, secC2, secC3);
        Console.ReadKey();
        //------------------------------------ Juego 1 -----------------------------------//
        Console.WriteLine("\nSemana " + seccion);
        Contar();
        Console.WriteLine("\tJuego " + GA);
        Console.WriteLine(secA1 + ":" + Eq1 + " vs " + secA2 + ":" + Eq2 + "\t");              //seccion A
        Console.WriteLine(secB1 + ":" + Eq3 + " vs " + secB2 + ":" + Eq4 + "\t");              //seccion B
        Console.WriteLine(secC1 + ":" + Eq5 + " vs " + secC2 + ":" + Eq6 + "\t\t");            //seccion C
        GA++;
        Conteo1();
        Console.ReadKey();
        //------------------------------------ Juego 2 -----------------------------------//
        Contar();
        Console.WriteLine("\tJuego " + GA);
        Console.WriteLine(secA1 + ":" + Eq1 + " vs " + secA3 + ":" + Eq2 + "\t");              //seccion A
        Console.WriteLine(secB1 + ":" + Eq3 + " vs " + secB3 + ":" + Eq4 + "\t");              //seccion B
        Console.WriteLine(secC1 + ":" + Eq5 + " vs " + secC3 + ":" + Eq6 + "\t\t");            //seccion C
        GA++;
        Conteo2();
        Console.ReadKey();
        //------------------------------------ Juego 3 -----------------------------------//
        Contar();
        Console.WriteLine("\tJuego " + GA);
        Console.WriteLine(secA2 + ":" + Eq1 + " vs " + secA3 + ":" + Eq2 + "\t");              //seccion A
        Console.WriteLine(secB2 + ":" + Eq3 + " vs " + secB3 + ":" + Eq4 + "\t");              //seccion B
        Console.WriteLine(secC2 + ":" + Eq5 + " vs " + secC3 + ":" + Eq6 + "\t\t");            //seccion C
        GA++;
        Conteo3();
        Console.ReadKey();
        Ordenar();

        seccion++;
        GAME = GAME + 2;
        ConteoFinal();
        
        ResultadoSeccion();//para mostrar resultados
        Console.ReadKey();
        
        if (GA <= 23){
            //mostrar las posiciones
            Console.WriteLine("\n Posiciones:");
            Console.WriteLine("{0}{1} {2}{3} {4}{5}","Seccion 1: pos1:", poA1, "pos2:", poA2, "pos3:", poA3);
            Console.WriteLine("{0}{1} {2}{3} {4}{5}","Seccion 2: pos1:", poB1, "pos2:", poB2, "pos3:", poB3);
            Console.WriteLine("{0}{1} {2}{3} {4}{5}","Seccion 3: pos1:", poC1, "pos2:", poC2, "pos3:", poC3);
            Console.ReadKey();
        }
        
        Reiniciar();//reiniciar variables
        if(GA >= 6 && GA <= 23){ Resultados(); }
        
        }while (seccion <= 8);                                      //Fin del ciclo
        //}while (seccion <= 8);                                      //Fin del ciclo
        ResultadoFinal();

    }//fin del metodo Mostrar

    public void MostrarResultado(){                                  //metodo para mostrar Solo los resultados
        Console.WriteLine("***********************LIGA II*************************");
        secA1 = "I";     secA2 = "J";   secA3 = "K";        secB1 = "N";    secB2 = "O";    secB3 = "Q";        secC1 = "W";    secC2 = "X";    secC3 = "Z";
        
        do{                                                             //Iniciar el ciclo
        Organizar(secA1,secA2,secA3,secB1,secB2,secB3,secC1,secC2,secC3);
        
        Contar();        GA++;        Conteo1();                                        //Juego 1
        Contar();        GA++;        Conteo2();                                        //Juego 2
        Contar();        GA++;        Conteo3();                                        //Juego 3

        Ordenar();
        seccion++;
        ConteoFinal();
        Reiniciar();//reiniciar variables

        }while (seccion <= 8);                                      //Fin del ciclo

        ResultadoFinal();
    }//fin del metodo MostrarResultado

}//fin de la clase Liga2