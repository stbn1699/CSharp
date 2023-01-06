using System.Timers;
using Timer = System.Timers.Timer;
bool gameOver = false;
int ammo = 4;
bool shot = false;
int stageHeight = 10;
bool characterUp = false;
bool characterDown = false;
int characterPosition = stageHeight / 2;
int menuHeight = 9;
int defaultAmmoPosition = 2;
int defaultEnemyPosition = 50;
List<Ammo> ammoList = new List<Ammo>();
List<Enemy> enemyList = new List<Enemy>();


Timer ammoTimer = new Timer();
ammoTimer.Elapsed += new ElapsedEventHandler(AmmoPosition);
ammoTimer.Interval = 100;
ammoTimer.Start();
Timer enemyTimer = new Timer();
enemyTimer.Elapsed += new ElapsedEventHandler(EnemyPosition);
enemyTimer.Interval = 150;
enemyTimer.Start();
Timer enemySpawn = new Timer();
enemySpawn.Elapsed += new ElapsedEventHandler(EnemySpawn);
enemySpawn.Interval = 500;
enemySpawn.Start();

Console.CursorVisible = false;

while (!gameOver)
{
    Console.Clear();
    if (shot)
    {
        if (ammo == 0) {
            Console.Clear();
            Console.WriteLine("vous avez perdu, plus aucune balle restante");
            gameOver = true;
        }
        else
        {
            ammoList.Add(new Ammo(characterPosition, defaultAmmoPosition));
            ammo--;
            shot = false;
            NewFrame();
        }
    }
    if (characterUp && characterPosition > 0)
    {
        characterPosition--;
        characterUp = false;
        NewFrame();
    }
    
    if (characterDown && characterPosition < stageHeight)
    {
        characterPosition++;    
        characterDown = false;
        NewFrame();
    }
    /* display frame */


    NewFrame(); 
    GetInput();
}


void NewFrame()
{
    /* whipe old frame */
    Console.Clear();
         
    /* game name */
    GameName();

    /* display ammo amount */
    Console.WriteLine();
    for(int i = 0; i < ammo; i++)
    {
        Console.Write(" |");
    }
    Console.WriteLine();
        
    /* character position */
    for (int i = 0; i <= stageHeight; i++)
    {
        if (i == characterPosition)
        {
            Console.WriteLine(">");
        }
        else
        {
            Console.WriteLine();
        }
    }
    Console.WriteLine();
    
    /* display shot ammo */
    foreach (var currentAmmo in ammoList)
    {
        Console.SetCursorPosition(currentAmmo.XPos, currentAmmo.YPos + menuHeight);
        Console.Write("=->");
    }
    foreach (var currentEnemy in enemyList)
    {
        Console.SetCursorPosition(currentEnemy.XPos, currentEnemy.YPos + menuHeight);
        Console.Write("--<");
    }
}
void GetInput()
{
    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.Backspace:
            ExitGame();
            break;
        case ConsoleKey.Spacebar:
            shot = true;
            break;
        case ConsoleKey.UpArrow:
            characterUp = true;
            break;
        case ConsoleKey.DownArrow:
            characterDown = true;
            break;
        case ConsoleKey.Enter:
            NewFrame();
            break;
    }
}
void ExitGame()
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("vous quittez le jeu");
    Console.WriteLine();
    gameOver = true;
}
void GameName()
{
    Console.WriteLine(@"
        ███╗   ███╗██╗███╗  ██╗██╗ ██████╗  █████╗ ███╗   ███╗███████╗ ██████╗
        ████╗ ████║██║████╗ ██║██║██╔════╝ ██╔══██╗████╗ ████║██╔════╝██╔════╝
        ██╔████╔██║██║██╔██╗██║██║██║  ██╗ ███████║██╔████╔██║█████╗  ╚█████╗ 
        ██║╚██╔╝██║██║██║╚████║██║██║  ╚██╗██╔══██║██║╚██╔╝██║██╔══╝   ╚═══██╗
        ██║ ╚═╝ ██║██║██║ ╚███║██║╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗██████╔╝
        ╚═╝     ╚═╝╚═╝╚═╝  ╚══╝╚═╝ ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝╚═════╝ ");
}
void AmmoPosition(object? sender, ElapsedEventArgs elapsedEventArgs)
{
    foreach (var currentAmmo in ammoList)
    {
        currentAmmo.XPos += 1;
        NewFrame();
    }
}
void EnemyPosition(object? sender, ElapsedEventArgs elapsedEventArgs)
{
    foreach (var currentEnemy in enemyList)
    {
        currentEnemy.XPos -= 1;
        NewFrame();
    }
}
void EnemySpawn(object? sender, ElapsedEventArgs elapsedEventArgs)
{
    Random rand = new Random(stageHeight);
    int position = rand.Next();
    enemyList.Add(new Enemy(position, defaultEnemyPosition));
}


class Ammo
{
    public int YPos { get; set; }
    public int XPos { get; set; }

    public Ammo(int yPos, int xPos)
    {
        YPos = yPos;
        XPos = xPos;
    }
}
class Enemy
{
    public int YPos { get; set; }
    public int XPos { get; set; }

    public Enemy(int yPos, int xPos)
    {
        YPos = yPos;
        XPos = xPos;
    }
}