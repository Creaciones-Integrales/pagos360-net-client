using Pagos360ApiClientLibrary.Model;
using Pagos360ApiClientLibrary.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks; // Ensure this is added for Task

namespace Pagos360ApiClientLibrary.Resources
{
    public class CardAdhesions
    {
        public static async Task<PaginationResult<CardAdhesion>> ListAdhesionsAsync(string pPath, string pParam, string pAPIKey)
        {
            try
            {
                return await ApiRestServices.ListObjectsAsync<CardAdhesion>(pPath + "/card-adhesion" + pParam, pAPIKey);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static async Task<CardAdhesion> CreateAdhesionAsync(string pPath, string pAPIKey, CardAdhesion pAdhesion, bool pAutoSign)
        {
            try
            {
                string autoSign = pAutoSign ? "?auto_sign=true" : "";
                return await ApiRestServices.CreateObjectAsync<CardAdhesion>(pPath + "/card-adhesion" + autoSign, pAPIKey, "card_adhesion", pAdhesion);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static async Task<CardAdhesion> GetAdhesionAsync(string pPath, string pAPIKey, int pId)
        {
            try
            {
                return await ApiRestServices.GetObjectAsync<CardAdhesion>(pPath + "/card-adhesion", pAPIKey, pId);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static async Task<CardAdhesion> CancelAdhesionAsync(string pPath, string pAPIKey, int pId)
        {
            try
            {
                return await ApiRestServices.CancelObjectAsync<CardAdhesion>(pPath + "/card-adhesion", pAPIKey, pId);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }
    }
}
