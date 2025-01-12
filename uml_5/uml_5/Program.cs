using System;
using System.Collections.Generic;

namespace CarRentalSystem
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Address { get; set; }
        public Customer Customer { get; set; }
        public Car RentedCar { get; set; }

        public void Update()
        {
            // Update transaction details
            Console.WriteLine($"Transaction {Id} updated: {Name}, {Date}, {Address}");
        }
    }

    public class Reservation
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public string List { get; set; }
        public Customer Customer { get; set; }
        public Car ReservedCar { get; set; }

        public void Confirmation()
        {
            // Confirm reservation
            Console.WriteLine($"Reservation {Id} confirmed for {Customer.Name}: {Details}, {List}");
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public int Payment { get; set; }

        public List<Transaction> Transactions { get; set; }
        public List<Reservation> Reservations { get; set; }

        public void Update()
        {
            // Update customer details
            Console.WriteLine($"Customer {Id} updated: {Name}, {Contact}, {Address}, Payment: {Payment}");
        }
    }

    public class Car
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public string OrderType { get; set; }

        public void ProcessDebit()
        {
            // Process debit for the customer
            Console.WriteLine($"Car {Id} processed for debit: {Details}, OrderType: {OrderType}");
        }
    }

    public class RentingOwner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string ContactNum { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public void VerifyAccount()
        {
            // Verify renting owner's account
            Console.WriteLine($"Renting owner {Id} account verified: {Name}");
        }
    }

    public class Payment
    {
        public int Id { get; set; }
        public int CardNumber { get; set; }
        public string Amount { get; set; }

        public void Add()
        {
            // Add payment
            Console.WriteLine($"Payment {Id} added: CardNumber: {CardNumber}, Amount: {Amount}");
        }

        public void Update()
        {
            // Update payment details
            Console.WriteLine($"Payment {Id} updated: CardNumber: {CardNumber}, Amount: {Amount}");
        }
    }

    public class Rentals
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string Price { get; set; }

        public void Add()
        {
            // Add rental
            Console.WriteLine($"Rental {Id} added: {Names}, Price: {Price}");
        }

        public void Update()
        {
            // Update rental details
            Console.WriteLine($"Rental {Id} updated: {Names}, Price: {Price}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            Customer customer = new Customer { Id = 1, Name = "John Doe", Contact = "123456789", Address = "123 Main St", Payment = 100 };
            customer.Transactions = new List<Transaction>();
            customer.Reservations = new List<Reservation>();
            customer.Update();

            Transaction transaction = new Transaction { Id = 1, Name = "Transaction 1", Date = "01-01-2025", Address = "123 Main St", Customer = customer };
            transaction.RentedCar = new Car { Id = 1, Details = "Car Details", OrderType = "Standard" };
            customer.Transactions.Add(transaction);
            transaction.Update();

            Reservation reservation = new Reservation { Id = 1, Details = "Reservation Details", List = "Reservation List", Customer = customer };
            reservation.ReservedCar = new Car { Id = 2, Details = "Reservation Car Details", OrderType = "Economy" };
            customer.Reservations.Add(reservation);
            reservation.Confirmation();

            Car car = new Car { Id = 1, Details = "Car Details", OrderType = "Standard" };
            car.ProcessDebit();

            RentingOwner rentingOwner = new RentingOwner { Id = 1, Name = "Owner Name", Age = "45", ContactNum = "987654321", Username = "owner", Password = "password" };
            rentingOwner.VerifyAccount();

            Payment payment = new Payment { Id = 1, CardNumber = 123456789, Amount = "200" };
            payment.Add();

            Rentals rentals = new Rentals { Id = 1, Names = "Rental 1", Price = "50" };
            rentals.Add();
        }
    }
}
