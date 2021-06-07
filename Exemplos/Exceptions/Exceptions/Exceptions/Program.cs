using Exceptions.Entities;
using Exceptions.Entities.Exceptions;
using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (DD/MM/YYYY): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (DD/MM/YYYY): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (DD/MM/YYYY): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (DD/MM/YYYY): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error in reservation: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format error! {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error! {e.Message}");
            }
        }
    }
}
