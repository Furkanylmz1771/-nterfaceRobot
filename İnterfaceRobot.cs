using Robot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{

    interface IXC1321
    {
        void UcabilmeMod();
        void GozlerdenAtesMod();
        void UzayanKolBacakMod();
    }
    interface IXC2321 : IXC1321
    {
        void GorunmezlikMod();
    }
    interface IXC3321 : IXC1321
    {
        void DenizaltiMod();
    }
    interface IXC4321 : IXC3321, IXC2321, IXC1321
    {
    } 

    // Ürünlerin arayüzünü oluşturduk

    public class XC1321 : IXC1321
    {
        public void GozlerdenAtesMod()
        {
        }
        public void UcabilmeMod()
        {
        }
        public void UzayanKolBacakMod()
        {
        }
    };

    //  Ürünlere arayüzü implement ettik.
    public class XC2321 : IXC2321
    {
        public void GorunmezlikMod()
        {
        }
        public void GozlerdenAtesMod()
        {
        }
        public void UcabilmeMod()
        {
        }
        public void UzayanKolBacakMod()
        {
        }
    };

    // XC3321 ürününe IXC3321 arayüzünü ekledik 
    public class XC3321 : IXC3321
    {
        public void DenizaltiMod()
        {
        }
        public void GozlerdenAtesMod()
        {
        }
        public void UcabilmeMod()
        {
        }
        public void UzayanKolBacakMod()
        {
        }
    };

    //son ürün olan bütün özelliklerin barınmasını istediğimiz robota da oluşturdğumuz IXC4321 arayüzünü implement ettik.
    public class XC4321 : IXC4321
    {
        public void DenizaltiMod()
        {
        }
        public void GorunmezlikMod()
        {
        }
        public void GozlerdenAtesMod()
        {
        }
        public void UcabilmeMod()
        {
        }
        public void UzayanKolBacakMod()
        {
        }
    }
};


class Program
    {
        static void Main(string[] args)
        {
            //Burada da ürünümüzü oluşturduk.     
            IXC4321 xc4321 = new XC4321();
            xc4321.DenizaltiMod();
            xc4321.GorunmezlikMod();
            xc4321.GozlerdenAtesMod();
            xc4321.UcabilmeMod();
            xc4321.UzayanKolBacakMod();
            Console.ReadLine();
        }
    };







