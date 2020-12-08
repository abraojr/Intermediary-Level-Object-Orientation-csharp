using Custom_exceptions.Entities;
using Custom_exceptions.Entities.Exceptions;
using System;

namespace Custom_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read the data of a hotel reservation (room number, check-in date and check-out date) and show the reservation data, 
             *including its duration in days.
             *Then, read new entry and exit dates, update the reservation, and show the reservation again with the updated data. The program must not accept
             *invalid data for the reservation, according to the following rules:
             *- Booking changes can only occur for future dates 
             *- The exit date must be greater than the entry date*/
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}

