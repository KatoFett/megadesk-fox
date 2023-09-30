using System;

namespace MegaDesk_Fox
{
    public class DeskQuote
    {
        public DeskQuote()
        {
            Desk = new Desk();
            QuoteDate = DateTime.Now;
        }

        public Desk Desk { get; set; }

        public string CustomerName { get; set; }

        public ProductionDays ProductionDays { get; set; }

        public DateTime QuoteDate { get; set; }

        public decimal TotalCost
        {
            get
            {
                var cost = Desk.Cost;
                switch (ProductionDays)
                {
                    case ProductionDays.Rush7:
                        switch (Desk.SurfaceArea)
                        {
                            case int n when n > 2000:
                                cost += 30;
                                break;
                            case int n when n > 1000:
                                cost += 35;
                                break;
                            default:
                                cost += 40;
                                break;
                        }
                        break;
                    case ProductionDays.Rush5:
                        switch (Desk.SurfaceArea)
                        {
                            case int n when n > 2000:
                                cost += 60;
                                break;
                            case int n when n > 1000:
                                cost += 50;
                                break;
                            default:
                                cost += 40;
                                break;
                        }
                        break;
                    case ProductionDays.Rush3:
                        switch (Desk.SurfaceArea)
                        {
                            case int n when n > 2000:
                                cost += 80;
                                break;
                            case int n when n > 1000:
                                cost += 70;
                                break;
                            default:
                                cost += 60;
                                break;
                        }
                        break;
                    default:
                        break;
                }

                return cost;
            }
        }
    }

    public enum ProductionDays
    {
        Normal14,
        Rush7,
        Rush5,
        Rush3
    }
}
