using System;

namespace GYM_people
{
    class Program
    {
        static void Main(string[] args)
        {

            float BMR = 0;
            float height = 0;
            float weight = 0;
            int age = 0;
            string gender = "";
            //all of the user inputs

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your hight: ");
                    height = float.Parse(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("Enter your hight not some random thing: ");
                }

                if (height <= 0)
                {
                    Console.WriteLine(".");
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your weight: ");
                    weight = float.Parse(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("Enter your weight not some random thing: ");
                }

                if (weight <= 0)
                {
                    Console.WriteLine(".");
                }
                else
                {
                    break;
                }
            }


            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your age: ");
                    age = int.Parse(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("Enter your age not some random thing: ");
                }

                if (age <= 0)
                {
                    Console.WriteLine(".");
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your gender M/F: ");
                    gender = Console.ReadLine();
                }

                catch
                {
                    Console.WriteLine("Enter your gender M/F not some random thing: ");
                }

                if (gender == "M")
                {
                    break;
                }
                else if (gender == "F")
                {
                    break;
                }
                else
                {

                }
            }





            Console.WriteLine("How much do you exercise");
            Console.WriteLine("1.little");
            Console.WriteLine("2.Light 1-3days a weeke");
            Console.WriteLine("3.Moderate 3-5 days a week");
            Console.WriteLine("4. Heavy 6-7 days a week");
            Console.WriteLine("5.Very heavy twice every day");
            string exercise = Console.ReadLine();

                


            //BMR calculations

            if (gender == "M")
            {
                float weight2 = (13.397f * weight);
                float height2 = (4.799f * height);
                float age2 = (5.677f * age);

                BMR = (88.362f + weight2 + height2 - age2);

                Console.WriteLine("Your BMR is " + BMR.ToString());
            }

            else if (gender == "F")
            {
                float weight2 = (9.247f * weight);
                float height2 = (3.098f * height);
                float age2 = (4.330f * age);

                BMR = (447.593f + weight2 + height2 - age2);

                Console.WriteLine("Your BMR is " + BMR.ToString("0.##"));

            }

            //BMI calculations


            float meaters = (height / 100);
            float heightX2 = (meaters * meaters);
            float BMI = (weight / heightX2);

            //BMI weight catogrys

            if (BMI <= 18.5)
            {
                Console.WriteLine("You are underweight");
            }
            if (BMI == 18.6 - 14.9)
            {
                Console.WriteLine("You are normal");
            }
            if (BMI == 25 - 29.9)
            {
                Console.WriteLine("You are overweight");
            }
            if (BMI >= 30)
            {
                Console.WriteLine("You are obesity");
            }

            Console.WriteLine("Your targer BMI is 22 you are " + BMI.ToString());

            //currant weight

            if (exercise == "1")
            {
                float BMR2;
                BMR2 = (BMR * 1.2f);
                Console.WriteLine(BMR2.ToString() + "kilocalories intake to keep currant weight");
                Console.ReadKey();
            }
            else if (exercise == "2")
            {
                float BMR2;
                BMR2 = (BMR * 1.375f);
                Console.WriteLine(BMR2.ToString() + "kilocalories intake to keep currant weight");
                Console.ReadKey();
            }
            else if (exercise == "3")
            {
                float BMR2;
                BMR2 = (BMR * 1.55f);
                Console.WriteLine(BMR2.ToString() + "kilocalories intake to keep currant weight");
                Console.ReadKey();
            }
            else if (exercise == "4")
            {
                float BMR2;
                BMR2 = (BMR * 1.725f);
                Console.WriteLine(BMR2.ToString() + "kilocalories intake to keep currant weight");
                Console.ReadKey();
            }
            else if (exercise == "5")
            {
                float BMR2;
                BMR2 = (BMR * 1.9f);
                Console.WriteLine(BMR2.ToString() + "kilocalories intake to keep currant weight");
                Console.ReadKey();
            }
        }
    }
}
