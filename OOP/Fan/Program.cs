using System;

namespace Fan
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan myFan = new Fan();
            myFan.Color = "DarkCyan";
            myFan.Speed = myFan.Slow;
            myFan.Radius = 10;
            myFan.TurnOn();
            myFan.FanStatus();
            myFan.TurnOff();
            myFan.FanStatus();





        }

        class Fan
        {
            public int Slow = 1;
            public int Medium = 2;
            public int Fast = 3;
            int speed = 1;
            private bool onOff = false;
            private double radius = 5;
            private string color = "blue";


            public Fan()
            {

            }
            public void FanStatus()
            {
                if (onOff)
                {
                    System.Console.WriteLine($"fan's speed :{speed}, color : {color}, radius: {radius} fan is on");
                }
                else
                {
                    System.Console.WriteLine($"fan's color {color}, radius: {radius} fan is off");
                }
            }
            public int Speed
            {
                get => speed;
                set => speed = value;
            }


            public string Color
            {
                get => color;
                set => color = value;
            }
            public double Radius
            {
                get => radius;
                set => radius = value;
            }
            public void TurnOn()
            {
                onOff = true;
            }
            public void TurnOff()
            {
                onOff = false;
            }

            public bool getStatus
            {
                get => this.onOff;
                set => onOff = value;
            }



        }
    }
}
