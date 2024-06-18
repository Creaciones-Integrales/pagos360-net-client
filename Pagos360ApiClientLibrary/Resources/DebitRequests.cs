using Pagos360ApiClientLibrary.Model;
using Pagos360ApiClientLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagos360ApiClientLibrary.Resources
{
    public class DebitRequests
    {
        public static async Task<PaginationResult<DebitRequest>> ListDebitRequestsAsync(string pPath, string pAPIKey)
        {
            try
            {
                return await ApiRestServices.ListObjectsAsync<DebitRequest>(pPath + "/debit-request", pAPIKey);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static async Task<PaginationResult<DebitRequest>> ListDebitRequestsAsync(string pPath, string pAPIKey, string pExternalReference)
        {
            try
            {
                return await ApiRestServices.ListObjectsAsync<DebitRequest>(pPath + "/debit-request?external_reference=" + pExternalReference, pAPIKey);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static async Task<DebitRequest> CreateDebitRequestAsync(string pPath, string pAPIKey, DebitRequest pDebitRequest)
        {
            try
            {
                return await ApiRestServices.CreateObjectAsync<DebitRequest>(pPath + "/debit-request", pAPIKey, "debit_request", pDebitRequest);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static async Task<DebitRequest> GetDebitRequestAsync(string pPath, string pAPIKey, int pId)
        {
            try
            {
                return await ApiRestServices.GetObjectAsync<DebitRequest>(pPath + "/debit-request", pAPIKey, pId);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static async Task<DebitRequest> CancelDebitRequestAsync(string pPath, string pAPIKey, int pId)
        {
            try
            {
                return await ApiRestServices.CancelObjectAsync<DebitRequest>(pPath + "/debit-request", pAPIKey, pId);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static async Task<string> GetNextBusinessDayAsync(string pPath, string pAPIKey, BusinessDay pDebitRequest)
        {
            return await ApiRestServices.GetFirstDudeDateAsync<BusinessDay>(pPath + "/validator/next-business-day", pAPIKey, "next_business_day", pDebitRequest);
        }
    }
}
