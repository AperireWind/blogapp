using BlogWebApp.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApp.Services
{
    public class BookService:CommonService
    {
        private readonly IMongoCollection<Book> _books;

        public BookService(IDatabaseSettings settings) : base(settings)
        {
            _books = _database.GetCollection<Book>(settings.BookCollectionName);
        }

        public List<Book> GetBooks()
        {
            return _books.Find(book => true).ToList();
        }

        public Book Get(string id)
        {
            return _books.Find<Book>(book => book.Ids == id).FirstOrDefault();
        }

        public Book Create(Book book)
        {
            _books.InsertOne(book);
            return book;
        }

        public void Update(string id, Book bookIn) =>
            _books.ReplaceOne(book => book.Ids == id, bookIn);

        public void Remove(Book bookIn) =>
            _books.DeleteOne(book => book.Ids == bookIn.Ids);

        public void Remove(string id) =>
            _books.DeleteOne(book => book.Ids == id);
    }
}
