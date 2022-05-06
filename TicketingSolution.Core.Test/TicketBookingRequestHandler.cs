using System;

namespace TicketingSolution.Core
{
    public class TicketBookingRequestHandler
    {
        public TicketBookingRequestHandler()
        {
        }

        internal ServiceBookingResult BookService(TicketBookingRequest request)
        {
            ServiceBookingResult result = new ServiceBookingResult();   

            result.Email = request.Email;
            result.Name = request.Name; 
            result.Family=request.Family;   

            return result;
        }
    }
}