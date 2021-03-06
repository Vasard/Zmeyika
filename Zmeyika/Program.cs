﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace Zmeyika
{
    class Program
    {
        public void game_draw()
        {
            Console.Clear();
            Console.Title = "Snake";
            Console.SetWindowSize(101, 26);
            HorizontalLIne upline = new HorizontalLIne(0, 100, 0, '+');
            HorizontalLIne downline = new HorizontalLIne(0, 100, 25, '+');
            VerticalLine leftline = new VerticalLine(1, 25, 0, '+');
            VerticalLine rightline = new VerticalLine(1, 25, 100, '+');
            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();
            Parametrs settings = new Parametrs();
            //Sounds sound = new sounds(settings.getresourcefolder());
            //sound.play("stardust.mp3");

            Point p = new Point(4, 5, '*', ConsoleColor.Red);
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(101, 26, '¤', ConsoleColor.Green);
            Point food = foodCreator.CreateFood();
            food.Draw();
            gg g = new gg(4, 5, '/', ConsoleColor.Black);
            kakashki_creator kakashkiCreator = new kakashki_creator(101, 26, '?', ConsoleColor.Black);
            gg kakashki = kakashkiCreator.CreateKakashki();
            kakashki.Draw();
            Score score = new Score(0, 1);//score =0, level=1
            score.speed = 800;
            score.ScoreWrite();
            while (true)
            {
                if (snake.Eat(food))
                {
                    score.ScoreUp();
                    score.ScoreWrite();
                    food = foodCreator.CreateFood();
                    food.Draw();
                    //sound.Stop("stardust.mp3");
                    if (score.ScoreUp())
                    {
                        score.speed -= 10;
                    }
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(score.speed);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }
                //if (snake.Eat())
                //{
                //    score.ScoreDown();
                //    score.ScoreWrite();
                //    kakashki = kakashkiCreator.CreateKakashki();
                //    kakashki.Draw();
                //    //sound.Stop("stardust.mp3");
                //    if (score.ScoreDown())
                //    {
                //        score.speed -= 10;
                //    }
                //}
                //else
                //{
                //    snake.Move();
                //}
            }
        }

        static void Main(string[] args)
        {
            Start start = new Start();
            if (start.choice() == 1)
            {
                Program prog = new Program();
                prog.game_draw();
            }
            else
            {
                start.Game_stop();
            }
            

            //Console.ReadLine();
        }

        
    }
}