﻿using HealthyMeal.Models;
using HealthyMeal.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyMeal.Services.MockDataStore
{
    public class MealDataStore : IDataStore<MealModel>
    {
        readonly List<MealModel> _data;

        public MealDataStore()
        {
            _data = [
                new(){
                    Id = "1",
                    UserId = "1",
                    FoodId = "1",
                    UnitsId = "2",
                    MealTypeId = "4",
                    UnitsName = "шт",
                    FoodName = "Печенье (Любятово)",
                    Date = new(2024, 5, 1),
                    AmountEaten = 5,
                },
                new(){
                    Id = "2",
                    UserId = "1",
                    FoodId = "2",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Яблоко",
                    Date = new(2024, 5, 1),
                    AmountEaten = 2,
                },
                new(){
                    Id = "3",
                    UserId = "1",
                    FoodId = "3",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Банан",
                    Date = new(2024, 5, 1),
                    AmountEaten = 1,
                },
                new(){
                    Id = "4",
                    UserId = "1",
                    FoodId = "6",
                    UnitsId = "3",
                    MealTypeId = "1",
                    UnitsName = "порция",
                    FoodName = "Морковный суп",
                    Date = new(2024, 5, 1),
                    AmountEaten = 1,
                },
                new(){
                    Id = "5",
                    UserId = "1",
                    FoodId = "7",
                    UnitsId = "3",
                    MealTypeId = "2",
                    UnitsName = "порция",
                    FoodName = "Котлеты на пару, с фасолью",
                    Date = new(2024, 5, 1),
                    AmountEaten = 1,
                },
                new(){
                    Id = "6",
                    UserId = "1",
                    FoodId = "1",
                    UnitsId = "2",
                    MealTypeId = "4",
                    UnitsName = "шт",
                    FoodName = "Печенье (Любятово)",
                    Date = new(2024, 5, 2),
                    AmountEaten = 5,
                },
                new(){
                    Id = "7",
                    UserId = "1",
                    FoodId = "2",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Яблоко",
                    Date = new(2024, 5, 2),
                    AmountEaten = 2,
                },
                new(){
                    Id = "8",
                    UserId = "1",
                    FoodId = "3",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Банан",
                    Date = new(2024, 5, 2),
                    AmountEaten = 1,
                },
                new(){
                    Id = "9",
                    UserId = "1",
                    FoodId = "6",
                    UnitsId = "3",
                    MealTypeId = "1",
                    UnitsName = "порция",
                    FoodName = "Морковный суп",
                    Date = new(2024, 5, 2),
                    AmountEaten = 1,
                },
                new(){
                    Id = "10",
                    UserId = "1",
                    FoodId = "7",
                    UnitsId = "3",
                    MealTypeId = "2",
                    UnitsName = "порция",
                    FoodName = "Котлеты на пару, с фасолью",
                    Date = new(2024, 5, 2),
                    AmountEaten = 1,
                },
                new(){
                    Id = "11",
                    UserId = "1",
                    FoodId = "2",
                    UnitsId = "2",
                    MealTypeId = "4",
                    UnitsName = "шт",
                    FoodName = "Яблоко",
                    Date = new(2024, 5, 3),
                    AmountEaten = 2,
                },
                new(){
                    Id = "12",
                    UserId = "1",
                    FoodId = "3",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Банан",
                    Date = new(2024, 5, 3),
                    AmountEaten = 1,
                },
                new(){
                    Id = "13",
                    UserId = "1",
                    FoodId = "6",
                    UnitsId = "3",
                    MealTypeId = "1",
                    UnitsName = "порция",
                    FoodName = "Морковный суп",
                    Date = new(2024, 5, 3),
                    AmountEaten = 1,
                },
                new(){
                    Id = "14",
                    UserId = "1",
                    FoodId = "7",
                    UnitsId = "3",
                    MealTypeId = "2",
                    UnitsName = "порция",
                    FoodName = "Котлеты на пару, с фасолью",
                    Date = new(2024, 5, 3),
                    AmountEaten = 1,
                },
                new(){
                    Id = "15",
                    UserId = "1",
                    FoodId = "9",
                    UnitsId = "3",
                    MealTypeId = "3",
                    UnitsName = "порция",
                    FoodName = "Гречневая каша с мёдом",
                    Date = new(2024, 5, 3),
                    AmountEaten = 1,
                },
                new(){
                    Id = "16",
                    UserId = "1",
                    FoodId = "1",
                    UnitsId = "2",
                    MealTypeId = "4",
                    UnitsName = "шт",
                    FoodName = "Печенье (Любятово)",
                    Date = new(2024, 5, 4),
                    AmountEaten = 5,
                },
                new(){
                    Id = "17",
                    UserId = "1",
                    FoodId = "3",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Банан",
                    Date = new(2024, 5, 4),
                    AmountEaten = 1,
                },
                new(){
                    Id = "18",
                    UserId = "1",
                    FoodId = "6",
                    UnitsId = "3",
                    MealTypeId = "1",
                    UnitsName = "порция",
                    FoodName = "Морковный суп",
                    Date = new(2024, 5, 4),
                    AmountEaten = 1,
                },
                new(){
                    Id = "19",
                    UserId = "1",
                    FoodId = "7",
                    UnitsId = "3",
                    MealTypeId = "2",
                    UnitsName = "порция",
                    FoodName = "Котлеты на пару, с фасолью",
                    Date = new(2024, 5, 4),
                    AmountEaten = 1,
                },
                new(){
                    Id = "20",
                    UserId = "1",
                    FoodId = "9",
                    UnitsId = "3",
                    MealTypeId = "3",
                    UnitsName = "порция",
                    FoodName = "Гречневая каша с мёдом",
                    Date = new(2024, 5, 4),
                    AmountEaten = 1,
                },
                new(){
                    Id = "21",
                    UserId = "1",
                    FoodId = "2",
                    UnitsId = "2",
                    MealTypeId = "4",
                    UnitsName = "шт",
                    FoodName = "Яблоко",
                    Date = new(2024, 5, 4),
                    AmountEaten = 2,
                },
                new(){
                    Id = "22",
                    UserId = "1",
                    FoodId = "1",
                    UnitsId = "2",
                    MealTypeId = "4",
                    UnitsName = "шт",
                    FoodName = "Печенье (Любятово)",
                    Date = new(2024, 5, 5),
                    AmountEaten = 5,
                },
                new(){
                    Id = "23",
                    UserId = "1",
                    FoodId = "2",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Яблоко",
                    Date = new(2024, 5, 5),
                    AmountEaten = 2,
                },
                new(){
                    Id = "24",
                    UserId = "1",
                    FoodId = "3",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Банан",
                    Date = new(2024, 5, 5),
                    AmountEaten = 1,
                },
                new(){
                    Id = "25",
                    UserId = "1",
                    FoodId = "6",
                    UnitsId = "3",
                    MealTypeId = "1",
                    UnitsName = "порция",
                    FoodName = "Морковный суп",
                    Date = new(2024, 5, 5),
                    AmountEaten = 1,
                },
                new(){
                    Id = "26",
                    UserId = "1",
                    FoodId = "7",
                    UnitsId = "3",
                    MealTypeId = "2",
                    UnitsName = "порция",
                    FoodName = "Котлеты на пару, с фасолью",
                    Date = new(2024, 5, 5),
                    AmountEaten = 1,
                },
                new(){
                    Id = "27",
                    UserId = "1",
                    FoodId = "2",
                    UnitsId = "2",
                    MealTypeId = "4",
                    UnitsName = "шт",
                    FoodName = "Яблоко",
                    Date = new(2024, 5, 6),
                    AmountEaten = 2,
                },
                new(){
                    Id = "28",
                    UserId = "1",
                    FoodId = "3",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Банан",
                    Date = new(2024, 5, 6),
                    AmountEaten = 1,
                },
                new(){
                    Id = "29",
                    UserId = "1",
                    FoodId = "6",
                    UnitsId = "3",
                    MealTypeId = "1",
                    UnitsName = "порция",
                    FoodName = "Морковный суп",
                    Date = new(2024, 5, 6),
                    AmountEaten = 1,
                },
                new(){
                    Id = "30",
                    UserId = "1",
                    FoodId = "7",
                    UnitsId = "3",
                    MealTypeId = "2",
                    UnitsName = "порция",
                    FoodName = "Котлеты на пару, с фасолью",
                    Date = new(2024, 5, 6),
                    AmountEaten = 1,
                },
                new(){
                    Id = "31",
                    UserId = "1",
                    FoodId = "9",
                    UnitsId = "3",
                    MealTypeId = "3",
                    UnitsName = "порция",
                    FoodName = "Гречневая каша с мёдом",
                    Date = new(2024, 5, 6),
                    AmountEaten = 1,
                },
                new(){
                    Id = "32",
                    UserId = "1",
                    FoodId = "1",
                    UnitsId = "2",
                    MealTypeId = "4",
                    UnitsName = "шт",
                    FoodName = "Печенье (Любятово)",
                    Date = new(2024, 5, 7),
                    AmountEaten = 5,
                },
                new(){
                    Id = "33",
                    UserId = "1",
                    FoodId = "3",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Банан",
                    Date = new(2024, 5, 7),
                    AmountEaten = 1,
                },
                new(){
                    Id = "34",
                    UserId = "1",
                    FoodId = "6",
                    UnitsId = "3",
                    MealTypeId = "1",
                    UnitsName = "порция",
                    FoodName = "Морковный суп",
                    Date = new(2024, 5, 7),
                    AmountEaten = 1,
                },
                new(){
                    Id = "35",
                    UserId = "1",
                    FoodId = "7",
                    UnitsId = "3",
                    MealTypeId = "2",
                    UnitsName = "порция",
                    FoodName = "Котлеты на пару, с фасолью",
                    Date = new(2024, 5, 7),
                    AmountEaten = 1,
                },
                new(){
                    Id = "36",
                    UserId = "1",
                    FoodId = "9",
                    UnitsId = "3",
                    MealTypeId = "3",
                    UnitsName = "порция",
                    FoodName = "Гречневая каша с мёдом",
                    Date = new(2024, 5, 7),
                    AmountEaten = 1,
                },
                new(){
                    Id = "37",
                    UserId = "1",
                    FoodId = "2",
                    UnitsId = "2",
                    MealTypeId = "4",
                    UnitsName = "шт",
                    FoodName = "Яблоко",
                    Date = new(2024, 5, 7),
                    AmountEaten = 2,
                },
                new(){
                    Id = "38",
                    UserId = "1",
                    FoodId = "7",
                    UnitsId = "3",
                    MealTypeId = "2",
                    UnitsName = "порция",
                    FoodName = "Котлеты на пару, с фасолью",
                    Date = new(2024, 5, 8),
                    AmountEaten = 1,
                },
                new(){
                    Id = "39",
                    UserId = "1",
                    FoodId = "1",
                    UnitsId = "2",
                    MealTypeId = "4",
                    UnitsName = "шт",
                    FoodName = "Печенье (Любятово)",
                    Date = new(2024, 5, 8),
                    AmountEaten = 5,
                },
                new(){
                    Id = "40",
                    UserId = "1",
                    FoodId = "2",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Яблоко",
                    Date = new(2024, 5, 8),
                    AmountEaten = 2,
                },
                new(){
                    Id = "41",
                    UserId = "1",
                    FoodId = "3",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Банан",
                    Date = new(2024, 5, 8),
                    AmountEaten = 1,
                },
                new(){
                    Id = "42",
                    UserId = "1",
                    FoodId = "6",
                    UnitsId = "3",
                    MealTypeId = "1",
                    UnitsName = "порция",
                    FoodName = "Морковный суп",
                    Date = new(2024, 5, 8),
                    AmountEaten = 1,
                },
                new(){
                    Id = "43",
                    UserId = "1",
                    FoodId = "1",
                    UnitsId = "2",
                    MealTypeId = "4",
                    UnitsName = "шт",
                    FoodName = "Печенье (Любятово)",
                    Date = new(2024, 5, 9),
                    AmountEaten = 5,
                },
                new(){
                    Id = "44",
                    UserId = "1",
                    FoodId = "3",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Банан",
                    Date = new(2024, 5, 9),
                    AmountEaten = 1,
                },
                new(){
                    Id = "45",
                    UserId = "1",
                    FoodId = "6",
                    UnitsId = "3",
                    MealTypeId = "1",
                    UnitsName = "порция",
                    FoodName = "Морковный суп",
                    Date = new(2024, 5, 9),
                    AmountEaten = 1,
                },
                new(){
                    Id = "46",
                    UserId = "1",
                    FoodId = "7",
                    UnitsId = "3",
                    MealTypeId = "2",
                    UnitsName = "порция",
                    FoodName = "Котлеты на пару, с фасолью",
                    Date = new(2024, 5, 9),
                    AmountEaten = 1,
                },
                new(){
                    Id = "47",
                    UserId = "1",
                    FoodId = "9",
                    UnitsId = "3",
                    MealTypeId = "3",
                    UnitsName = "порция",
                    FoodName = "Гречневая каша с мёдом",
                    Date = new(2024, 5, 9),
                    AmountEaten = 1,
                },
                new(){
                    Id = "48",
                    UserId = "1",
                    FoodId = "2",
                    UnitsId = "2",
                    MealTypeId = "4",
                    UnitsName = "шт",
                    FoodName = "Яблоко",
                    Date = new(2024, 5, 9),
                    AmountEaten = 2,
                },
                new(){
                    Id = "49",
                    UserId = "1",
                    FoodId = "1",
                    UnitsId = "2",
                    MealTypeId = "4",
                    UnitsName = "шт",
                    FoodName = "Печенье (Любятово)",
                    Date = new(2024, 5, 10),
                    AmountEaten = 5,
                },
                new(){
                    Id = "50",
                    UserId = "1",
                    FoodId = "2",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Яблоко",
                    Date = new(2024, 5, 10),
                    AmountEaten = 2,
                },
                new(){
                    Id = "51",
                    UserId = "1",
                    FoodId = "3",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Банан",
                    Date = new(2024, 5, 10),
                    AmountEaten = 1,
                },
                new(){
                    Id = "52",
                    UserId = "1",
                    FoodId = "6",
                    UnitsId = "3",
                    MealTypeId = "1",
                    UnitsName = "порция",
                    FoodName = "Морковный суп",
                    Date = new(2024, 5, 10),
                    AmountEaten = 1,
                },
                new(){
                    Id = "53",
                    UserId = "1",
                    FoodId = "7",
                    UnitsId = "3",
                    MealTypeId = "2",
                    UnitsName = "порция",
                    FoodName = "Котлеты на пару, с фасолью",
                    Date = new(2024, 5, 10),
                    AmountEaten = 1,
                },
                new(){
                    Id = "54",
                    UserId = "1",
                    FoodId = "2",
                    UnitsId = "2",
                    MealTypeId = "4",
                    UnitsName = "шт",
                    FoodName = "Яблоко",
                    Date = new(2024, 5, 11),
                    AmountEaten = 2,
                },
                new(){
                    Id = "55",
                    UserId = "1",
                    FoodId = "3",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Банан",
                    Date = new(2024, 5, 11),
                    AmountEaten = 1,
                },
                new(){
                    Id = "56",
                    UserId = "1",
                    FoodId = "6",
                    UnitsId = "3",
                    MealTypeId = "1",
                    UnitsName = "порция",
                    FoodName = "Морковный суп",
                    Date = new(2024, 5, 11),
                    AmountEaten = 1,
                },
                new(){
                    Id = "57",
                    UserId = "1",
                    FoodId = "7",
                    UnitsId = "3",
                    MealTypeId = "2",
                    UnitsName = "порция",
                    FoodName = "Котлеты на пару, с фасолью",
                    Date = new(2024, 5, 11),
                    AmountEaten = 1,
                },
                new(){
                    Id = "58",
                    UserId = "1",
                    FoodId = "9",
                    UnitsId = "3",
                    MealTypeId = "3",
                    UnitsName = "порция",
                    FoodName = "Гречневая каша с мёдом",
                    Date = new(2024, 5, 11),
                    AmountEaten = 1,
                },
                new(){
                    Id = "59",
                    UserId = "1",
                    FoodId = "1",
                    UnitsId = "2",
                    MealTypeId = "4",
                    UnitsName = "шт",
                    FoodName = "Печенье (Любятово)",
                    Date = new(2024, 5, 12),
                    AmountEaten = 5,
                },
                new(){
                    Id = "60",
                    UserId = "1",
                    FoodId = "3",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Банан",
                    Date = new(2024, 5, 12),
                    AmountEaten = 1,
                },
                new(){
                    Id = "61",
                    UserId = "1",
                    FoodId = "6",
                    UnitsId = "3",
                    MealTypeId = "1",
                    UnitsName = "порция",
                    FoodName = "Морковный суп",
                    Date = new(2024, 5, 12),
                    AmountEaten = 1,
                },
                new(){
                    Id = "62",
                    UserId = "1",
                    FoodId = "7",
                    UnitsId = "3",
                    MealTypeId = "2",
                    UnitsName = "порция",
                    FoodName = "Котлеты на пару, с фасолью",
                    Date = new(2024, 5, 12),
                    AmountEaten = 1,
                },
                new(){
                    Id = "63",
                    UserId = "1",
                    FoodId = "9",
                    UnitsId = "3",
                    MealTypeId = "3",
                    UnitsName = "порция",
                    FoodName = "Гречневая каша с мёдом",
                    Date = new(2024, 5, 12),
                    AmountEaten = 1,
                },
                new(){
                    Id = "64",
                    UserId = "1",
                    FoodId = "1",
                    UnitsId = "2",
                    MealTypeId = "4",
                    UnitsName = "шт",
                    FoodName = "Печенье (Любятово)",
                    Date = new(2024, 5, 13),
                    AmountEaten = 5,
                },
                new(){
                    Id = "65",
                    UserId = "1",
                    FoodId = "3",
                    UnitsId = "2",
                    MealTypeId = "3",
                    UnitsName = "шт",
                    FoodName = "Банан",
                    Date = new(2024, 5, 13),
                    AmountEaten = 1,
                },
                new(){
                    Id = "66",
                    UserId = "1",
                    FoodId = "6",
                    UnitsId = "3",
                    MealTypeId = "1",
                    UnitsName = "порция",
                    FoodName = "Морковный суп",
                    Date = new(2024, 5, 13),
                    AmountEaten = 1,
                },
                new(){
                    Id = "67",
                    UserId = "1",
                    FoodId = "22",
                    UnitsId = "3",
                    MealTypeId = "2",
                    UnitsName = "порция",
                    FoodName = "Гречка с фаршем",
                    Date = new(2024, 5, 13),
                    AmountEaten = 1,
                },
                new(){
                    Id = "68",
                    UserId = "1",
                    FoodId = "9",
                    UnitsId = "3",
                    MealTypeId = "3",
                    UnitsName = "порция",
                    FoodName = "Гречневая каша с мёдом",
                    Date = new(2024, 5, 13),
                    AmountEaten = 1,
                },
                new(){
                    Id = "69",
                    UserId = "1",
                    FoodId = "2",
                    UnitsId = "2",
                    MealTypeId = "4",
                    UnitsName = "шт",
                    FoodName = "Яблоко",
                    Date = new(2024, 5, 13),
                    AmountEaten = 2,
                },
                ];
        }

        public async Task<bool> AddItemAsync(MealModel item)
        {
            _data.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = _data.Where((MealModel arg) => arg.Id == id).FirstOrDefault();
            _data.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<MealModel> GetItemAsync(string id)
        {
            return await Task.FromResult(_data.FirstOrDefault(s => s.Id == id));
        }

        public async Task<List<MealModel>> GetAllItemsAsync()
        {
            return await Task.FromResult(_data);
        }

        public async Task<bool> UpdateItemAsync(MealModel item)
        {
            int index = _data.FindIndex((MealModel arg) => arg.Id == item.Id);
            _data[index] = item;

            return await Task.FromResult(true);
        }
    }
}
