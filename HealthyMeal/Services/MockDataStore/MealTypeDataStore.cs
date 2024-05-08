﻿using HealthyMeal.Models;
using HealthyMeal.Services.Interfaces;
using HealthyMeal.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyMeal.Services.MockDataStore
{
    public class MealTypeDataStore : IDataStore<MealTypeModel>
    {
        readonly List<MealTypeModel> _data;

        public MealTypeDataStore() 
        {
            _data = [
                new()
                {
                    Id = "1",
                    Name = "Завтрак",
                },
                new()
                {
                    Id = "2",
                    Name = "Обед",
                },
                new()
                {
                    Id = "3",
                    Name = "Ужин",
                },
                new()
                {
                    Id = "4",
                    Name = "Перекус",
                }
                ];
        }

        public async Task<bool> AddItemAsync(MealTypeModel item)
        {
            _data.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = _data.Where((MealTypeModel arg) => arg.Id == id).FirstOrDefault();
            _data.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<MealTypeModel> GetItemAsync(string id)
        {
            return await Task.FromResult(_data.FirstOrDefault(s => s.Id == id));
        }

        public async Task<List<MealTypeModel>> GetAllItemsAsync()
        {
            return await Task.FromResult(_data);
        }

        public async Task<bool> UpdateItemAsync(MealTypeModel item)
        {
            int index = _data.FindIndex((MealTypeModel arg) => arg.Id == item.Id);
            _data[index] = item;

            return await Task.FromResult(true);
        }
    }
}
