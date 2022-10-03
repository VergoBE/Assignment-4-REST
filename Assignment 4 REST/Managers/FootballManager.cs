using AutumnAssignmentFootball;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Assignment_4_REST.Managers
{
        public class FootballManager
        {
            private static int _nextId = 1;
            private static readonly List<FootballPlayer> Data = new List<FootballPlayer>
        {
            new FootballPlayer {Id = _nextId++, Name = "Mikkel", ShirtNumber = 7},
            new FootballPlayer {Id=_nextId++, Name = "Niels", ShirtNumber = 10}
        };

            public List<FootballPlayer> GetAll(string substring)
            {
                return new List<FootballPlayer>(Data);
                
            }

            public FootballPlayer GetById(int id)
            {
                return Data.Find(book => book.Id == id);
            }

            public FootballPlayer Add(FootballPlayer newBook)
            {
                newBook.Id = _nextId++;
                Data.Add(newBook);
                return newBook;
            }

            public FootballPlayer Delete(int id)
            {
                FootballPlayer book = Data.Find(book1 => book1.Id == id);
                if (book == null) return null;
                Data.Remove(book);
                return book;
            }

            public FootballPlayer Update(int id, FootballPlayer updates)
            {
                FootballPlayer book = Data.Find(book1 => book1.Id == id);
                if (book == null) return null;
                book.Name = updates.Name;
                book.ShirtNumber = updates.ShirtNumber;
                return book;
            }
        }
    }
