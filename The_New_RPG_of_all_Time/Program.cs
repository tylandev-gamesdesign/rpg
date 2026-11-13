
using System;
using System.Reflection.PortableExecutable;
using The_New_RPG_of_all_Time;

string[] attacks3 = { "Fireball", "Lightning", "Ice Beam", "Giga Fire", "Thunderstorm", "Snowgrave" };
string[] attacks2 = { "Heal", "Revive", "Raise Hell", "Panacea", "Ultra Revive", "True Necromancy" };
string[] attacks = { "Fireball", "Lightning", "Ice Beam", "Giga Fire", "Thunderstorm", "Snowgrave" };

Console.WriteLine("write your name for this amazing game that will knock your socks off.");
            string myName = Console.ReadLine();

            Console.WriteLine("Welcome to this amazing incredible lovely awesome phenomenal cool cooler coolest game, " + myName);
            Console.WriteLine("but hold your horses! you need to make party member names, silly billison. do the first one first because if you do the second one first i'd flip out.");
            string myName2 = Console.ReadLine();

            Console.WriteLine("FIRST new party member is.... " + myName2);
            Console.WriteLine("you should do the OTHER other party member, y'know.. THAT guy. theyre weird.");
            string myName3 = Console.ReadLine();

            Console.WriteLine("Welcome, i GUESS.. " + myName3);
            Console.WriteLine(@"       
                                    *@@-              
                                   .*@=@#          
                                  :%@@@%@:         
                                  .-.-@+@+          
                                     =@:#@.     
                                     %%.*@:           
                                .:. =@= =@-           
                              .#@@@-+@: =@-::.        
                            .+@#..:@@@@@@@@@@.        
                    -@@%@@%%@#-.    .....  :@%=..                     .-.                               .#%:       
                     =@:     .:+%#+==+#%+:.  -#%%%@@.              .:*@@@=.                             ++.*+.     
                     .*@=.  **:.        .:#+      +@            .+%@@+..=@@-                          .#+.  -%:    
                      .-@%+*.              .#-    -@@*=.    :#@@#+:.  ::..+@%+:.                    .*+       -**:
                        .%@%-:.              *+.  ..=@@:   .#@. ..+%*-  :=##-+%@@@#:..            .-#.    ..... .+@*=:.         
                        -*::+@=%@@%%#.-%%*-:  *: .+@%:.    .#% .#-.         .*+ ..-#@*           .#-.  .*#=:::-##:  ..-%:         
                        +:  .*#=..:.+%@=-+*##@@@@@*:       .#@=#.             -%..*@+.         -%*.  .#+.       .-%:  *+        
                        *.   ...:-=+=  :----:.-*            =@*                :*@@:            .#-.:@:       .-.  #::%.      
                        +:  .#@#*=-#@  +===@# =+            .@#                .#@:              .-%%: =%%.   *+%- :#:#          
                        :#.       .@#     :@* #:             %# .:=*:-%-       .*-                .%% \@  #.  *  +/  %#         
                         =#.       =.     .# %-              +@#@@#%@@@@-.:+%@=.#                :%:#.             .@.*+. 
                          :#-              -#.               .#=:.            @%=               =#: =#             =+ .*=
                            -#=.   .--:..=#-                  .%-          .##-           ..=#=    =*    #*+   .+*.   :#=
                              .-@@%##%@@-                       -@=     V  ..#*.           .:@=........=@*.. :...=%*%=..  .+#..  
                              .*@-.   =@-                         .-#%####%-.             .::--------:. .:*#*+=-%-  .-*#*+==%+ 
                             .#@@:    .#@-.                        .@#   -@=                           .=%%.    =+  
                            :@@*@:     .*@=                       *@@-   -@=                        .+@--%      .*
                           =@* +@:      .*@.                    :@%%%:   :@@:                    .*#-.  #.      .*
                          .%%. +@:       .#@:                 .-@#.%%.   .%@%.                .=%=.    -*.      .*.            
                          -@=  +@:        -@+.               .*@+..%%.    =@@=      ..-@@@@@*@=.      :@:        ++             
                          -@-  =@=        .@#.               *@@@=:@*     .#@@%*=:.:@@@@@@@@@:        +@##*=--::::.            
                          :@#  -@+.        *%.              .+**:.:@+      =@=:=*##@@@@@@@@@%.
                          .#@- .@*.        *@.                    :@+      -@=     .+*-.       
                           .=@%@@@#: ......:@=                    :@%%@@@@%#=.                
                            :@@@@@@%%%######@=                     ...     
                            :@@@#:.            
        the RPG of all time");

 string[] Bosses = { "Slime", "Thief royal advisor", "Thief Prince", "King Of Thieves", "Angry Mob", "Traitorous Knight", "Angrier Mob", "Traitorous Elite", "Angriest Mob", "Mob Leader", "Corrupt TaxMan", "Corrupt Princess", "Corrupt Prince", "Corrupt King", "The Mage", "Defence API", "Narrator outer shell", "King_Of_Thieves.exe", "Narrator inner shell", "Mob_Leader.exe", "Narrator Core Armour", "Corrupt_King.exe", "Narrator Soul OS" };
 int[] Enemiers = { 50, 75, 100, 125, 150, 175, 200, 225, 250, 275, 300, 325, 350, 375, 400, 425, 450, 475, 500, 525, 550, 575, 600 };
//public string[] Bosses2 = { "Slime.EXE", "Thief royal advisor.EXE", "Thief Prince.EXE", "King Of Thieves.EXE", "Angry Mob.EXE", "Traitorous Knight.EXE", "Angrier Mob.EXE", "Traitorous Elite.EXE", "Angriest Mob.EXE", "Mob Leader.EXE", "Corrupt TaxMan.EXE", "Corrupt Princess.EXE", "Corrupt Prince.EXE", "Corrupt King.EXE", "The Mage.EXE", "Defence API.EXE", "The Sheep" };
//public int[] BossesHP2 = { 625, 650, 675, 700, 725, 750, 775, 800, 825, 850, 875, 900, 925, 950, 975, 1000, 1025 };


//dodging
//attack


var Enemeys = new Monsters();
Enemeys.Bosses = Bosses[0];
Enemeys.Enemiers = Enemiers[0];
Enemeys.Health = types.random.Next(30, 40);
Enemeys.Damage = types.random.Next(30, 40);
Enemeys.MP = types.random.Next(30, 40);
Enemeys.Defense = types.random.Next(30, 40);

var Character = new char1();
Character.Name = myName;
Character.Level = 1;
Character.Health = types.random.Next(30, 40);
Character.Damage = types.random.Next(30, 40);
Character.MP = types.random.Next(30, 40);
Character.Defense = types.random.Next(30, 40);
Character.XP = types.random.Next(5, 11) * Character.Level;


Console.WriteLine("Which attack will you use choose?");
Console.WriteLine("You can choose :");
//int i = 0;
// {"Slash", "Spin Slash", "Explosion","Mega Slash", "Super Spin Slash", "Tower Of Flame"};


for (int i = 0; i < Character.Level; i++)
{
    Console.WriteLine(i + " " + attacks[i]);

}
Console.WriteLine("Select now");
    
int attachchoice = Convert.ToInt32(Console.ReadLine());

var Character2 = new char2();
Character2.Name = myName2;
Character2.C2Level = 1;
Character2.C2Health = types.random.Next(20, 30);
Character2.C2Damage = types.random.Next(20, 30);
Character2.C2MP = types.random.Next(40, 50);
Character2.C2Defense = types.random.Next(10, 20);
Character2.C2XP = types.random.Next(5, 11) * Character.Level;
for (int i = 0; i < Character2.C2Level; i++)
{
    Console.WriteLine(i + " " + attacks2[i]);

}
Console.WriteLine("Select now");

int attachchoice2 = Convert.ToInt32(Console.ReadLine());
var Character3 = new char3();
Character3.Name = myName3;
Character3.C3Level = 1;
Character3.C3Health = types.random.Next(10, 30);
Character3.C3Damage = types.random.Next(30, 50);
Character3.C3MP = types.random.Next(60, 90);
Character3.C3Defense = types.random.Next(10, 20);
Character3.C3XP = types.random.Next(5, 11) * Character.Level;
for (int i = 0; i < Character3.C3Level; i++)
{
    Console.WriteLine(i + " " + attacks3[i]);

}
Console.WriteLine("Select now");

int attachchoice3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("you attack with a "+ attachchoice +", " + attachchoice2 + " and "+ attachchoice3);

int damage1 = Character.Damage * Character.Level;
int damage2 = Character2.C2Damage * Character2.C2Level;
int damage3 = Character3.C3Damage * Character3.C3Level;
int totalDamage = damage1 + damage2 + damage3;

Console.WriteLine("you deal the monster damage: " + damage1 + ", " + damage2 + " and " + damage3);

Enemeys.Health = Enemeys.Health - totalDamage;

if (Enemeys.Health <=0)
{
    Console.WriteLine("The monster is dead");

}
else
{
    Console.WriteLine("Monster's health is : " + Enemeys.Health);
}


