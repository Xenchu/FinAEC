using FinAEC;

const int year = 2022;
const int month = 7;
const int Day = 13;

var countDownAEC = new CountDownAEC(year, month, Day);
var exit = true;
do
{
    Console.Clear();
    var timeLeft = countDownAEC.GetTimeLeft();
    var text = "Fin de l'A.E.C. - Développement d'application sécuritaires";

    Console.WriteLine(text);

    Console.WriteLine();
    var horizontalBar = "|";
    var verticalBar = "-------------------------------------------------------------------";
    var header = string.Format("{0,1} {1,7} {2,1} {3,8} {4,1} {5,6} {6,1} {7,7} {8,1} {9,10} {10,1} {11,10} {12,1}",
                            horizontalBar, "Year(s)",
                            horizontalBar, "Month(s)",
                            horizontalBar, "Day(s)",
                            horizontalBar, "Hour(s)",
                            horizontalBar, "Minutes(s)",
                            horizontalBar, "Seconds(s)",
                            horizontalBar);

    var body = string.Format("{0,1} {1,7} {2,1} {3,8} {4,1} {5,6} {6,1} {7,7} {8,1} {9,10} {10,1} {11,10} {12,1}",
                            horizontalBar, timeLeft.Years,
                            horizontalBar, timeLeft.Month,
                            horizontalBar, timeLeft.Days,
                            horizontalBar, timeLeft.Hours,
                            horizontalBar, timeLeft.Minutes,
                            horizontalBar, timeLeft.Seconds,
                            horizontalBar);


    Console.WriteLine(verticalBar);
    Console.WriteLine(header);
    Console.WriteLine(verticalBar);
    Console.WriteLine(body);
    Console.WriteLine(verticalBar);

    if (timeLeft.Years == 0 && timeLeft.Month == 0 && timeLeft.Days == 0 && timeLeft.Hours == 0 && timeLeft.Minutes == 0 && timeLeft.Seconds == 0)
        exit = false;

    Thread.Sleep(1000);
} while (exit);

