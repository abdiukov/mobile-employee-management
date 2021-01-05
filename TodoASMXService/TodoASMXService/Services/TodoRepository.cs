using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using TodoASMXService.Models;

namespace TodoASMXService.Services
{
    public class TodoRepository : ITodoRepository
    {
        private List<TodoItem> _todoList;

        public TodoRepository()
        {
            InitializeData();
        }

        public IEnumerable<TodoItem> All
        {
            get { return _todoList; }
        }

        public bool DoesItemExist(string id)
        {
            return _todoList.Any(item => item.ID == id);
        }

        public TodoItem Find(string id)
        {
            return _todoList.Where(item => item.ID == id).FirstOrDefault();
        }

        public void Insert(TodoItem item)
        {
            _todoList.Add(item);
        }

        public void Update(TodoItem item)
        {
            var todoItem = Find(item.ID);
            var index = _todoList.IndexOf(todoItem);
            _todoList.RemoveAt(index);
            _todoList.Insert(index, item);
        }

        public void Delete(string id)
        {
            _todoList.Remove(Find(id));
        }

        #region Helpers

        private void InitializeData()
        {
            _todoList = new List<TodoItem>();
            XmlDocument peopleDoc = new XmlDocument();
            var file = Path.Combine(HttpRuntime.AppDomainAppPath, "people.xml");
            peopleDoc.Load(file);
            XmlNode root = peopleDoc.LastChild;
            XmlNodeList peoples = root.SelectNodes("people");
            var peoplesList = new List<TodoItem>();
            
            foreach (XmlNode n in peoples)
            {
                var people = new TodoItem
                {
                    ID = n.Attributes["ID"].Value,
                    //ID = n.SelectSingleNode("ID").InnerText,
                    Name = n.SelectSingleNode("Name").InnerText,
                    Street = n.SelectSingleNode("Street").InnerText,
                    City=n.SelectSingleNode("City").InnerText,
                    State = n.SelectSingleNode("State").InnerText,
                    Phone = n.SelectSingleNode("Phone").InnerText,
                    ZipCode = n.SelectSingleNode("ZipCode").InnerText,
                    Country = n.SelectSingleNode("Country").InnerText,
                    Department = n.SelectSingleNode("Department").InnerText,
                };

                peoplesList.Add(people);
            }

            for(int i = 0; i < peoplesList.Count;i++)
            {
                var toAdd = new TodoItem
                {
                    ID = peoplesList[i].ID,
                    Name = peoplesList[i].Name,
                    Phone = peoplesList[i].Phone,
                    Street = peoplesList[i].Street,
                    City=peoplesList[i].City,
                    State=peoplesList[i].State,
                    ZipCode = peoplesList[i].ZipCode,
                    Country=peoplesList[i].Country,
                    Department=peoplesList[i].Department,
                };
                _todoList.Add(toAdd);
            }
        }

        #endregion
    }
}
