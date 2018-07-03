//  Projekt z Języków assemblerowych - Algorytm KMP
//  Autor: Tomasz Halemba
//  Semestr: 5
//  Sekcja: 8
//  Rok akademicki : 2017 / 2018

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;


namespace Ja_Projekt
{
    class DLLControler
    {

        [DllImport("CppDll.dll")]
        unsafe static extern void init_shift_cpp(int[] shift, string pattern, int dl);

        [DllImport("CppDll.dll")]
        unsafe static extern int kmp_cpp(int[] shift, string pattern, int n, string text);

        [DllImport("AsmDLL.dll")]
        unsafe static extern void init_shift_asm(int[] shift, string pattern, int dl);

        [DllImport("AsmDLL.dll")]
        unsafe static extern int kmp_asm(int[] shift, string pattern, int n, string text);


        public static uint Time;
        public static bool error;





        // function to calculate ammount of apperances of pattern in file, using cpp dll
        //
        // parameters:
        //
        // where - file location
        // pattern - pattern
        // check - variable that inform if algoryth should looks for full words or not
        //
        public static string Action_cpp(string Where, string pattern,bool check)
        {
            error = false;
            int tmp=0;
            var Timer = Stopwatch.StartNew();
            Timer.Restart();
            string checkTmp;
            if (check == false) checkTmp = "";
            else checkTmp = " ";
            pattern = checkTmp + pattern + checkTmp;
            int[] shift = new int[pattern.Length];
            init_shift_cpp(shift, pattern, pattern.Length);
            uint ammount = 0;
            string text = " ";
            try
            {

                using (StreamReader sr = new StreamReader(Where))
                {
                    while (sr.Peek() >= 0)
                    {

                        text = checkTmp + sr.ReadLine() + checkTmp;
                        shift[0] = text.Length;
                        tmp = kmp_cpp(shift, pattern, pattern.Length, text);
                        while (tmp != -1)
                        {
                            ammount++;
                            text = text.Remove(0, tmp);
                            shift[0] = text.Length;
                            tmp = kmp_cpp(shift, pattern, pattern.Length, text);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                error = true;
            }
            text = ammount.ToString();
            Timer.Stop();
            Time =(uint)Timer.ElapsedTicks;
            return text;
        }


        // function to calculate ammount of apperances of pattern in file, using asm dll
        //
        // parameters:
        //
        // where - file location
        // pattern - pattern
        // check - variable that inform if algoryth should looks for full words or not
        //
        public static string Action_asm(string Where, string pattern, bool check)
        {
            error = false;
            int tmp = 0;
            var Timer = Stopwatch.StartNew();
            Timer.Restart();
            string checkTmp;
            if (check == false) checkTmp = "";
            else checkTmp = " ";
            pattern = checkTmp + pattern + checkTmp;
            int[] shift = new int[pattern.Length];
            init_shift_asm(shift, pattern, pattern.Length);
            uint ammount = 0;
            string text = " ";
            try
            {

                using (StreamReader sr = new StreamReader(Where))
                {
                    while (sr.Peek() >= 0)
                    {
                        
                        text = checkTmp + sr.ReadLine() + checkTmp;
                        shift[0] = text.Length;
                        tmp = kmp_asm(shift, pattern, pattern.Length, text);
                        while (tmp != -1)
                        {
                            ammount++;
                            text = text.Remove(0, tmp);
                            shift[0] = text.Length;
                            tmp = kmp_asm(shift, pattern, pattern.Length, text);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                error = true;
                return e.Message;
            }
            
            text = ammount.ToString();
            Timer.Stop();
            Time = (uint)Timer.ElapsedTicks;
            return text;
        }
    }
}
