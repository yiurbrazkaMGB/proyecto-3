using System;

namespace _3_practica
{
    class Program
    {
        static void Main(string[] args)
        {
             {
            // Declaracion de variables// 
            string dato = "";
            int TamañoPerro = 0;
            double peso = 0.0; 
            int actividadperro = 0; 
            int opcion = 0; 

            {
                // Requisitos//
             Console.WriteLine("Hola sea usted bienbenido a este programa que le ayudara a saber la cantidad de alimento de su perro. \n\n");
           
             Console.WriteLine("¿ cual es el peso de su perro ?: "); 
             Console.WriteLine(" 1 - entre 2-5 kg");
             Console.WriteLine(" 2 - entre 5-10 kg");
             Console.WriteLine(" 3 - entre 10-15 kg");
             Console.WriteLine(" 4 - entre 15-20 kg");
             dato = Console.ReadLine(); 
             peso = Convert.ToDouble(dato); 
            
           
             Console.WriteLine("¿ como concidera usted la actividad de su perro ?:");
             Console.WriteLine(" 1 - actividad de su perro es alta");
             Console.WriteLine(" 2 - actividad de su perro es normal");
             Console.WriteLine(" 3 - actividad de su perro es baja");
             dato = Console.ReadLine();
             actividadperro = Convert.ToInt32(dato);

             Console.WriteLine("¿ cual es el tamaño de su perro ?: "); 
             Console.WriteLine(" 1 - miniatura");
             Console.WriteLine(" 2 - pequeño");
             Console.WriteLine(" 3 - mediano");
             Console.WriteLine(" 4 - grande");
             dato = Console.ReadLine(); 
             TamañoPerro = Convert.ToInt32(dato); 

             //Tamaño miniatura
          
              if (peso <=5 && peso >=2)
              { 
                 switch ( actividadperro)
              {
                  case 1:
                            Console.WriteLine("Su perro debe comer entre 60 - 115 gramos de alimento.");
                            break;
                  case 2:
                            Console.WriteLine("Su perro debe comer entre 55 y 100 gramos.");
                            break;
                  case 3:
                            Console.WriteLine("Su perro debe comer entre 45 -85 gramos.");
                            break;
              }
           }  
                Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 4");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
                
                Console.Clear();
                
            }while(opcion != 4);
            
              // Tamaño pequeño
               if (peso >= 5 && peso <= 10)
               { 
                 switch ( actividadperro)
                 {
                  case 1:
                            Console.WriteLine("Su perro debe comer entre 115 y 190 gramos de alimento.");
                            break;
                  case 2:
                            Console.WriteLine("Su perro debe comer entre 100 y 170 gramos.");
                            break;
                  case 3:
                            Console.WriteLine("Su perro debe comer entre 85 y 145 gramos.");
                            break;
               }
                Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 4");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
                
                Console.Clear();
                
                
            }while(opcion != 4);

               //Tamaño mediano
             if (peso >=10 && peso <=15)
             { 
              switch ( actividadperro)
              {
                  case 1:
                            Console.WriteLine("Su perro debe comer entre 60 - 115 gramos de alimento.");
                            break;
                  case 2:
                            Console.WriteLine("Su perro debe comer entre 55 y 100 gramos.");
                            break;
                  case 3:
                            Console.WriteLine("Su perro debe comer entre 45 -85 gramos.");
                            break;
              }
                
                Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 4");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
                
                Console.Clear();
                
                
            }while(opcion != 4);
      
              // Tamaño Grande 
              if (peso >= 15 && peso <= 25)
              { 
              switch ( actividadperro)
              {
                  case 1:
                            Console.WriteLine("Su perro debe comer entre 225 y 380 gramos de alimento.");
                            break;
                  case 2:
                            Console.WriteLine("Su perro debe comer entre 225 y 330 gramos.");
                            break;
                  case 3:
                            Console.WriteLine("Su perro debe comer entre 195 y 285 gramos.");
                            break;
               }
             
                  Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 4");
                  dato = Console.ReadLine();
                  opcion = Convert.ToInt32(dato);
                
                  Console.Clear();
            }while(opcion != 4);
             
             if (peso >=25 &&  peso <= 40 )
                   { 
                   switch (actividadperro)
                   {
                    case 1:
                            Console.WriteLine("Su perro debe comer entre 380 - 535 gramos.");
                            break;
                    case 2:
                            Console.WriteLine("Su perro debe comer entre 330 - 475 gramos.");
                            break;
                    case 3:
                            Console.WriteLine("Su perro debe comer entre 285 - 400 gramos.");
                            break;
                  }

                  Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 4");
                  dato = Console.ReadLine();
                  opcion = Convert.ToInt32(dato);
                
                  Console.Clear();
            }while(opcion != 4);

                 if (peso >= 40 &&  peso <= 55 )
                  { 
                   switch ( actividadperro)
                  {
                    case 1:
                            Console.WriteLine("Su perro debe comer entre 535 - 680 gramos.");
                            break;
                    case 2:
                            Console.WriteLine("Su perro debe comer entre 475  600 gramos.");
                            break;
                    case 3:
                            Console.WriteLine("Su perro debe comer entre 410 - 520 gramos.");
                            break;
                 }
                  Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 4");
                  dato = Console.ReadLine();
                  opcion = Convert.ToInt32(dato);
                
                  Console.Clear();
            }while(opcion != 4);

                if (peso >= 55 &&  peso <= 70 )
                  { 
                   switch ( actividadperro)
                  {
                    case 1:
                            Console.WriteLine("Su perro debe comer entre  680 - 820 gramos.");
                            break;
                    case 2:
                            Console.WriteLine("Su perro debe comer entre 600 - 720 gramos.");
                            break;
                    case 3:
                            Console.WriteLine("Su perro debe comer entre  520 - 620 gramos.");
                            break;
                 }
                  Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 4");
                  dato = Console.ReadLine();
                  opcion = Convert.ToInt32(dato);
                
                  Console.Clear();
            }while(opcion != 4);
                
                 if (peso >= 70 &&  peso <= 90 )
                  { 
                   switch ( actividadperro)
                  {
                    case 1:
                            Console.WriteLine("Su perro debe comer entre   820 - 950 gramos.");
                            break;
                    case 2:
                            Console.WriteLine("Su perro debe comer entre  720 - 870 gramos.");
                            break;
                    case 3:
                            Console.WriteLine("Su perro debe comer entre   620 - 750 gramos.");
                            break;
                 }
                  Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 4");
                  dato = Console.ReadLine();
                  opcion = Convert.ToInt32(dato);
                
                  Console.Clear();
                }while(opcion != 4);

         
         Console.ReadKey(); 
        }
    }
 } 

} 
