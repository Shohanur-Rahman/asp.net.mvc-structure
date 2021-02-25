using Services.Constants;
using Services.DB;
using Services.Encription;
using Services.Models;
using Services.VMModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository()
        {
            _context = new ApplicationDbContext();
        }

        public ResponseMessage SaveUser(USERS model)
        {
            ResponseMessage result = new ResponseMessage();
            try
            {
                var existingUser = _context.USER.Where(u => u.Email.ToLower() == model.Email.ToLower()).FirstOrDefault();

                if(existingUser == null)
                {
                    USERS user = new USERS();
                    user.Name = model.Name;
                    user.Email = model.Email;
                    user.Password = SimpleCryptService.Factory().Encrypt(model.Password);

                    user.CreatedDate = DateTime.Now;
                    _context.USER.Add(user);
                    _context.SaveChanges();

                    user.Password = "";
                    result.Data = user;
                    result.IsSuccess = true;
                }
                else
                {
                    result.Message = BusinessMessage.DATA_EXIST;
                }

            }catch(Exception ex)
            {
                result.Message = ex.Message.ToString();
            }

            return result;
        }


        public ResponseMessage GetUsers()
        {
            ResponseMessage result = new ResponseMessage();
            try
            {
                var existingUser = _context.USER.ToList();

                result.Data = existingUser;
                result.IsSuccess = true;
                result.Message = BusinessMessage.SUCCESS;

            }
            catch (Exception ex)
            {
                result.Message = ex.Message.ToString();
            }

            return result;
        }

    }
}
