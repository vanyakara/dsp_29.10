using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsp_29._10
{
    public abstract class Juice
    {
       public abstract void Info();
    }
    public class AppleJuice : Juice
    {
        public override void Info()
        {
            Console.WriteLine("Сок от ябълка. Съдържание на плодове: 70%");
        }
    }
    public class CherryJuice : Juice
    {
        public override void Info()
        {
            Console.WriteLine("Сок от вишна. Съдържание на плодове: 60%");
        }
    }
    public class OrangeJuice : Juice
    {
        public override void Info()
        {
            Console.WriteLine("Сок от портокал. Съдържание на плодове: 80%");
        }
    }
    public abstract class JuiceFactory
    {
        public abstract Juice CreateJuice();
    }
    public class AppleJuiceFactory : JuiceFactory
    {
        public override Juice CreateJuice()
        {
            return new AppleJuice();
        }
    }
    public class CherryJuiceFactory : JuiceFactory
    {
        public override Juice CreateJuice()
        {
            return new CherryJuice();
        }
    }
    public class OrangeJuiceFactory : JuiceFactory
    {
        public override Juice CreateJuice()
        {
            return new OrangeJuice();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            JuiceFactory appleFactory = new AppleJuiceFactory();
            Juice appleJuice = appleFactory.CreateJuice();
            appleJuice.Info();

            JuiceFactory cherryFactory = new CherryJuiceFactory();
            Juice cherryJuice = cherryFactory.CreateJuice();
            cherryJuice.Info();

            JuiceFactory orangeFactory = new OrangeJuiceFactory();
            Juice orangeJuice = orangeFactory.CreateJuice();
            orangeJuice.Info();

            Console.ReadLine();
        }
    }
}
