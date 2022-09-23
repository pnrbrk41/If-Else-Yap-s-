// See https://aka.ms/new-console-template for more information
using System;

    

	namespace If-Else-Yap-s-
	{


   class Program
   
   {
      static void Main (string[] args )
      {
         int time=DateTime.Now.Hour;

         if(time >=6 && time<11)
             Console.WriteLine( "Günaydın");

         else if(time<=18)
            Console.WriteLine("İyi günler");

        else
            Console.WriteLine("iyi geceler");

            string sonuc= time<=18 ? "iyi günler" : "iyi geceler";



      }

   }
}
