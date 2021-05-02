﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Dl
{

    //[9:45 AM, 4 / 22 / 2021] Sourav Singh Negi:
    public interface IAutomobile//abstraction layer
    {
        void Ignition();
        void Stop();
    }
    //[9:45 AM, 4/22/2021] Sourav Singh Negi:
    public class Jeep : IAutomobile
    {
        //IAutomobile Members
        public void Ignition()
        {
            Console.WriteLine("Jeep start");
        }
        public void Stop()
        {
            Console.WriteLine("Jeep stopped.");
        }
    }

    //[9:46 AM, 4/22/2021] Sourav Singh Negi:
    public class SUV : IAutomobile
    {
        //IAutomobile Members
        public void Ignition()
        {
            Console.WriteLine("SUV start");
        }
        public void Stop()
        {
            Console.WriteLine("SUV stopped.");
        }
    }

    //from annie to everyone:    9:47 AM
    public class AutomobileController// higher level module
    {
        //Jeep jeep1;
        //public AutomobileJeepController(Jeep obj)
        //{
        //    this.jeep1 = obj;
        //}
        //public void Ignition()
        //{
        //    this.Ignition;
        //}

        IAutomobile m_Automobile;
        public AutomobileController(IAutomobile automobile)
        {
            this.m_Automobile = automobile;
        }
        public void Ignition()
        {
            m_Automobile.Ignition();
        }
        public void Stop()
        {
            m_Automobile.Stop();
        }
    }







    class Program
    {
        static void Main(string[] args)
        {
            IAutomobile automobile = new Jeep();
            //automobile.Ignition();
            //automobile.Stop();
            //automobile = new SUV();
            //automobile.Ignition();
            //automobile.Stop();
            AutomobileController automobileController = new AutomobileController(automobile);
            automobileController.Ignition();
            automobileController.Stop();
            automobile = new SUV();
            automobileController = new AutomobileController(automobile);
            automobileController.Ignition();
            automobileController.Stop();
            Console.Read();
        }  
    }
}

