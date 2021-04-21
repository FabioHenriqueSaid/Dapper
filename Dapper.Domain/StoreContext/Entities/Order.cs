﻿using Dapper.Domain.StoreContext.Enums;
using System;
using System.Collections.Generic;

namespace Dapper.Domain.StoreContext.Entities
{
    public class Order
    {
        public Order(Customer customer)
        {
            Customer = customer;
            Number = Guid.NewGuid().ToString().Substring(0,8).ToUpper();
            CreateDate = DateTime.Now;
            Status = EOrderStatus.Created;
            Items = new List<OrderItem>();
            Deliveries = new List<Delivery>();
        }
        public string Number { get; private set; }
        public Customer Customer { get; set; }
        public DateTime CreateDate { get; private set; }
        public EOrderStatus Status { get; private set; }
        public IList<OrderItem> Items { get; private set; }
        public IList<Delivery> Deliveries { get; private set; }
        public void AddItem(OrderItem orderItem)
        {

        }
        public void Place() { }
    }
}