﻿using GlucoMan.BusinessLayer;
using static GlucoMan.Common;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GlucoMan.Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MealPage : ContentPage
    {
        // since it is accessed by several pages, to avoid "concurrent" problems 
        // we use a common business layer beetween different pages
        private BL_MealAndFood bl = Common.MealAndFood_CommonBL;

        private bool loading = true;

        private Accuracy accuracyMeal;
        private Accuracy accuracyFoodInMeal;

        FoodsPage foodsPage; 

        public MealPage(Meal Meal)
        {
            InitializeComponent();
            if (Meal == null)
                Meal = new Meal();
            bl.Meal = Meal;
            
            loading = true;

            cmbAccuracyMeal.ItemsSource = Enum.GetValues(typeof(QualitativeAccuracy));
            cmbAccuracyFoodInMeal.ItemsSource = Enum.GetValues(typeof(QualitativeAccuracy));

            accuracyMeal = new Accuracy(txtAccuracyOfChoMeal, cmbAccuracyMeal, bl);
            accuracyFoodInMeal = new Accuracy(txtAccuracyOfChoFoodInMeal, cmbAccuracyFoodInMeal, bl);

            if (bl.Meal.IdTypeOfMeal == TypeOfMeal.NotSet)
            {
                bl.Meal.IdTypeOfMeal = Common.SelectTypeOfMealBasedOnTimeNow();
            }
            //bl.RestoreFoodInMealParameters();
            bl.RestoreMealParameters();
            //bl.FoodInMeal.AccuracyOfChoEstimate.Double = 0;
            FromClassToUi();
            RefreshGrid();

            loading = false;
        }
        protected override async void OnAppearing()
        {
            // set focus to a specific field
            // (currently deemed not necessary and commented out)

            // base.OnAppearing();
            // await Task.Delay(1);
            // txtFoodChoPercent.Focus();

            if (foodsPage!= null)
            {
                // 
                if (foodsPage.FoodIsChosen)
                {
                    bl.FromFoodToFoodInMeal(foodsPage.CurrentFood, bl.FoodInMeal);
                    FromClassToUi(); 
                }
            }
        }
        private void RefreshGrid()
        {
            bl.FoodsInMeal = bl.GetFoodsInMeal(bl.Meal.IdMeal);
            gridFoodsInMeal.BindingContext = bl.FoodsInMeal;
        }
        private void FromClassToUi()
        {
            loading = true;

            txtIdMeal.Text = bl.Meal.IdMeal.ToString();
            txtChoOfMealGrams.Text = bl.Meal.ChoGrams.Text;

            if (bl.Meal.IdMeal != null)
                txtIdMeal.Text = bl.Meal.IdMeal.ToString();
            else
                txtIdMeal.Text = "";         
            
            txtAccuracyOfChoMeal.Text = bl.Meal.AccuracyOfChoEstimate.Text;

            if (bl.FoodInMeal.IdFoodInMeal != null)
                txtIdFoodInMeal.Text = bl.FoodInMeal.IdFoodInMeal.ToString();
            else
                txtIdFoodInMeal.Text = "";
            if (bl.FoodInMeal.IdFood != null)
                txtIdFood.Text = bl.FoodInMeal.IdFood.ToString();
            else
                txtIdFood.Text = "";

            txtFoodChoPercent.Text = bl.FoodInMeal.ChoPercent.Text;
            txtFoodQuantityGrams.Text = bl.FoodInMeal.QuantityGrams.Text;
            txtFoodChoGrams.Text = bl.FoodInMeal.ChoGrams.Text;

            txtFoodInMealName.Text = bl.FoodInMeal.Name;

            loading = false;
        }
        private void FromUiToClass()
        {
            loading = true;

            bl.Meal.IdMeal = Safe.Int(txtIdMeal.Text);
            bl.Meal.ChoGrams.Text = txtChoOfMealGrams.Text;

            bl.Meal.AccuracyOfChoEstimate.Text = txtAccuracyOfChoMeal.Text;
            
            bl.FoodInMeal.IdMeal = Safe.Int(txtIdMeal.Text);
            bl.FoodInMeal.IdFoodInMeal = Safe.Int(txtIdFoodInMeal.Text);
            bl.FoodInMeal.IdFood = Safe.Int(txtIdFood.Text);
            bl.FoodInMeal.QuantityGrams.Text = txtFoodQuantityGrams.Text; // [g]
            bl.FoodInMeal.ChoPercent.Text = txtFoodChoPercent.Text;
            bl.FoodInMeal.ChoGrams.Text = txtFoodChoGrams.Text;
            bl.FoodInMeal.Name = txtFoodInMealName.Text;
            bl.FoodInMeal.AccuracyOfChoEstimate.Text = txtAccuracyOfChoFoodInMeal.Text;
            //if (cmbAccuracyFoodInMeal.SelectedItem != null)
            //    bl.FoodInMeal.QualitativeAccuracyOfCho = ((QualitativeAccuracy)cmbAccuracyFoodInMeal.SelectedItem);

            loading = false;
        }
        private void txtFoodChoPercent_TextChanged(object sender, EventArgs e)
        {
            if (!loading)
            {
                bl.FoodInMeal.ChoPercent.Text = txtFoodChoPercent.Text; 
                bl.CalculateChoOfFoodGrams(bl.FoodInMeal);
                txtFoodChoGrams.Text = bl.FoodInMeal.ChoGrams.Text; 
            }
        }
        private void txtFoodQuantityGrams_TextChanged(object sender, EventArgs e)
        {
            if (!loading)
            {
                bl.FoodInMeal.QuantityGrams.Text = txtFoodQuantityGrams.Text;
                bl.CalculateChoOfFoodGrams(bl.FoodInMeal);
                txtFoodChoGrams.Text = bl.FoodInMeal.ChoGrams.Text;
            }
        }
        private void txtFoodChoGrams_TextChanged(object sender, EventArgs e)
        {
            if (!loading)
            {
                if (!txtFoodQuantityGrams.IsFocused && !txtFoodChoPercent.IsFocused)
                {
                    txtFoodQuantityGrams.Text = "";
                    bl.FoodInMeal.QuantityGrams.Double = 0;
                    txtFoodChoPercent.Text = "";
                    bl.FoodInMeal.ChoPercent.Double = 0;
                }
            }
            bl.SaveFoodInMealParameters();
        }
        private void txtChoOfMealGrams_TextChanged(object sender, EventArgs e)
        {
            bl.SaveMealParameters();
        }
        private void cmbAccuracyMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            loading = true;
            {
                if (cmbAccuracyMeal.SelectedItem != null)
                {
                    int accuracy = Convert.ToInt32((QualitativeAccuracy)cmbAccuracyMeal.SelectedItem);
                    txtAccuracyOfChoMeal.Text = accuracy.ToString();
                    bl.Meal.AccuracyOfChoEstimate.Double = accuracy;
                    bl.RecalcTotalAccuracy();
                    FromClassToUi();
                }
            }
            loading = false; 
        }
        private void txtAccuracyOfChoFoodInMeal_TextChanged(object sender, EventArgs e) 
        {
            if (!loading)
            {
                bl.FoodInMeal.AccuracyOfChoEstimate.Double = Safe.Double(txtAccuracyOfChoFoodInMeal.Text);
                bl.RecalcTotalAccuracy();
                FromClassToUi();
            }
        }
        private void btnSaveAllMeal_Click(object sender, EventArgs e)
        {
            FromUiToClass();
            txtIdMeal.Text = bl.SaveOneMeal(bl.Meal).ToString();
            bl.SaveAllFoodsInMeal();
        }
        private void btnAddFoodInMeal_Click(object sender, EventArgs e)
        {
            if (txtIdMeal.Text == "")
                btnSaveAllMeal_Click(null, null);
            FromUiToClass();
            // erase Id, so that a new record will be created
            bl.FoodInMeal.IdFoodInMeal = null;
            bl.SaveOneFoodInMeal(bl.FoodInMeal);
            bl.RecalcTotalCho();
            bl.RecalcTotalAccuracy();
            bl.SaveMealParameters();
            FromClassToUi();
            RefreshGrid();
        }
        private void btnRemoveFoodInMeal_Click(object sender, EventArgs e)
        {
            bl.DeleteOneFoodInMeal(bl.FoodInMeal);
            bl.RecalcTotalCho();
            bl.SaveMealParameters(); 
            FromClassToUi();
            RefreshGrid();
        }
        private async void btnFoodDetail_ClickAsync(object sender, EventArgs e)
        {
            FromUiToClass();
            foodsPage = new FoodsPage(bl.FoodInMeal); 
            await Navigation.PushAsync(foodsPage);
            if (foodsPage.FoodIsChosen)
            {
                bl.FromFoodToFoodInMeal(foodsPage.CurrentFood, bl.FoodInMeal);
                FromClassToUi(); 
            }
        }
        // in this UI we have no buttons to save just one food in meal 
        //private void btnSaveFoodInMeal_Click(object sender, EventArgs e)
        //{
        //    if (gridFoodsInMeal.SelectedRows.Count == 0)
        //    {
        //        MessageBox.Show("Choose a food to save");
        //        return;
        //    }
        //    FromUiToClass();
        //    bl.SaveOneFoodInMeal(bl.FoodInMeal);
        //    FromClassToUi();
        //    RefreshGrid();
        //}
        private void btnDefaults_Click(object sender, EventArgs e)
        {
            txtFoodChoPercent.Text = "";
            txtFoodQuantityGrams.Text = "";
            txtFoodChoGrams.Text = "";
            txtAccuracyOfChoFoodInMeal.Text = "";
            cmbAccuracyFoodInMeal.SelectedItem = null;
            txtIdFoodInMeal.Text = "";
            txtIdFood.Text = "";
            txtFoodInMealName.Text = "";
        }
        private void btnSumCho_Click(object sender, EventArgs e)
        {
            FromUiToClass();
            bl.RecalcTotalCho();
            bl.RecalcTotalAccuracy();
            bl.SaveMealParameters();
            FromClassToUi();
        }
        private void btnSaveAllFoods_Click(object sender, EventArgs e)
        {
            FromUiToClass();
            bl.SaveAllFoodsInMeal();
            FromClassToUi();
            RefreshGrid();
        }
        private async void btnSearchFood_ClickAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodsPage(txtFoodInMealName.Text, "")); 
        }
        private async void OnGridSelectionAsync(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                //await DisplayAlert("XXXX", "YYYY", "Ok");
                return;
            }
            loading = true;
            //make the tapped row the current meal 
            bl.FoodInMeal = (FoodInMeal)gridFoodsInMeal.SelectedItem;
            bl.SaveFoodInMealParameters(); 
            FromClassToUi();
            loading = false;
        }
        
        private async void btnFoodCalc_ClickAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodToHitTargetCarbsPage());
        }
        private async void btnInsulinCalc_ClickAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InsulinCalcPage());
        }
        private async void btnGlucose_ClickAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlucoseMeasurementPage());
        }
        private void btnWeighFood_Click(object sender, EventArgs e)
        {
            //////frmWeighFood fw = new frmWeighFood();
            //////fw.ShowDialog();
        }
    }
}