using Pagos360ApiClientLibrary.Model;
using Pagos360ApiClientLibrary.Services;

namespace Pagos360ApiClientLibrary.Resources
{
    public class Adhesions
    {
        public static async Task<PaginationResult<Adhesion>> ListAdhesionsAsync(string pPath, string pParam, string pAPIKey)
        {
            try
            {
                return await ApiRestServices.ListObjectsAsync<Adhesion>(pPath + "/adhesion" + pParam, pAPIKey);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static async Task<Adhesion> CreateAdhesionAsync(string pPath, string pAPIKey, Adhesion pAdhesion, bool pAutoSign)
        {
            try
            {
                string autoSign = pAutoSign ? "?auto_sign=true" : "";
                return await ApiRestServices.CreateObjectAsync<Adhesion>(pPath + "/adhesion" + autoSign, pAPIKey, "adhesion", pAdhesion);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static async Task<Adhesion> GetAdhesionAsync(string pPath, string pAPIKey, int pId)
        {
            try
            {
                return await ApiRestServices.GetObjectAsync<Adhesion>(pPath + "/adhesion", pAPIKey, pId);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static async Task<Adhesion> CancelAdhesionAsync(string pPath, string pAPIKey, int pId)
        {
            try
            {
                return await ApiRestServices.CancelObjectAsync<Adhesion>(pPath + "/adhesion", pAPIKey, pId);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }
    }
}
