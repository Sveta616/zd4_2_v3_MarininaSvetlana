using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PloshadLib
{
    //Статисеский класс чтоб не создавать объект
    public static class Area
    {
        //Статическая фун-ция
        public static int Calculate(string input)
        {
            string[] lines = input.Split('\n');
            //Проверка на строки
            if (lines.Length < 2)
            {
                throw new Exception("Недостаточно данных для вычисления");
            }
            string[] boys = lines[0].Split(' ');
            string[] girls = lines[1].Split(' ');

            //Преобразование строк в целые числа
            int[] boysCoords = Array.ConvertAll(boys, int.Parse);
            int[] girlsCoords = Array.ConvertAll(girls, int.Parse);

            //Проверка на превышение
            foreach (var coord in boysCoords)
            {
                if (Math.Abs(coord) > 10000)
                {
                    throw new Exception("Координаты не должны превышать по модулю 10^4");
                }
            }

            foreach (var coord in girlsCoords)
            {
                if (Math.Abs(coord) > 10000)
                {
                    throw new Exception("Координаты не должны превышать по модулю 10^4");
                }
            }

            //Границы прямоугольника мальчиков
            int xminB = Math.Min(boysCoords[0], boysCoords[2]);
            int xmaxB = Math.Max(boysCoords[0], boysCoords[2]);
            int yminB = Math.Min(boysCoords[1], boysCoords[3]);
            int ymaxB = Math.Max(boysCoords[1], boysCoords[3]);

            //Границы прямоугольника девочек
            int xminG = Math.Min(girlsCoords[0], girlsCoords[2]);
            int xmaxG = Math.Max(girlsCoords[0], girlsCoords[2]);
            int yminG = Math.Min(girlsCoords[1], girlsCoords[3]);
            int ymaxG = Math.Max(girlsCoords[1], girlsCoords[3]);

            //Вычисление площади каждого прямоугольника
            int Sb = (xmaxB - xminB) * (ymaxB - yminB);
            int Sg = (xmaxG - xminG) * (ymaxG - yminG);

            //Область пересечения
            int allX1 = Math.Max(xminB, xminG);
            int allY1 = Math.Max(yminB, yminG);
            int allX2 = Math.Min(xmaxB, xmaxG);
            int allY2 = Math.Min(ymaxB, ymaxG);

            int perekritie = 0;
            //Нахождение перекрытия
            if (allX1 < allX2 && allY1 < allY2)
            {
                perekritie = (allX2 - allX1) * (allY2 - allY1);
            }

            //Формула
            int rez = Sb + Sg - perekritie;
            return rez;

        }
    }
 }

