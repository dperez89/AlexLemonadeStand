using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexLemonadeStand
{
    class Game
    {
        protected interface userInterface;
        protected Player player;
        protected Store store;
        protected Weather dailyForecast;
        protected Recipe recipe;
        protected Conditions todaysForecast;
        protected Inventory userInventory;
        protected BussinessTransactions customerSales;
        protected List<Customer> customers;
        protected List<Conditions> forecast;
        protected string userInput;

        public Game()
        {

        }

        public void SetUpGame()
        {

        }
        private Time SetUpGameLength()
        {

        }
        private void PlayGame(Time)
        {

        }
        private void TakeTurns(Time, Conditions, List<Customer>)
        {

        }
        private Store ChangeStorePrices()
        {

        }
        private double CalculateAllProfit(Inventory, interface)
        {

        }
        private void ShowFinalScore(Time)
        {

        }
    }
}
