using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Side;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> Items = new List<IOrderItem>();
            BriarheartBurger bb = new BriarheartBurger();
            DoubleDraugr dd = new DoubleDraugr();
            GardenOrcOmelette goo = new GardenOrcOmelette();
            PhillyPoacher pp = new PhillyPoacher();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ThalmorTriple tt = new ThalmorTriple();
            ThugsTBone ttb = new ThugsTBone();
            Items.Add(bb);
            Items.Add(dd);
            Items.Add(goo); 
            Items.Add(pp);
            Items.Add(ss);
            Items.Add(tt);
            Items.Add(ttb);
            IEnumerable<IOrderItem> Entree = Items;
            return Entree;
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> Items = new List<IOrderItem>();
            DragonbornWaffleFries dwfs = new DragonbornWaffleFries();
            dwfs.Size = Size.Small;
            DragonbornWaffleFries dwfm = new DragonbornWaffleFries();
            dwfm.Size = Size.Medium;
            DragonbornWaffleFries dwfl = new DragonbornWaffleFries();
            dwfm.Size = Size.Large;
            Items.Add(dwfs);
            Items.Add(dwfm);
            Items.Add(dwfl);

            FriedMiraak fms = new FriedMiraak();
            fms.Size = Size.Small;
            FriedMiraak fmm = new FriedMiraak();
            fmm.Size = Size.Medium;
            FriedMiraak fml = new FriedMiraak();
            fml.Size = Size.Large;
            Items.Add(fms);
            Items.Add(fmm);
            Items.Add(fml);

            MadOtarGrits mogs = new MadOtarGrits();
            mogs.Size = Size.Small;
            MadOtarGrits mogm = new MadOtarGrits();
            mogm.Size = Size.Medium;
            MadOtarGrits mogl = new MadOtarGrits();
            mogl.Size = Size.Large;
            Items.Add(mogs);
            Items.Add(mogm);
            Items.Add(mogl);

            VokunSalad vss = new VokunSalad();
            vss.Size = Size.Small;
            VokunSalad vsm = new VokunSalad();
            vsm.Size = Size.Medium;
            VokunSalad vsl = new VokunSalad();
            vsl.Size = Size.Large;
            Items.Add(vss);
            Items.Add(vsm);
            Items.Add(vsl);

            IEnumerable<IOrderItem> Entree = Items;
            return Entree;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> Items = new List<IOrderItem>();
            AretinoAppleJuice ajs = new AretinoAppleJuice();
            ajs.Size = Size.Small;
            AretinoAppleJuice ajm = new AretinoAppleJuice();
            ajm.Size = Size.Medium;
            AretinoAppleJuice ajl = new AretinoAppleJuice();
            ajl.Size = Size.Large;
            Items.Add(ajs);
            Items.Add(ajm);
            Items.Add(ajl);

            CandlehearthCoffee ccs = new CandlehearthCoffee();
            ccs.Size = Size.Small;
            CandlehearthCoffee ccm = new CandlehearthCoffee();
            ccm.Size = Size.Medium;
            CandlehearthCoffee ccl = new CandlehearthCoffee();
            ccl.Size = Size.Large;
            Items.Add(ccs);
            Items.Add(ccm);
            Items.Add(ccl);

            MarkarthMilk mms = new MarkarthMilk();
            mms.Size = Size.Small;
            MarkarthMilk mmm = new MarkarthMilk();
            mmm.Size = Size.Medium;
            MarkarthMilk mml = new MarkarthMilk();
            mml.Size = Size.Large;
            Items.Add(mms);
            Items.Add(mmm);
            Items.Add(mml);

            SailorSoda sssbb = new SailorSoda();
            sssbb.Size = Size.Small;
            SailorSoda ssmbb = new SailorSoda();
            ssmbb.Size = Size.Medium;
            SailorSoda sslbb = new SailorSoda();
            sslbb.Size = Size.Large;
            Items.Add(sssbb);
            Items.Add(ssmbb);
            Items.Add(sslbb);

            SailorSoda sssc = new SailorSoda();
            sssc.Size = Size.Small;
            SailorSoda ssmc = new SailorSoda();
            ssmc.Size = Size.Medium;
            SailorSoda sslc = new SailorSoda();
            sslc.Size = Size.Large;
            Items.Add(sssc);
            Items.Add(ssmc);
            Items.Add(sslc);

            SailorSoda sssg = new SailorSoda();
            sssg.Size = Size.Small;
            SailorSoda ssmg = new SailorSoda();
            ssmg.Size = Size.Medium;
            SailorSoda sslg = new SailorSoda();
            sslg.Size = Size.Large;
            Items.Add(sssg);
            Items.Add(ssmg);
            Items.Add(sslg);

            SailorSoda sssl = new SailorSoda();
            sssl.Size = Size.Small;
            SailorSoda ssml = new SailorSoda();
            ssml.Size = Size.Medium;
            SailorSoda ssll = new SailorSoda();
            ssll.Size = Size.Large;
            Items.Add(sssl);
            Items.Add(ssml);
            Items.Add(ssll);

            SailorSoda sssp = new SailorSoda();
            sssp.Size = Size.Small;
            SailorSoda ssmp = new SailorSoda();
            ssmp.Size = Size.Medium;
            SailorSoda sslp = new SailorSoda();
            sslp.Size = Size.Large;
            Items.Add(sssp);
            Items.Add(ssmp);
            Items.Add(sslp);

            SailorSoda sssw = new SailorSoda();
            sssw.Size = Size.Small;
            SailorSoda ssmw = new SailorSoda();
            ssmw.Size = Size.Medium;
            SailorSoda sslw = new SailorSoda();
            sslw.Size = Size.Large;
            Items.Add(sssw);
            Items.Add(ssmw);
            Items.Add(sslw);

            WarriorWater wws = new WarriorWater();
            wws.Size = Size.Small;
            WarriorWater wwm = new WarriorWater();
            wwm.Size = Size.Medium;
            WarriorWater wwl = new WarriorWater();
            wwl.Size = Size.Large;
            Items.Add(wws);
            Items.Add(wwm);
            Items.Add(wwl);

            IEnumerable<IOrderItem> Entree = Items;
            return Entree;
        }

        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> Items = new List<IOrderItem>();

            BriarheartBurger bb = new BriarheartBurger();
            DoubleDraugr dd = new DoubleDraugr();
            GardenOrcOmelette goo = new GardenOrcOmelette();
            PhillyPoacher pp = new PhillyPoacher();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ThalmorTriple tt = new ThalmorTriple();
            ThugsTBone ttb = new ThugsTBone();
            Items.Add(bb);
            Items.Add(dd);
            Items.Add(goo);
            Items.Add(pp);
            Items.Add(ss);
            Items.Add(tt);
            Items.Add(ttb);

            DragonbornWaffleFries dwfs = new DragonbornWaffleFries();
            dwfs.Size = Size.Small;
            DragonbornWaffleFries dwfm = new DragonbornWaffleFries();
            dwfm.Size = Size.Medium;
            DragonbornWaffleFries dwfl = new DragonbornWaffleFries();
            dwfm.Size = Size.Large;
            Items.Add(dwfs);
            Items.Add(dwfm);
            Items.Add(dwfl);

            FriedMiraak fms = new FriedMiraak();
            fms.Size = Size.Small;
            FriedMiraak fmm = new FriedMiraak();
            fmm.Size = Size.Medium;
            FriedMiraak fml = new FriedMiraak();
            fml.Size = Size.Large;
            Items.Add(fms);
            Items.Add(fmm);
            Items.Add(fml);

            MadOtarGrits mogs = new MadOtarGrits();
            mogs.Size = Size.Small;
            MadOtarGrits mogm = new MadOtarGrits();
            mogm.Size = Size.Medium;
            MadOtarGrits mogl = new MadOtarGrits();
            mogl.Size = Size.Large;
            Items.Add(mogs);
            Items.Add(mogm);
            Items.Add(mogl);

            VokunSalad vss = new VokunSalad();
            vss.Size = Size.Small;
            VokunSalad vsm = new VokunSalad();
            vsm.Size = Size.Medium;
            VokunSalad vsl = new VokunSalad();
            vsl.Size = Size.Large;
            Items.Add(vss);
            Items.Add(vsm);
            Items.Add(vsl);

            AretinoAppleJuice ajs = new AretinoAppleJuice();
            ajs.Size = Size.Small;
            AretinoAppleJuice ajm = new AretinoAppleJuice();
            ajm.Size = Size.Medium;
            AretinoAppleJuice ajl = new AretinoAppleJuice();
            ajl.Size = Size.Large;
            Items.Add(ajs);
            Items.Add(ajm);
            Items.Add(ajl);

            CandlehearthCoffee ccs = new CandlehearthCoffee();
            ccs.Size = Size.Small;
            CandlehearthCoffee ccm = new CandlehearthCoffee();
            ccm.Size = Size.Medium;
            CandlehearthCoffee ccl = new CandlehearthCoffee();
            ccl.Size = Size.Large;
            Items.Add(ccs);
            Items.Add(ccm);
            Items.Add(ccl);

            MarkarthMilk mms = new MarkarthMilk();
            mms.Size = Size.Small;
            MarkarthMilk mmm = new MarkarthMilk();
            mmm.Size = Size.Medium;
            MarkarthMilk mml = new MarkarthMilk();
            mml.Size = Size.Large;
            Items.Add(mms);
            Items.Add(mmm);
            Items.Add(mml);

            SailorSoda sssbb = new SailorSoda();
            sssbb.Size = Size.Small;
            SailorSoda ssmbb = new SailorSoda();
            ssmbb.Size = Size.Medium;
            SailorSoda sslbb = new SailorSoda();
            sslbb.Size = Size.Large;
            Items.Add(sssbb);
            Items.Add(ssmbb);
            Items.Add(sslbb);

            SailorSoda sssc = new SailorSoda();
            sssc.Size = Size.Small;
            SailorSoda ssmc = new SailorSoda();
            ssmc.Size = Size.Medium;
            SailorSoda sslc = new SailorSoda();
            sslc.Size = Size.Large;
            Items.Add(sssc);
            Items.Add(ssmc);
            Items.Add(sslc);

            SailorSoda sssg = new SailorSoda();
            sssg.Size = Size.Small;
            SailorSoda ssmg = new SailorSoda();
            ssmg.Size = Size.Medium;
            SailorSoda sslg = new SailorSoda();
            sslg.Size = Size.Large;
            Items.Add(sssg);
            Items.Add(ssmg);
            Items.Add(sslg);

            SailorSoda sssl = new SailorSoda();
            sssl.Size = Size.Small;
            SailorSoda ssml = new SailorSoda();
            ssml.Size = Size.Medium;
            SailorSoda ssll = new SailorSoda();
            ssll.Size = Size.Large;
            Items.Add(sssl);
            Items.Add(ssml);
            Items.Add(ssll);

            SailorSoda sssp = new SailorSoda();
            sssp.Size = Size.Small;
            SailorSoda ssmp = new SailorSoda();
            ssmp.Size = Size.Medium;
            SailorSoda sslp = new SailorSoda();
            sslp.Size = Size.Large;
            Items.Add(sssp);
            Items.Add(ssmp);
            Items.Add(sslp);

            SailorSoda sssw = new SailorSoda();
            sssw.Size = Size.Small;
            SailorSoda ssmw = new SailorSoda();
            ssmw.Size = Size.Medium;
            SailorSoda sslw = new SailorSoda();
            sslw.Size = Size.Large;
            Items.Add(sssw);
            Items.Add(ssmw);
            Items.Add(sslw);

            WarriorWater wws = new WarriorWater();
            wws.Size = Size.Small;
            WarriorWater wwm = new WarriorWater();
            wwm.Size = Size.Medium;
            WarriorWater wwl = new WarriorWater();
            wwl.Size = Size.Large;
            Items.Add(wws);
            Items.Add(wwm);
            Items.Add(wwl);

            IEnumerable<IOrderItem> Entree = Items;
            return Entree;
        }
    }
}
