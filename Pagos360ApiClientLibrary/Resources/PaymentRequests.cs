using Pagos360ApiClientLibrary.Model;
using Pagos360ApiClientLibrary.Services;
using System;
using System.Threading.Tasks;

namespace Pagos360ApiClientLibrary.Resources
{
    public class PaymentRequests
    {
        public static async Task<PaginationResult<PaymentRequest>> ListPaymentRequestsAsync(string pPath, string pAPIKey)
        {
            try
            {
                return await ApiRestServices.ListObjectsAsync<PaymentRequest>(pPath + "/payment-request", pAPIKey);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static async Task<PaymentRequest> CreatePaymentRequestAsync(string pPath, string pAPIKey, string? pConnectAccount, PaymentRequest pPaymentRequest)
        {
            try
            {
                return await ApiRestServices.CreateObjectWithAccountAsync<PaymentRequest>(pPath + "/payment-request", pAPIKey, pConnectAccount, "payment_request", pPaymentRequest);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static async Task<PaymentRequest> GetPaymentRequestAsync(string pPath, string pAPIKey, int pPaymentId)
        {
            try
            {
                return await ApiRestServices.GetObjectAsync<PaymentRequest>(pPath + "/payment-request", pAPIKey, pPaymentId);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }
    }
}
