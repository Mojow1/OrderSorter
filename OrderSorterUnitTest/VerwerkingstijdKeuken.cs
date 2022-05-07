using System;
using System.Collections.Generic;
using orderSorter;

namespace OrderSorterUnitTest;

public class VerwerkingstijdKeuken
{
    void MaakGereed(){
    
        Customer customer = new Customer(1, "voornaam", "achternaam", "Straatnaam", 52, "6164VT", "Geleen");
        DateTime orderTime = DateTime.Now;

        Product p1 = new Product(1, "product1", 10);
        Product p2 = new Product(2, "product2", 20);
        Product p3 = new Product(3, "product3", 30);
            
        ProductQuantity product1 = new ProductQuantity(p1, 4);
        ProductQuantity product2 = new ProductQuantity(p2, 0);
        ProductQuantity product3 = new ProductQuantity(p3, 7);

        List<ProductQuantity> demanded = new List<ProductQuantity>();
        demanded.Add(product1);
        demanded.Add(product2);
        demanded.Add(product3);
            
        Priority priority = new Priority(true);
        Order order = new Order(1, customer, orderTime, priority, demanded);
        int _normalPreparationTimeInMinutes = 30;
        int _busyKitchenTimeLossPercentage =25;
        int _priorityTimeSavingPercentage = 40;

        Kitchen busyKitchen= new BusyKitchen(order, _normalPreparationTimeInMinutes, _busyKitchenTimeLossPercentage, _priorityTimeSavingPercentage);
        Kitchen normalKitchen = new NormalKitchen(order, _normalPreparationTimeInMinutes, _priorityTimeSavingPercentage);

        PackingSlipKitchen packingSlipKitchen = GeneratePackingSlipKitchen(order, false, busyKitchen, normalKitchen);

        Console.WriteLine(packingSlipKitchen.ProcessingTimeKitchen);
    }


// int normalPreparationTimeInMinutes, int busyKitchenTimeLossPercentage, int priorityTimeSavingPercentage

        // Calculates the preparing time of the kitchen minutes. It needs a BusyKitchen and a NormalKitchen. 
        static PackingSlipKitchen GeneratePackingSlipKitchen(Order order, bool highWorkload, Kitchen busyKitchen, Kitchen normalKitchen)
        {
            PackingSlipKitchen packingslip = null;
            
            if (highWorkload == true)
            {
                if (order.Priority.PriorityStatus == true)
                { 
                    IPriorityOrderPrepareder priorityOrder= busyKitchen.PreparePriorityOrder();
                    packingslip =priorityOrder.Prepare();
                }
                
                else if (order.Priority.PriorityStatus == false)
                {
                    IRegularOrderPrepareder normalOrder = busyKitchen.PrepareNormalOrder();
                    packingslip = normalOrder.Prepare();

                }
            }
            
            else if (highWorkload == false)
            {
                if (order.Priority.PriorityStatus == true)
                {
                    IPriorityOrderPrepareder priorityOrder = normalKitchen.PreparePriorityOrder();
                    packingslip= priorityOrder.Prepare();
                }
                
                else if (order.Priority.PriorityStatus == false)
                {
                    IRegularOrderPrepareder normalOrder = normalKitchen.PrepareNormalOrder();
                    packingslip = normalOrder.Prepare();
                }
            }

            return packingslip;
        }

      

    
    

}