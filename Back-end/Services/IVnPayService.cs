using Back_end.Entities;
using Back_end.Models;

namespace Back_end.Services;
public interface IVnPayService
{
    string CreatePaymentUrl(MembershipPackage model, User transacter, HttpContext context);


    Transaction PaymentExecute(IQueryCollection collections);
}