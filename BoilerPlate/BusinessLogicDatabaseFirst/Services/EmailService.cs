using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class EmailService : BaseService<User>, IEmailService
    {
        public EmailService(DataContext dataContext) : base(dataContext)
        {

        }
    }

    public interface IEmailService : IService<User>
    {

    }
}
