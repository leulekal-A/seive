using System;
using System.IO;
namespace Journal
{
   class Journalholder
   {
      public static void Main(string[] args)
      {
          Console.WriteLine(" please Type  start the  to start writing in a journal");
          
             Console.WriteLine("Type: 'stop'  to stop  writing in a journal");
             
               Console.WriteLine("please Type exit to exit");

         string usertext
         , journaltext = "";  

             while(true)
         {
           
            while(true)
            {
               Console.Write("> "); usertext = Console.ReadLine();
               if (usertext == "start"){break;}
              
            
               else if (usertext == "exit") {  return; }
            }
               
             while(true)

            {
               Console.Write("> ");
               usertext  = Console.ReadLine();
               if (usertext == "stop")
               {
                  break;
               }
               journaltext += usertext + "\n";
            }

            using (StreamWriter sw = new StreamWriter("./"+DateTime.UtcNow.Date.ToString("dd_MM_yyyy")+".txt"))
            { 
               try { 
               
            sw.WriteLine("Captain's log"); 
                               sw.WriteLine("Stardate " + DateTime.UtcNow.Date.ToString("dd-MM-yyyy")); 
                              sw.Write(journaltext);
                  sw.Write("Jean-Luc Picard");
               }
               catch(Exception e)
               {
                  Console.WriteLine("Failed to write to my space journal. It said {0}", e.Message);
               }
          }
          }
       }
     }
}