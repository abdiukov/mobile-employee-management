using System;
using System.Collections.Generic;
using TodoASMXService.Models;

namespace TodoASMXService.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _repository;

        public TodoService(ITodoRepository repository)
        {
            _repository = repository;
        }

        public bool DoesItemExist(string id)
        {
            return _repository.DoesItemExist(id);
        }

        public TodoItem Find(string id)
        {
            return _repository.Find(id);
        }

        public IEnumerable<TodoItem> GetData()
        {
            return _repository.All;
        }

        public void InsertData(TodoItem item)
        {
            _repository.Insert(item);
        }

        public void UpdateData(TodoItem item)
        {
            _repository.Update(item);
        }

        public void DeleteData(string id)
        {
            _repository.Delete(id);
        }
    }
}
