﻿using System;
using System.Collections.Generic;
using System.Linq;
using PokeAPI;
using System.Threading.Tasks;

namespace PokemonSimulator
{
    public class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            UserAuthAndLogin loginStart = new UserAuthAndLogin();
            System.GC.Collect();
            Trainer CurrentTrainer = new Trainer();
            CurrentTrainer.UserId = loginStart.UserID;
            CurrentTrainer.TrainerName = loginStart.TrainerName;

            TrainerLineUp Lineup = new TrainerLineUp(CurrentTrainer.UserId, CurrentTrainer.TrainerName, loginStart.Connection.myConnection);
            //DBconnect con = new DBconnect();
            //var CurrentTrainer = new Trainer() { TrainerName = "Misty", UserId = 10 };
            //var lineup = new TrainerLineUp(CurrentTrainer.UserId, CurrentTrainer.TrainerName, con.myConnection);

            while (Lineup.LoopStuck == true)
            {
                Console.WriteLine("Would you like to leave? type 'exit'\nOr press any key to continue");
                string exitChoice = Console.ReadLine();

                if (exitChoice.ToLower().Equals("exit"))
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    loginStart = new UserAuthAndLogin();
                    System.GC.Collect();
                    CurrentTrainer = new Trainer();
                    CurrentTrainer.UserId = loginStart.UserID;
                    CurrentTrainer.TrainerName = loginStart.TrainerName;

                    Lineup = new TrainerLineUp(CurrentTrainer.UserId, CurrentTrainer.TrainerName, loginStart.Connection.myConnection);
                }
            }
            TrainerLineUp DupeLineUp = new TrainerLineUp(CurrentTrainer.UserId, CurrentTrainer.TrainerName, loginStart.Connection.myConnection);

            CurrentTrainer = Lineup.GhostTrainer;
            System.GC.Collect();

            //Console.WriteLine("Let's Battle! ");
            GameMockup.GameEngine(CurrentTrainer, DupeLineUp.GhostTrainer);
        }      
    }
}