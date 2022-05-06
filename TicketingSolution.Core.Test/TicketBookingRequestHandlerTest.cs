using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

using Shouldly;

namespace TicketingSolution.Core
{
    public class Ticket_Booking_Request_Handler_Test
    {
        [Fact]
        public void Should_Return_Ticket_Booking_Response_With_Request_Value()
        {
            //Arrange

            var BookingRequest = new TicketBookingRequest() 
            {
                Name="test Name",
                Family="test Family",
                Email="test Email",
            };

            var Handler = new TicketBookingRequestHandler();


            //Act
            ServiceBookingResult result= Handler.BookService(BookingRequest);


            //Ordinary Assertation

            //Assert.NotNull(result);
            //Assert.Equal(result.Name,BookingRequest.Name);
            //Assert.Equal(result.Family,BookingRequest.Family);
            //Assert.Equal(result.Email,BookingRequest.Email);


            //Shouldly Assertaion
            result.ShouldNotBeNull();
            result.Name.ShouldBe(BookingRequest.Name);
            result.Family.ShouldBe(BookingRequest.Family);  
            result.Email.ShouldBe(BookingRequest.Email);    




        }
    }
}
