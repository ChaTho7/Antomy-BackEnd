﻿using System;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();

            //Console.WriteLine(DateTime.Now);

            Console.ReadLine();
        }

        private static void NewMethod()
        {
            ITissueService tissueService = new TissueManager(new TissueDal(), new SortManager(new SortDal()));

            foreach (var tissue in tissueService.GetDetail().Data)
            {
                Console.WriteLine(tissue.Id + ":" + tissue.Name + "," + tissue.Sort + "," + tissue.Region + "," + tissue.Origin);
            }
        }
    }
}
