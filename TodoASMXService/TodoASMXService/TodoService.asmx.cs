using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Services;
using System.Web.Services.Protocols;
using TodoASMXService.Models;
using TodoASMXService.Services;

namespace TodoASMXService
{
    [WebService(Namespace = "http://www.xamarin.com/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class TodoService : System.Web.Services.WebService
    {
        static readonly ITodoService todoService = new Services.TodoService(new TodoRepository());

        [WebMethod]
        public List<TodoItem> aComputer_View_GetEmployeeDetails()
        {
            return todoService.GetData().ToList();
        }

        [WebMethod]
        public void aComputerView_InsertEmployee(string ID, string Name, string Phone, string Street, string City, string State, string Country, string ZipCode, string Department)
        {   
            TodoItem item = new TodoItem
            {
                ID = ID,
                Name = Name,
                Phone = Phone,
                Street = Street,
                City = City,
                State = State,
                Country = Country,
                ZipCode = ZipCode,
                Department = Department
            };
            todoService.InsertData(item);
        }

        [WebMethod]
        public void aComputerView_EditEmployee(string ID, string Name, string Phone, string Street, string City, string State, string Country, string ZipCode, string Department)
        {
            TodoItem item = new TodoItem
            {
                ID = ID,
                Name = Name,
                Phone = Phone,
                Street = Street,
                City = City,
                State = State,
                Country = Country,
                ZipCode = ZipCode,
                Department = Department
            };
            todoService.UpdateData(item);
        }

        [WebMethod]
        public void aComputerView_DeleteEmployee(string id)
        {
            todoService.DeleteData(id);
        }




        //methods below are used by mobile app
        [WebMethod]
        public void CreateTodoItem(TodoItem item)
        {
            todoService.InsertData(item);
        }

        [WebMethod]
        public void EditTodoItem(TodoItem item)
        {
            todoService.UpdateData(item);
        }

        [WebMethod]
        public void DeleteTodoItem(string id)
        {
            todoService.DeleteData(id);
        }

        [WebMethod]
        public List<TodoItem> GetTodoItems()
        {
            return todoService.GetData().ToList();
        }

    }
}
