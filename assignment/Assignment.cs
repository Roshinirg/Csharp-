using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10nov2018
{
    class Program
    {
       static int Total_scoreof_team1 = 0;
        static int Total_scoreof_team2 = 0;
        static string[] Team1_Playersname = new string[5];
        static int[] Team1_Score = new int[5];
        static string[] Team2_Playersname = new string[5];
        static int[] Team2_Score = new int[5];
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of team1");
            string Team1_Name = Console.ReadLine();
            Console.WriteLine("Enter the name of team2");
            string Team2_Name = Console.ReadLine();

            team1details();
            team2details();
            

           if(Total_scoreof_team1> Total_scoreof_team2)
            {
                Console.WriteLine("Winner is" + Team1_Name );
            }
            else
            {
                Console.WriteLine("Winner is" + Team2_Name );
            }
            int a= Team1_Score.Max();
            int b = Team2_Score.Max();
            int man_of_the_team1= Array.IndexOf(Team1_Score, a);
            int man_of_the_team2 = Array.IndexOf(Team2_Score, b);
            Console.WriteLine("Man of the team of " + Team1_Name+" is "+Team1_Playersname[man_of_the_team1]);
            Console.WriteLine("Man of the team of " + Team2_Name + " is " + Team2_Playersname[man_of_the_team2]);
            if(man_of_the_team1> man_of_the_team2)
            {
                Console.WriteLine("Man of the match is " + Team1_Playersname[man_of_the_team1]);
            }
            else
            {
                Console.WriteLine("Man of the match is " + Team2_Playersname[man_of_the_team2]);
            }
            int Avg_run_ofteam1= Total_scoreof_team1/5;
            int Avg_run_ofteam2 = Total_scoreof_team2 / 5;
            Console.WriteLine("average runs of " + Team1_Name +" is "+ Avg_run_ofteam1);
            Console.WriteLine("average runs of " + Team2_Name + " is " + Avg_run_ofteam2);
            Console.ReadLine();
 
        }

        static void team1details()
        {
            
            
            for (int i = 0; i < Team1_Playersname.Length; i++)
            {
                Console.WriteLine("Enter team1 player "+(i+1)+ " name");
                Team1_Playersname[i] = Console.ReadLine();

                Console.WriteLine("Enter "+ Team1_Playersname[i] + "'s scores");
                Team1_Score[i] = Convert.ToInt32(Console.ReadLine());
                Total_scoreof_team1 = Total_scoreof_team1 + Team1_Score[i];
            }
            
        }

        static void team2details()
        {
            
            
            Console.WriteLine("Enter team2 player datails");
            for (int i = 0; i < Team2_Playersname.Length; i++)
            {
                Console.WriteLine("Enter team2 player" + (i + 1) + " name");
                Team2_Playersname[i] = Console.ReadLine();
                Console.WriteLine("Enter team2  player" + Team2_Playersname[i] + "'s scores");
                Team1_Score[i] = Convert.ToInt32(Console.ReadLine());
                Total_scoreof_team2 = Total_scoreof_team2 + Team1_Score[i];
            }


        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC
{
    class Program
    {
        static string[] Coursename = new string[3];
        static int[] course_fee = new int[3];
        static int[] duration = new int[3];
        static string[] student_name = new string[3];
        static string[] course_selected = new string[3];
        
        static void Main(string[] args)
        {


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter course " + (i + 1) + " name");
                Coursename[i] = Console.ReadLine();
                Console.WriteLine("Enter fee for " + Coursename[i]);
                course_fee[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter duration(hrs) of " + Coursename[i]);
                duration[i] = Convert.ToInt32(Console.ReadLine());

            }
            while (true)
            {
                Console.WriteLine("1. Course Information");
                Console.WriteLine("2. Join New  student");
                Console.WriteLine("3. Joined Information");
                Console.WriteLine("4. Fee Collection information");
                Console.WriteLine("5. Exit");


                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Course_information();
                        break;
                    case 2:
                        Join_new_student();
                        break;
                    case 3:
                        Joined_information();
                        break;
                    case 4:
                        Fee_collection_inforamtion();
                        break;
                    default:
                        System.Environment.Exit(1);
                        break;
                }
            }

        }
        static void Course_information()
        {
            Console.WriteLine("Course informations");
            Console.WriteLine("      CourseName       Fee      Duration(hrs)");
            Console.WriteLine(" 1. " + Coursename[0] + "    " + course_fee[0] + "   " + duration[0]);
            Console.WriteLine(" 2. " + Coursename[1] + "    " + course_fee[1] + "   " + duration[1]);
            Console.WriteLine(" 3. " + Coursename[2] + "    " + course_fee[2] + "   " + duration[2]);
             
            Console.ReadLine();
        }
        static void Join_new_student()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("name=");
                student_name[i] = Console.ReadLine();
                Console.WriteLine("course=");
                course_selected[i] = Console.ReadLine();
                
                Console.WriteLine("fee="+ course_fee[i]);
               
            }

        }
        static void Joined_information()
        {
            Console.WriteLine("Student joined informations");
            Console.WriteLine("      studentName             Course                Fee");
            Console.WriteLine(" 1. " + student_name[0] + "    " + course_selected[0] + "   " + course_fee[0]);
            Console.WriteLine(" 2. " + student_name[1] + "    " + course_selected[1] + "   " + course_fee[1]);
            Console.WriteLine(" 3. " + student_name[2] + "    " + course_selected[2] + "   " + course_fee[2]);
        }
        static void Fee_collection_inforamtion()
        {
            int sum_of_fee = 0;
            Console.WriteLine("Fee Collection informations");
            Console.WriteLine("      studentName       Fee ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine( (i+1)+". "+ student_name[i] + "   " + course_fee[i]);
                sum_of_fee = sum_of_fee + course_fee[i];
            }
            Console.WriteLine("   Total Fee=" + sum_of_fee);
        }

    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static int choice;
        static int[] DocId = new int[3];
        static string[] DocName = new string[3];
        static string[] DocSpecialize = new string[3];
        static string[] DocSymptoms = new string[3];
        static int[] PatientId = new int[3];
        static string[] PatientName = new string[3];
        static string[] PatientDisease = new string[3];
        

        static void Main(string[] args)

        {
            while (true)
            {
                Console.WriteLine("Enter 1 for doctor's details");
                Console.WriteLine("Enter 2 for patient's details");
                Console.WriteLine("Enter 3 for new patient details");
                Console.WriteLine("Enter 4 to exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        doctor_details();
                        break;
                    case 2:
                        patient_details();
                        break;
                    case 3:
                        new_details();
                        break;
                    default:
                        System.Environment.Exit(1);
                        break;
                }
            }
        }
        static void doctor_details()
        {
            DocId[0] = 1;
            DocId[1] = 2;
            DocId[2] = 3;
            DocName[0] = "abc";
            DocName[1] = "mno";
            DocName[2] = "xyz";
            DocSpecialize[0] = "ENT";
            DocSpecialize[1] = "cardio";
            DocSpecialize[2] = "radio";
           
            Console.WriteLine("Doctor's details");
            Console.WriteLine("ID    Name        Specialisation");
            for (int i = 0; i <3; i++)
            {
                Console.WriteLine(DocId[i] + "            " + DocName[i] + "                 " + DocSpecialize[i]);
            }
            Console.ReadLine();
        }
        static void patient_details()
        {
            PatientId[0] = 1;
            PatientId[1] = 2;
            PatientId[2] = 3;
            PatientName[0] = "aaa";
            PatientName[1] = "bbb";
            PatientName[2] = "ccc";
            PatientDisease[0] = "cold";
            PatientDisease[1] = "fever";
            PatientDisease[2] = "cough";
      
            Console.WriteLine("Patient's details");
          
            Console.WriteLine("Enter Patient ID");
            int Patientchoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ID    Name        PatientDisease");
            Console.WriteLine(PatientId[Patientchoice-1] + " " + PatientName[Patientchoice-1] + "  " + PatientDisease[Patientchoice-1]);
                Console.ReadLine();
        }
      static void  new_details()
        {

            DocId[0] = 1;
            DocId[1] = 2;
            DocId[2] = 3;
            DocName[0] = "abc";
            DocName[1] = "mno";
            DocName[2] = "xyz";
            DocSpecialize[0] = "ENT";
            DocSpecialize[1] = "cardio";
            DocSpecialize[2] = "radio";
            Console.WriteLine("Enter new patient details");
            Console.WriteLine("Name=");
            string New_Patient_Name = Console.ReadLine();
            Console.WriteLine("Age=");
            string New_Patient_Age = Console.ReadLine();
           
                Console.WriteLine("1.Cold");
                Console.WriteLine("2.Cough");
                Console.WriteLine("3.Fever");
                int Choice_Disease = Convert.ToInt32(Console.ReadLine());

                switch (Choice_Disease)
                {
                    case 1:
                        Console.WriteLine("ID    Name        Specialisation");
                        Console.WriteLine(DocId[Choice_Disease - 1] + "      " + DocName[Choice_Disease - 1] + "         " + DocSpecialize[Choice_Disease - 1]);
                        break;
                    case 2:
                        Console.WriteLine("ID    Name        Specialisation");
                        Console.WriteLine(DocId[Choice_Disease - 1] + "       " + DocName[Choice_Disease - 1] +"         " + DocSpecialize[Choice_Disease - 1]);
                        break;
                    case 3:
                        Console.WriteLine("ID    Name        Specialisation");
                        Console.WriteLine(DocId[Choice_Disease - 1]+ "        "+ DocName[Choice_Disease - 1] +"         " + DocSpecialize[Choice_Disease - 1]);
                        break;
                    default:
                        Console.WriteLine("Invalid ");
                        break;
                }
                Console.ReadLine();
            
        }
    }

}
