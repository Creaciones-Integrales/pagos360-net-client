using Pagos360ApiClientLibrary.Model;
using Pagos360ApiClientLibrary.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks; // Ensure this is added for Task

namespace Pagos360ApiClientLibrary.Resources
{
    public class CardDebitRequests
    {
        public static async Task<PaginationResult<CardDebitRequest>> ListDebitRequestsAsync(string pPath, string pAPIKey)
        {
            try
            {
                return await ApiRestServices.ListObjectsAsync<CardDebitRequest>(pPath + "/card-debit-request", pAPIKey);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static async Task<PaginationResult<CardDebitRequest>> ListDebitRequestsAsync(string pPath, string pAPIKey, string pExternalReference)
        {
            try
            {
                return await ApiRestServices.ListObjectsAsync<CardDebitRequest>(pPath + "/card-debit-request?external_reference=" + pExternalReference, pAPIKey);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static async Task<CardDebitRequest> CreateDebitRequestAsync(string pPath, string pAPIKey, CardDebitRequest pDebitRequest)
        {
            try
            {
                return await ApiRestServices.CreateObjectAsync<CardDebitRequest>(pPath + "/card-debit-request", pAPIKey, "card_debit_request", pDebitRequest);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static async Task<CardDebitRequest> GetCardDebitRequestAsync(string pPath, string pAPIKey, int pId)
        {
            try
            {
                return await ApiRestServices.GetObjectAsync<CardDebitRequest>(pPath + "/card-debit-request", pAPIKey, pId);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static async Task<CardDebitRequest> CancelDebitRequestAsync(string pPath, string pAPIKey, int pId)
        {
            try
            {
                return await ApiRestServices.CancelObjectAsync<CardDebitRequest>(pPath + "/card-debit-request", pAPIKey, pId);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }
    }
}
