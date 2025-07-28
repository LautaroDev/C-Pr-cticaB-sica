

        //bp = bandera Par, bi = bandera Impar
        bool bp = false, bi = false; 
        int maxPar = 0, minInpar= 0 ,numero;

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());


            //es Par
            if (numero % 2 == 0)
            {
                if (bp == false)
                {
                    //si bp es 0, no se ingreso ningun numero al programa, por lo que el primero que se ingrese va a ser el mayor.
                    bp = true;
                    maxPar = numero;
                }
                else if (numero > maxPar)
                {
                    maxPar = numero;
                }
            }
            else
            {

                if (bi == false) 
                {
                    minInpar = numero;
                    bi = true;
                }
                else if (numero < minInpar)
                {
                    minInpar = numero;
                }
            }


        }
        Console.WriteLine("El par mas grande es: " + maxPar + " y el impar mas chico es: " + minInpar);