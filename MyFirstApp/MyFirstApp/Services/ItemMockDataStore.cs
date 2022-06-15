// <copyright file="ItemMockDataStore.cs" company="Marco von Ballmoos">
//   Copyright (c) 2021 Marco von Ballmoos. All rights reserved.
// </copyright>

using System.Collections.Generic;
using MyFirstApp.Models;

namespace MyFirstApp.Services
{
  public class ItemMockDataStore : MockDataStore<Item>
  {
    public ItemMockDataStore()
    {
      Items = new List<Item>()
      {
        new Item { Text = "First album", Description = "This is an album description." },
        new Item { Text = "Second album", Description = "This is an album description." },
        new Item { Text = "Third album", Description = "This is an album description." },
        new Item { Text = "Fourth album", Description = "This is an album description." },
        new Item { Text = "Fifth album", Description = "This is an album description." },
        new Item { Text = "Sixth album", Description = "This is an album description." }
      };
    }
  }
}