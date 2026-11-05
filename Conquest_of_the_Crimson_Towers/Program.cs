using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Conquest_of_the_Crimson_Towers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = @"   
   ______                                  __           ____   __  __            ______     _                               __                              
  / ____/___  ____  ____ ___  _____  _____/ /_   ____  / __/  / /_/ /_  ___     / ____/____(_)___ ___  _________  ____     / /_____ _      _____  __________
 / /   / __ \/ __ \/ __ `/ / / / _ \/ ___/ __/  / __ \/ /_   / __/ __ \/ _ \   / /   / ___/ / __ `__ \/ ___/ __ \/ __ \   / __/ __ \ | /| / / _ \/ ___/ ___/
/ /___/ /_/ / / / / /_/ / /_/ /  __(__  ) /_   / /_/ / __/  / /_/ / / /  __/  / /___/ /  / / / / / / (__  ) /_/ / / / /  / /_/ /_/ / |/ |/ /  __/ /  (__  ) 
\____/\____/_/ /_/\__, /\__,_/\___/____/\__/   \____/_/     \__/_/ /_/\___/   \____/_/  /_/_/ /_/ /_/____/\____/_/ /_/   \__/\____/|__/|__/\___/_/  /____/  
                    /_/                                                                                                                                     ";

            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine("(Stretch the title till its readable correctly, from that way on, play the game with that window size)");
            Console.WriteLine();
            Console.WriteLine("                                Press 'Enter' to start the game");

            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
                Console.Clear();
            else
                Environment.Exit(0);

            int hp = 100;
            int wr = 10;

            Console.Write("                                   Enter the name of your character: ");
            string name = Console.ReadLine();

            Console.Clear();

            string intro = $"{name} is a great warrior and a knight of Lord Hypnos himself, one day after a large and long lasting battle with a legion of Orcs, he came out alone but victorious, he ventured into the Forest of the Mist to find his way home";
            string[] introsplit = intro.Split(' ');
            foreach (var i in introsplit)
            {
                Console.Write(i + " ");
                Thread.Sleep(wr);

            }
            Console.WriteLine(@"                                                        ,
                                            .__ ._       \_.          
                                     _, _.  '  \/   \.-  /            
                                      \/     .-_`   // |/     \,      
                     .-""""""""-.          \.   '   \`. ||  \.-'  /       
                    F        Y        .-.`-(   _/\ V/ \\//,-' >-'   ._,
                   F          Y   .__/   `. \.   ' J   ) ./  / __._/  
                  J         \, I    '   _/ \  \  | |  / /  .'-'.-' `._,
           (       L   \_.--.| \_.      ' .___ `\: | / .--'.-'""     \ 
         \ '\    .  L   /    \\/        ._/`-.`  \ .'.' .'---./__   ' 
    \__  '\ ) \._/   `-.__. ` \\_. '   .---.  \     /  /  ,   `  `    
  --'  \\  ): // \,            `-.`__.'     `- \  /   / _/-.---.__.- . 
     _.-`.'/ /'\_, ._     >--.-""""'____.--""`_     '   /.'..' \   \   _/`
 _ .---._\ \'/ '__./__.-..  / .-|(    x_.-'___  |   :' /    _..---_' \
 .:' /`\ `. `..'.--'\      /.' /`-`._  `-,'   ` '   I '_.--'__--..___.--._.-
     `  `. `\/'/  _.   _.-'      _.____./ .-.--""""-. .-""    ' _..-.---'   \
  -._ .--.\ / /-./     /   .---'-//.___. .-'       \__ .--.  `    `.     '`-
 ,--'/.-. ^.   .-.--.  ` _/    _//     ./   _..   .'  `.    \ \    |_.
    /' | >.   ' | \._.-       '    _..'  `.' . `.       )    | |\  `          
  ./ \ \'  ) c| /  \     \_..  .--'    ,\ \_/`  :    )  (`-. `.|`\\            
   \'  / ,-.  | ` ./`  ._/ `\\'.--.,-((  `.`.__ |   _/   \    |)  `--._/`     
______'\   |  < __________  //'  //  _)   )/-._`.  (,-')  )  / \_.    /\. _____
a:f        |  |        .__./    //  '\  |//    `.\ '\ (  (  <`   ._  '
           >  |      _.  /   ..-\ _    _/ \_.  \ `\    \_ `---.-'__   
        . /  `-   _.'        /   `   _/|       J  /`     `-,,-----.`-.
            '  .:'          '`      '          < `   f  I //        `�\_,
              '                         \.     J        I/\_.        ./
         __/                            `:     I  .:    K  `          `
         \/ )                            `,   J         L             
          )_(_                             .  F  .-'    J             
         /    `.                           .  I  (.   . I _.-.._      
   '    <'    \ )                     _.---.J/      :'   L -'         
 .:.     \. _.->/                        _.-'_.)     ` `-.`---.,_.    
:<        (    \                    .--""""   .F' J) `.`L.__`-.___      
.:        |-'\_.|                          Y ..Z     ))   `--'  `-    
.         ) | > :                            . '    :'                
          / ) L_J                            .x,.
          L_J .,                             .:<.,  
        .'`   `                               :J.,` 
                                           . ;.+K,:.
                                               .,L+.,
    
                              press Enter to continue");

            var key2 = Console.ReadKey();
            if (key2.Key == ConsoleKey.Enter)
                Console.Clear();

            string paragraph = $"In the dense forest he saw a little silhouette of a man, Whom turned out to be an old man in a cloak";
            string[] paragraphsplit = paragraph.Split(' ');
            foreach (var i in paragraphsplit)
            {
                Console.Write(i + " ");
                Thread.Sleep(wr);

            }
            Console.WriteLine(@"
   . :   .::                .                        .                           
     .  ..-:                                                                    
     .   .:=.                                                                   
      .   .-=                                                                   
      .   .:--:-                       -::-==:-=:           -===:--==           
       ..  .:=+=:                  ..:=+==-:.::.. .-.       :--:...::           
        ..  .:-=+=.               ::==++---=-=-=-...::. .                       
         .   ::-++.             .:-=-:-:-=+*++**+-.  ::. .                      
         ..   :-=-             :.-*++=-:-=+*#**#*++:. .::.:                     
  :.      :   :===         : .: :+*--=---=+**##***++= .  :::                ..  
  .       .   :+=-.        . -.:=+*--=:-=++**####**+= .. .:-:                   
              .:-=:         -:.-+**:=-.:-=+=-=*+*++==: .  :-:.                  
           . .:=++:        --.:=**+:+....--=-::=*::::.  : .::..                 
           . .-=*+.      .-=:.-+**+==..:-+***=:=*++=-.  ....::.                 
           . .-+++.      :=- .=**+=+-::=++***=:+##*==:  .::.::..:               
           : .:==+.     :==  -+*+++*+++=-=*+:::+##**-:   .::::::                
           -  .-++.    .==: .=+*+=+**##**#+*=-::=*##*=:.  :-::::                
           :  :-++:   .==-  -+++++**#####%%*++++***+=-:.. .--:::                
---::::-   .. .-+*:  .-==   :+++++*###%####***+++****+--.. :---::       .:.::::.
++=-:-=+    . :-=*- .===.  ::=+++*###%#####%%#**####%**+=:  :-: :.      ::-===--
 .    ::. ..- .-+*-.+=+:    :=++++++*#%###%%%%#####%%###+=. :-: :.              
............- ..:-=+-==...  :=++++***#######%%%#########*-: ::  .:..            
............- .:=+*-==:.:.. .-+==*#**######*#%%%####*###*-- :.  ::::..          
............:..:-+*==: :------=+=***##%%%%#*#%%%###*####*-...:..:::::....       
.........::...-+-+*=--.:--=-===+=+***#%%%%###*#####****#=+--:. .+-::::..:.      
.........:.     .:--.:.:--====-++-+=+**###*#*+**###**+**=+-:. .:-::::::.::..    
........-.     ..:==.:  =---+--++:-==+*****+**+=+##**+*+=--.. ::-:::::..:....   
........        .:--=-  -=++=-=++:-=-=+*+**++*+-=*##+**----- .:--::..::.......  
........         ..:--.  -===+++::---==+*+*=+*=-:-+***+=--- ..:::..::.......... 
..::...:.        ..:-:   .:=-===::--:===+++=++-:-::+*++++-. .::..::.........:-. 
.......:..         ..:   ::::-:::--=========++-.::.---::::..::::::..............
.......:::         .::.  :-:::.  :::-::...--:-::.::.....  .:.:..:...............
.......--.         .:   ....:.   .-::.:   .:::--:........:..:..:........... ....
.....:--.      .  .--..  ::.  .....-:::-:.:...  ........:...-==-:::--..... .....
....:=-        .  .:=:  .:.    .    :. ..  ....::::.........--:::.:==...     ...
..:--:       ...  ..-- .:---:.     ...:....::::::.. ..:....:...  ....     . ....
:----       .:::   .--.  .:--::::.   ::......:..   .:....:.....             ....
--::       ..:::     ..    .::...............    ..............              ...
-::.      .. ..:.    .:    . ..               ......-.........              ::..
:..        ...      ..-:.      .:....................  .....                ....
..       ..  .:.     .-:::.                           ...                      .
.       ....  ..:.   .--.::..                                                   
       ... ..   ..   .:-  ...:....                                              
        .    ..- .    .-     ..... ....::                       :.              
                      .:.       ...    ...                                      
                      .:-           .                                           
                       .-.                                                      
 .                     .:.                                                .     
=--:.:-=                .. :                        -                   .:-:==-:
    :-:::.. .                                                       .           
    ****+--==                       press enter to continue                         :--:-::=:::    ");

            var key3 = Console.ReadKey();
            if (key3.Key == ConsoleKey.Enter)
                Console.Clear();


            string paragraph2 = $"The old man asked: 'Are you some warrior of sorts? perhaps one of Lord Hypnos?' you replied: 'Yes i am, im currently coming from a battle i have won.' The old man replied with: 'wouldn't it be nice to not serve a lord? To take power and make yourself lord? instead of being just his pawn?' You started to think and replied with: 'but how can i? i don't hold such power' and to this the old man replied: 'But i know how you can obtain such power.' you ask him to explain himself";
            string[] paragraphsplit2 = paragraph2.Split(' ');
            foreach (var i in paragraphsplit2)
            {
                Console.Write(i + " ");
                Thread.Sleep(wr);

            }


            Console.ReadKey();


        }
    }
}