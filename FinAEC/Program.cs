using FinAEC;

const int year = 2022;
const int month = 7;
const int Day = 13;

var countDownAEC = new CountDownAEC(year, month, Day);

do
{
    Console.Clear();
    var timeLeft = countDownAEC.GetTimeLeft();
    var text = string.Empty;

    Console.WriteLine();
    var horizontalBar = "|";
    var verticalBar = "-------------------------------------------------------------------";
    var header = String.Format("{0,1} {1,7} {2,1} {3,8} {4,1} {5,6} {6,1} {7,7} {8,1} {9,10} {10,1} {11,10} {12,1}",
                            horizontalBar, "Year(s)",
                            horizontalBar, "Month(s)",
                            horizontalBar, "Day(s)",
                            horizontalBar, "Hour(s)",
                            horizontalBar, "Minutes(s)",
                            horizontalBar, "Seconds(s)",
                            horizontalBar);

    var body = String.Format("{0,1} {1,7} {2,1} {3,8} {4,1} {5,6} {6,1} {7,7} {8,1} {9,10} {10,1} {11,10} {12,1}",
                            horizontalBar, timeLeft.Item1,
                            horizontalBar, timeLeft.Item2,
                            horizontalBar, timeLeft.Item3,
                            horizontalBar, timeLeft.Item4.Hours,
                            horizontalBar, timeLeft.Item4.Minutes,
                            horizontalBar, timeLeft.Item4.Seconds,
                            horizontalBar);


    Console.WriteLine(verticalBar);
    Console.WriteLine(header);
    Console.WriteLine(verticalBar);
    Console.WriteLine(body);
    Console.WriteLine(verticalBar);

    System.Threading.Thread.Sleep(1000);
} while (true);

