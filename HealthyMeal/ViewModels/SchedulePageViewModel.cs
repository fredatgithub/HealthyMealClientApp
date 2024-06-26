﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HealthyMeal.Models;
using HealthyMeal.Utils;
using HealthyMeal.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Xamarin.Forms;



namespace HealthyMeal.ViewModels
{
    public partial class SchedulePageViewModel : BaseViewModel, IQueryAttributable
    {
        #region Поля

        private DateTime _date;

        private MonthModel _selectedMonth;

        private string _userId;

        #endregion

        #region ObservableProperties

        [ObservableProperty]
        private List<MonthModel> _months;

        [ObservableProperty]
        private ObservableCollection<DayModel> _days = [];

        [ObservableProperty]
        private double _totalKcalAmount;

        [ObservableProperty]
        private double _averageKcalAmount;

        #endregion

        #region Свойства

        public MonthModel SelectedMonth
        {
            get => _selectedMonth;
            set 
            { 
                _selectedMonth = value;
                LoadDataByMonth();
                OnPropertyChanged(nameof(SelectedMonth));
            } 
        }

        #endregion

        #region Команды

        [RelayCommand]
        private async Task GoBack()
        {
            await Shell.Current.GoToAsync($"..");
        }

        #endregion

        #region Конструкторы

        public SchedulePageViewModel()
        {
            CreateMonthList();
        }

        #endregion

        #region Методы

        public void ApplyQueryAttributes(IDictionary<string, string> query)
        {
            if (query.ContainsKey("Date"))
            {
                string date = HttpUtility.UrlDecode(query["Date"]);
                _date = NavigationParameterConverter.ObjectFromPairKeyValue<DateTime>(date);
            }
            else
            {
                DateTime today = DateTime.Now;
                _date = new DateTime(today.Year, today.Month, today.Day);
            }

            if (query.ContainsKey("UserId"))
            {
                string userId = HttpUtility.UrlDecode(query["UserId"]);
                _userId = NavigationParameterConverter.ObjectFromPairKeyValue<string>(userId);
            }
            else
            {
                _userId = "Common";
            }

            SelectedMonth = Months.Find(m => m.Number == _date.Month);
        }

        #endregion

        #region Внутренние методы

        private async void LoadDataByMonth()
        {
            Days.Clear();
            int year = _date.Year;
            int month = SelectedMonth.Number;
            ObservableCollection<DayModel> daysBuf = [];
            for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++)
            {
                DateTime date = new(year, month, i);
                daysBuf.Add(new() { Date = date });
            }
            daysBuf = new(daysBuf.OrderByDescending(d => d.DayNumber));

            List<MealModel> meals = [];
            meals = await GlobalDataStore.Meals.GetAllItemsAsync();
            List<NutritionalValueModel> nutritionalValues = await GlobalDataStore.NutritionalValues.GetAllItemsAsync();
            foreach (MealModel meal in meals)
            {
                meal.NutritionalValue = nutritionalValues.Find(n => n.FoodId == meal.FoodId && n.UnitsId == meal.UnitsId);
            }

            foreach (DayModel day in daysBuf)
            {
                List<MealModel> mealsBuf = [];
                mealsBuf = meals.Where(m => m.Date == day.Date).ToList();
                day.KcalAmount = mealsBuf.Sum(m => m.Kcal);
            }

            Days = daysBuf;
            double totalKcalAmount = Days.Sum(d => d.KcalAmount);
            double avgKcalAmount = totalKcalAmount / Days.Count;
            TotalKcalAmount = totalKcalAmount;
            AverageKcalAmount = Math.Round(avgKcalAmount, 1, MidpointRounding.AwayFromZero);
        }

        private void CreateMonthList()
        {
            List<MonthModel> monthList = [];
            for (int i = 1; i <= 12; i++)
                monthList.Add(new(i));

            Months = monthList;
        }

        #endregion
    }
}
