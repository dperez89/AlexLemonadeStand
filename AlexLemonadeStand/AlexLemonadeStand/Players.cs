using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexLemonadeStand
{
    class Players
    {
        private int nearlyBadLemons;
        private int spoiledLemons;
        private string name;
        private double priceMultiplier;
        private Inventory userInventory;
        private List<Lemon> totalLemons;
        private List<Sugar> totalSugar;
        private List<Ice> totalIceCubes;
        private List<Cup> totalCups;
        private Lemon lemon;
        private Sugar sugar;
        private Ice ice;
        private Cup cup;
        public Players()
        {

        }
        public Inventory ObtainInventoryStatus()
        {

        }
        public double CalculateLemonSugarMultiplier(Store, double)
        {

        }
        public double CalculateIceCupsMultiplier(Store, double)
        {

        }
        public void BuyLemons(Inventory, Store, double)
        {

        }
        public void BuySugar(Inventory, Store, double)
        {

        }
        public void BuyIce(Inventory, Store, double)
        {

        }
        public void BuyCups(Inventory, Store, double)
        {

        }
        public void AgeLemons(Inventory)
        {

        }
        public void TestLemonSpoilage(Inventory)
        {

        }
        public void AnnounceLemonSpoilage(int, int)
        {

        }
        public void AnnounceIceMeltage(Inventory)
        {

        }
        public Pitcher CreatePitcher(Recipe, Inventory, Pitcher)
        {

        }
        public double RemoveUsedLemons(Recipe, Inventory)
        {

        }
        public double RemoveUsedSugar(Recipe, Inventory)
        {

        }
        public double RemoveUsedIce(Recipe, Inventory)
        {

        }
        public double RemoveUsedCup(Recipe, Inventory)
        {

        }
    }

}
