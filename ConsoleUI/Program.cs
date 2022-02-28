using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/**
 * 2/13/22
 * CSC 153 
 * Michael Smith
 * Basic Menu for game + file reader and character creator
 */

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            
            StreamReader inputRooms, inputWeapons, inputPotions, inputTreasures, inputItems, inputMobs;

            inputRooms = File.OpenText("Rooms.txt");
            inputWeapons = File.OpenText("Weapons.txt");
            inputPotions = File.OpenText("Potions.txt");
            inputTreasures = File.OpenText("Treasures.txt");
            inputItems = File.OpenText("Items.txt");
            inputMobs = File.OpenText("Mobs.txt");

            

            List<string> rooms = new List<string>();
            List<string> weapons = new List<string>();
            List<string> potions = new List<string>();
            List<string> treasures = new List<string>();
            List<string> items = new List<string>();
            List<string> mobs = new List<string>();

            while (!inputRooms.EndOfStream)
            {
                rooms.Add(inputRooms.ReadLine());
            }
            while(!inputWeapons.EndOfStream)
            {
                weapons.Add(inputWeapons.ReadLine());
            }
            while(!inputPotions.EndOfStream)
            {
                potions.Add(inputPotions.ReadLine());
            }
            while(!inputTreasures.EndOfStream)
            {
                treasures.Add(inputTreasures.ReadLine());
            }
            while(!inputItems.EndOfStream)
            {
                items.Add(inputItems.ReadLine());
            }
            while(!inputMobs.EndOfStream)
            {
                mobs.Add(inputMobs.ReadLine()); 
            }


            //Main menu

                while (exit == false)
            {

                Console.WriteLine("Choose a number from the list below: ");
                Console.WriteLine("1. Display Rooms");
                Console.WriteLine("2. Display Weapons");
                Console.WriteLine("3. Display Potions");
                Console.WriteLine("4. Display Treasure");
                Console.WriteLine("5. Display Items");
                Console.WriteLine("6. Display Mobs");
                Console.WriteLine("7. Create a Character");
                Console.WriteLine("8.Exit");
                Console.Write("Enter a choice > ");
                string input = Console.ReadLine();

                if (input == "1")
                {

                    Console.WriteLine();
                    foreach (string room in rooms)
                    { Console.WriteLine(room); }
                    Console.WriteLine();

                }

                else if (input == "2")
                {
                    Console.WriteLine();
                    foreach (string weapon1 in weapons)
                        Console.WriteLine(weapon1);
                    Console.WriteLine();
                }
                else if (input == "3")
                {
                    Console.WriteLine();
                    foreach (string potion in potions)
                    { Console.WriteLine(potion); }
                    Console.WriteLine();
                }
                else if (input == "4")
                {
                    Console.WriteLine();
                    foreach (string treasure in treasures)
                    { Console.WriteLine(treasure); }
                    Console.WriteLine();
                }
                else if (input == "5")
                {
                    Console.WriteLine();
                    foreach (string item in items)
                    { Console.WriteLine(item); }
                    Console.WriteLine();
                }
                else if (input == "6")
                {
                    Console.WriteLine();
                    foreach (string mob in mobs)
                    { Console.WriteLine(mob); }
                    Console.WriteLine();
                }

                else if (input == "7")
                {
                    try
                    {
                        StreamWriter characterFile;
                        int i = 0, i2 = 0, i3 = 0, raceIndex, weaponIndex, potionIndex;
                        string name, race, weapon, potion;
                        characterFile = File.CreateText("character.txt");
                        Console.WriteLine("Please type the name of your character: ");
                        name = Console.ReadLine();
                        characterFile.WriteLine(name);

                        Console.WriteLine("Please choose a race by choosing a number: ");
                        Console.WriteLine();
                        foreach (string mob1 in mobs)
                        {   
                            Console.WriteLine(i + "| " +mob1);
                            ++i;
                        }
                        raceIndex = int.Parse(Console.ReadLine());
                        race = mobs[raceIndex];
                        characterFile.WriteLine(race);
                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine("Please choose a weapon by choosing a number: ");
                        Console.WriteLine();
                        foreach (string weapon1 in weapons)
                        {
                            Console.WriteLine(i2 + "| " + weapon1);
                            ++i2;
                        }
                        weaponIndex = int.Parse(Console.ReadLine());
                        weapon = weapons[weaponIndex];
                        characterFile.WriteLine(weapon);
                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine("Please choose a potion by choosing a number: ");
                        Console.WriteLine();
                        foreach (string potion1 in potions)
                        {
                            Console.WriteLine(i3 + "| " + potion1);
                            ++i3;
                        }
                        potionIndex = int.Parse(Console.ReadLine());
                        potion = potions[potionIndex];
                        characterFile.WriteLine(potion);
                        Console.WriteLine();
                        Console.WriteLine();
                        characterFile.Close();
                    }
                    catch (Exception ex)
                    { Console.WriteLine(ex.Message); }

                }
                else if (input == "8")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a choice!");
                }
            }
        }
    }
}
