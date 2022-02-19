using System.Threading.Tasks;
using Villagenix.Models;

namespace Villagenix.Client.Service.IService
{
    public interface IStripePaymentService
    {
        public Task<SuccessModel> CheckOut(StripePaymentDTO model);
    }
}
