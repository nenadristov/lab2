using System;

namespace DateValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int data, mesec, godina;
            string povtorno = "yes", rezultat=null;
            do
            {
                Console.WriteLine("Vnesi data");
                data = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Vnesi mesec");
                mesec = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Vnesi godina");
                godina = Convert.ToInt32(Console.ReadLine());

                if (mesec >= 1 && mesec <= 12)

                {
                    Console.WriteLine("Meseco tocen");
                    if (godina >= 0 && mesec <= 2099)
                    {
                        Console.WriteLine("Godina tocna");
                        if (data >= 1)
                        {
                            Console.WriteLine("Data tocna");
                            switch (mesec)
                            {
                                case 1:
                                case 3:
                                case 5:
                                case 7:
                                case 8:
                                case 10:
                                case 12:
                                    if (mesec <= 31)
                                    {
                                        if (mesec <= 9)
                                        {
                                            rezultat=($"{data}/0{mesec}/{godina}");
                                        }
                                        else
                                        {
                                            rezultat=($"{data}/{mesec}/{godina}");
                                        }
                                    }
                                    break;

                                case 4:
                                case 6:
                                case 9:
                                case 11:
                                
                                    if (data <= 30)
                                    {
                                        if (mesec <= 9)
                                        {
                                            rezultat=($"{data}/0{mesec}/{godina}");
                                        }
                                        else
                                        {
                                            rezultat=($"{data}/{mesec}/{godina}");
                                        }
                                    }
                                    break;
                                case 2:
                                    if((godina % 4 ==0 && godina % 100 !=0)||godina % 400 == 0)
                                    {
                                        rezultat=($"{data}/0{mesec}/{godina}");
                                        
                                    }
                                    break;
                            }




                            string mesec_text;
                            switch (mesec)
                            {
                                case 1: mesec_text = "January"; break;
                                case 2: mesec_text = "February"; break;
                                case 3: mesec_text = "March"; break;
                                case 4: mesec_text = "April"; break;
                                case 5: mesec_text = "May"; break;
                                case 6: mesec_text = "June"; break;
                                case 7: mesec_text = "July"; break;
                                case 8: mesec_text = "August"; break;
                                case 9: mesec_text = "September"; break;
                                case 10: mesec_text = "October"; break;
                                case 11: mesec_text = "November"; break;
                                case 12: mesec_text = "December"; break;
                                default: mesec_text = "Not Known"; break;    // Should never happen
                            }

                            String nastavka;
                            switch (data)
                            {
                                case 1:
                                case 21:
                                case 31:
                                    nastavka = "st";
                                    break;

                                case 2:
                                case 22:
                                    nastavka = "nd";
                                    break;

                                case 3:
                                case 23:
                                    nastavka = "rd";
                                    break;

                                default:
                                    nastavka = "th";
                                    break;
                            }
                            if (rezultat != null)
                            {
                                String formattedDate = string.Format($"{data}{nastavka} {mesec_text} {godina}");
                                Console.WriteLine("Valid date: {0}", formattedDate);
                            }
                            
                        }
                    }
                    
                }
               
                Console.WriteLine("Dali sakate povtorno da vnesete data \n dokolku sakate napisete 'yes'");
                povtorno = Console.ReadLine();
            }
            while (povtorno.ToLower() == "yes");
            Console.WriteLine(povtorno);


        }
    }
}
