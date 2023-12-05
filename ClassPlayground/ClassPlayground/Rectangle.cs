using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
     /*
        1) Vytvoř třídu Rectangle, kterou budeme reprezentovat obecný obdélník
     * Přidej třídě Rectangle dvě proměnné - width a height(datový typ nechám na tobě)
     * Přidej třídě Rectangle tři funkce - CalculateArea, která spočítá obsah plochy obdélníka
     *                                      - CalculateAspectRatio, která spočítá poměr stran.Využij spočítaný poměr k určení toho, jestli je obdélník široký, vysoký, nebo je to čtverec
     *                                      - ContainsPoint, která jako vstupní parametr přijme souřadnice x, y nějakého bodu a určí, jestli se daný bod nachází v obdélníku, nebo ne,
     *                                        a podle toho vrátí true/false
     *    Přidej třídě Rectangle konstruktor, který bude přijímat dva parametry - šířku a výšku, a při jeho zavolání je správně nastaví
     *
     * 1) BONUS - Až vytvoříš Rectangle, zkus vytvořit obdobnou třídu se stejnou funkcionalitou pro kruh nebo třeba trojúhelník.
     * 
     */
    internal class Rectangle
    {
        public int width;
        public int height;

        public Rectangle (int width, int height) // konstruktor
        {
            this.width = width;
            this.height = height;
        }
        public void CalculateArea()
        {
            int area = width * height;
            Console.WriteLine($"Obsah obdélníku je {area}");
        }

        public void CalculateAspectRatio()
        {
            float aspectRatio = (float)width / height;
            if (aspectRatio > 1)
            {
                Console.WriteLine("Obdélník je široký");
            }
            else if (aspectRatio == 1)
            {
                Console.WriteLine("Obdélník je čtverec");
            }
            else if (aspectRatio <1)
            {
                Console.WriteLine("Obdélník je vysoký");
            }
        }
        public bool ContainsPoints(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                return false;
            }
            if (x > width || y > height)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
