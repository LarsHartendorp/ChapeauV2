﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class KitchenOrderOverview : Order
    {
        public List<OrderGerecht> Voorgerechten;
        public List<OrderGerecht> Tussengerechten;
        public List<OrderGerecht> Hoofdgerechten;
        public List<OrderGerecht> Nagerechten;

        public KitchenOrderOverview()
        {
            Voorgerechten = new List<OrderGerecht>();
            Tussengerechten = new List<OrderGerecht>();
            Hoofdgerechten = new List<OrderGerecht>();
            Nagerechten = new List<OrderGerecht>();
        }

        public void Add(OrderGerecht orderGerecht)
        {
            switch (orderGerecht.MenuItem.Type)
            {
                case TypeOfProduct.Voorgerecht:
                    Voorgerechten.Add(orderGerecht);
                    break;
                case TypeOfProduct.Tussengerecht:
                    Tussengerechten.Add(orderGerecht);
                    break;
                case TypeOfProduct.Hoofdgerecht:
                    Hoofdgerechten.Add(orderGerecht);
                    break;
                case TypeOfProduct.Nagerecht:
                    Nagerechten.Add(orderGerecht);
                    break;
                default:
                    throw new Exception($"An attempts was made to add a OrderGerecht with the type {orderGerecht.MenuItem.Type} to a {this.GetType().Name} which is not possible!");
            }
        }

        public List<OrderGerecht> GetNextMoetNogList()
        {
            if (Voorgerechten.Count != 0 && !ListHasMeeBezig(Voorgerechten) && !ListCompleted(Voorgerechten))
            {
                return Voorgerechten;
            }
            else if (Tussengerechten.Count != 0 && !ListHasMeeBezig(Tussengerechten) && !ListCompleted(Tussengerechten))
            {
                return Tussengerechten;
            }
            else if (Hoofdgerechten.Count != 0 && !ListHasMeeBezig(Hoofdgerechten) && !ListCompleted(Hoofdgerechten))
            {
                return Hoofdgerechten;
            }
            else if (Nagerechten.Count != 0 && !ListHasMeeBezig(Nagerechten) && !ListCompleted(Nagerechten))
            {
                return Nagerechten;
            }
            return new List<OrderGerecht>();
        }

        public List<OrderGerecht> GetNextMeeBezigList()
        {
            if (Voorgerechten.Count != 0 && ListHasMeeBezig(Voorgerechten))
            {
                return Voorgerechten;
            }
            else if (Tussengerechten.Count != 0 && ListHasMeeBezig(Tussengerechten))
            {
                return Tussengerechten;
            }
            else if (Hoofdgerechten.Count != 0 && ListHasMeeBezig(Hoofdgerechten))
            {
                return Hoofdgerechten;
            }
            else if (Nagerechten.Count != 0 && ListHasMeeBezig(Nagerechten))
            {
                return Nagerechten;
            }
            return new List<OrderGerecht>();
        }

        public List<OrderGerecht> GetNextKlaarList()
        {
            if (Voorgerechten.Count != 0 && ListCompleted(Voorgerechten))
            {
                return Voorgerechten;
            }
            else if (Tussengerechten.Count != 0 && ListCompleted(Tussengerechten))
            {
                return Tussengerechten;
            }
            else if (Hoofdgerechten.Count != 0 && ListCompleted(Hoofdgerechten))
            {
                return Hoofdgerechten;
            }
            else if (Nagerechten.Count != 0 && ListCompleted(Nagerechten))
            {
                return Nagerechten;
            }
            return new List<OrderGerecht>();
        }

        public bool ListHasMeeBezig(List<OrderGerecht> gerechten)
        {
            foreach (OrderGerecht gerecht in gerechten)
            {
                if (gerecht.Status == OrderStatus.MeeBezig)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ListCompleted(List<OrderGerecht> gerechten)
        {
            foreach (OrderGerecht gerecht in gerechten)
            {
                if (gerecht.Status != OrderStatus.Klaar)
                {
                    return false;
                }
            }
            return true;
        }

        public void ResolveConflicts()
        {
            if (HasMeeBezigStatus(Voorgerechten))
                ChangeToMeeBezig(Voorgerechten);

            if (HasMeeBezigStatus(Tussengerechten))
                ChangeToMeeBezig(Tussengerechten);

            if (HasMeeBezigStatus(Hoofdgerechten))
                ChangeToMeeBezig(Hoofdgerechten);

            if (HasMeeBezigStatus(Nagerechten))
                ChangeToMeeBezig(Nagerechten);
        }

        private bool HasMeeBezigStatus(List<OrderGerecht> gerechten)
        {
            foreach (OrderGerecht orderGerecht in gerechten)
                if (orderGerecht.Status == OrderStatus.MeeBezig)
                    return true;

            return false;
        }

        private void ChangeToMeeBezig(List<OrderGerecht> gerechten)
        {
            foreach (OrderGerecht orderGerecht in gerechten)
                if (orderGerecht.Status == OrderStatus.MoetNog)
                    orderGerecht.Status = OrderStatus.MeeBezig;
        }
    }
}
