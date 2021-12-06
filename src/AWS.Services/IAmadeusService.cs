using AWS.ViewModels.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS.Services
{
    public interface IAmadeusService
    {
        Task<PingResponse> PingAsync(PingOTA_PingRQ OTA_PingRQ);

        Task<CurrencyConversionResponse> CurrencyConversionAsync(OTA_CurrencyConversionRQ OTA_CurrencyConversionRQ);

        Task<CancelResponse> CancelAsync(CancelOTA_CancelRQ OTA_CancelRQ);

        Task<QueueResponse> QueueAsync(QueueRQ QueueRQ);

        Task<AddPNRToQueueResponse> AddPNRToQueueAsync(QueueRQ QueueRQ);

        Task<FlightResponseViewModel> SearchFlightAsync(SearchViewModel search);

        Task<FlightDetailViewModel> GetFlightDetailAsync(SearchViewModel search);

        Task<GetFlightRulesResponse> GetFlightRulesAsync(int recommendationId, string passengerType, int combinationId);

        Task<Tuple<BookFlightResponse, Errors>> BookFlightAsync(int recommendationId, int combinationId, CustomerViewModel customer, IEnumerable<AdultPassengerViewModel> adults, IEnumerable<ChildPassengerViewModel> childs, IEnumerable<InfantPassengerViewModel> infants);

        Task<Tuple<CreateTicketResponse, Errors>> CreateTicketAsync(string ID_Context, IEnumerable<AdultPassengerViewModel> adults, IEnumerable<ChildPassengerViewModel> childs, IEnumerable<InfantPassengerViewModel> infants);

        Tuple<T, Errors> DeserializeXMLString<T>(string xmlResult);

        string SerializeXML<T>(T requestdObject, string actionName);

        string SerializeXML<T>(T requestdObject);

        Task<Tuple<GetPNRResponse, Errors>> GetPNRAsync(string contextId, string family);

        Task<Tuple<GetLastTicketingDateResponse, Errors>> GetLastTicketingDateAsync(string pnr = "");

        Task<Tuple<GetSeatMapResponse, Errors>> GetSeatMapAsync(int recommendationId, int combinationId, int itineraryId, int segmentId);

        Task<Tuple<GetServiceFeeResponse, Errors>> GetServiceFeeAsync(int recommendationId, int combinationId, bool oneWayCombinable);

        Task<Tuple<CreateTicketResponseOTA_AirBookRS, int, Errors>> CreateTicket(int recommandationId, int combinationId, CustomerViewModel customer, IEnumerable<AdultPassengerViewModel> adults, IEnumerable<ChildPassengerViewModel> childs, IEnumerable<InfantPassengerViewModel> infants);

        Task<Tuple<CreateTicketResponseOTA_AirBookRS, int, Errors>> CreateTicket
        (
            BookFlightResponse bookFlightResponse,
            int invoiceId,
            CustomerViewModel customer,
            IEnumerable<AdultPassengerViewModel> adults,
            IEnumerable<ChildPassengerViewModel> childs,
            IEnumerable<InfantPassengerViewModel> infants
        );

        Task<SignOutResponse> SignOut();

        Task<SignOutResponse> SignOut(string sessionId);

        SessionViewModel GetCookie();
    }
}
